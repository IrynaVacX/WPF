using System;
using System.IO;
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
using Microsoft.Win32;

namespace WpfApp8_03_TextBoxFile
{
    public partial class MainWindow : Window
    {
        public string FileText { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ReadFile(string path)
        {
            FileText = File.ReadAllText(path);
        }
        private void butOpenF_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == true)
                ReadFile(fd.FileName);
        }
    }
}
