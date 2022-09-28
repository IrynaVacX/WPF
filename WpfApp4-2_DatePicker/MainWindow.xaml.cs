using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4_2_DatePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime dt1;
        DateTime dt2;
        public MainWindow()
        {
            InitializeComponent();
            tb1.Text = "0";
        }
        private void _C1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = _C1.SelectedDate;
            dt1 = selectedDate.Value.Date;
            if (_C2.SelectedDate!=null)
                tb1.Text = PrintDays(dt1, dt2).ToString();
        }
        private void _C2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = _C2.SelectedDate;
            dt2 = selectedDate.Value.Date;
            if (_C1.SelectedDate != null)
                tb1.Text = PrintDays(dt1, dt2).ToString();
        }
        private int PrintDays(DateTime d1, DateTime d2)
        {
            if (d1 > d2)
                return (int)((d1 - d2).TotalSeconds) / 3600 / 24;
            else
                return (int)((d2 - d1).TotalSeconds) / 3600 / 24;
        }
    }
}
