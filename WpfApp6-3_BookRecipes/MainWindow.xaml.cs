using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WpfApp6_3_BookRecipes
{
    public partial class MainWindow : Window
    {
        List<Recipe> RecipesList;
        public MainWindow()
        {
            InitializeComponent();
            RecipesList = new List<Recipe>();
        }
        private void Load(string strDir)
        {
            ListBoxItem lbi;
            foreach (var it in Directory.GetFiles(strDir))
            {
                if (it.Contains(".txt"))
                {
                    lbi = new ListBoxItem();
                    lbi.Content = it.Substring(it.LastIndexOf('\\') + 1);
                    lbi.Tag = it;
                    RecipesListBox.Items.Add(lbi);
                    LoadData(it);
                }
            }
        }
        private void LoadData(string filename)
        {
            if (new FileInfo(filename).Exists)
            {
                StreamReader sr = new StreamReader(new FileInfo(filename).FullName);
                string[] str = sr.ReadToEnd().Split(new char[] { '\n' });
                Recipe r = new Recipe();
                r.Image = str[0];
                r.Name = str[1];
                string text = "";
                for(int i = 2; i < str.Length; i++)
                {
                    if (str[i].Contains("#@~+"))
                    {
                        r.Ingridients = text;
                        text = "";
                    }
                    else
                        text += str[i] + '\n';
                }
                r.Cooking = text;
                RecipesList.Add(r);
                sr.Close();
            }
        }
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog fd = new CommonOpenFileDialog();
            fd.IsFolderPicker = true;
            if (fd.ShowDialog() == CommonFileDialogResult.Ok)
                Load(fd.FileName);
        }
        private void RecipesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RecipeName.Text = RecipesList[RecipesListBox.SelectedIndex].Name;
            RecipeImage.Source = new BitmapImage(new Uri(RecipesList[RecipesListBox.SelectedIndex].Image));
            FlowDocument fd = new FlowDocument();
            fd.Blocks.Add(new Paragraph(new Run(RecipesList[RecipesListBox.SelectedIndex].Ingridients)));
            RecipeIngred.Document = fd;
            fd = new FlowDocument();
            fd.Blocks.Add(new Paragraph(new Run(RecipesList[RecipesListBox.SelectedIndex].Cooking)));
            RecipeCooking.Document = fd;
        }
    }

    public class Recipe
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Ingridients { get; set; }
        public string Cooking { get; set; }
    }
}
