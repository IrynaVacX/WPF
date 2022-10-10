using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace WpfApp7_Localization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combox1.SelectedIndex = 0;
        }
        private void ChangeLanguage(string str)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(str);
            button1.Content = Localization.ButtonText;
            lable1.Content = Localization.LabelText;
            image1.Source = new BitmapImage(new Uri(Localization.ImageSource));
        }
        private void combox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeLanguage(((sender as ComboBox).SelectedItem as ComboBoxItem).Name.Replace('_','-'));
        }
    }
}
