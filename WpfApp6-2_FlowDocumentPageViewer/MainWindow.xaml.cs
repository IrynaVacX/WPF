using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using Microsoft.Win32;

namespace WpfApp6_2_FlowDocumentPageViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenTXTFile();
        }
        private void LoadText(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);

            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(sr.ReadToEnd());

            FlowDocument document = new FlowDocument(paragraph);
            fdr.Document = document;

            sr.Close();
        }
        private void OpenTXTFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
                LoadText(dlg.FileName);
        }
    }
}
