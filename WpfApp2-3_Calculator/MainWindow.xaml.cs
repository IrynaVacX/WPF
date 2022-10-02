using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2_3_Calculator
{
    public partial class MainWindow : Window
    {
        private bool ifEqualsOn = false;
        public MainWindow()
        {
            InitializeComponent();
            _display.Text = "0";
            _display2.Text = "";
        }
        private void _C_Click(object sender, RoutedEventArgs e)
        {
            _display.Text = "0";
            _display2.Text = "";
        }
        private void _CE_Click(object sender, RoutedEventArgs e)
        {
            _display.Text = "0";
        }
        private void _dels_Click(object sender, RoutedEventArgs e)
        {
            if (_display.Text.Length == 1)
                _display.Text = "0";
            else
                _display.Text = _display.Text.Substring(0, _display.Text.Length - 1);
        }
        private void printDigits_Click(object sender, RoutedEventArgs e)
        {
            if (ifEqualsOn)
            {
                _display2.Text = "";
                _display.Text = "";
                ifEqualsOn = false;
            }
            else if (_display.Text == "0")
                _display.Text = "";
            _display.Text += (sender as Button).Content;
        }
        private void _koma_Click(object sender, RoutedEventArgs e)
        {
            if (!_display.Text.Contains(','))
                _display.Text += (sender as Button).Content;
        }
        private void printZnak_Click(object sender, RoutedEventArgs e)
        {
            if (_display2.Text.Length == 0)
            {
                _display2.Text = _display.Text + ' ' + (sender as Button).Content;
                _display.Text = "0";
            }
            else
            {
                _display2.Text = GetF(_display.Text, _display2.Text).ToString() + ' ' + (sender as Button).Content;
                _display.Text = "0";
            }
        }
        private object GetF(string tb1, string tb2)
        {
            if (tb2.Contains('x') || tb2.Contains('÷'))
            {
                if (tb2.Contains('x'))
                    tb2 = tb2.Substring(0, tb2.Length - 1) + '*';
                else if (tb2.Contains('÷'))
                    tb2 = tb2.Substring(0, tb2.Length - 1) + '/';
            }
            if (tb2.Contains(',') || tb1.Contains(','))
            {
                int i = tb2.LastIndexOf(',');
                if (i != -1)
                    tb2 = tb2.Substring(0, i) + '.' + tb2.Substring(i + 1, tb2.Length - i - 1);
                i = tb1.LastIndexOf(',');
                if (i != -1)
                    tb1 = tb1.Substring(0, i) + '.' + tb1.Substring(i + 1, tb1.Length - i - 1);
            }
            return new DataTable().Compute(tb2 + ' ' + tb1, null);
        }
        private void _equals_Click(object sender, RoutedEventArgs e)
        {
            if (ifEqualsOn)
                return;
            var res = GetF(_display.Text, _display2.Text).ToString();
            _display2.Text += ' ' + _display.Text + " =";
            _display.Text = res;
            ifEqualsOn = true;
        }
        private void printPlusOrMinus_Click(object sender, RoutedEventArgs e)
        {
            if (_display.Text == "0")
                return;
            if (!_display.Text.Contains('-'))
                _display.Text = '-' + _display.Text;
            else
                _display.Text = _display.Text.Substring(1, _display.Text.Length - 1);
        }
    }
}
