using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Load(string strDir)
        {
            ListBoxItem lbi;
            foreach (var it in Directory.GetFiles(strDir))
            {
                if (it.Contains(".png") || it.Contains(".jpg") || it.Contains(".gif"))
                {
                    lbi = new ListBoxItem();
                    lbi.Content = it.Substring(it.LastIndexOf('\\')+1);
                    lbi.Tag = it;
                    lb1.Items.Add(lbi);
                }
            }
        }
        private void bLoadF_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog fd = new CommonOpenFileDialog();
            fd.IsFolderPicker = true;
            if (fd.ShowDialog() == CommonFileDialogResult.Ok)
                Load(fd.FileName);
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            lb1.Items.Remove(lb1.SelectedItem);
        }
    }
}
