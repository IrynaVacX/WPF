using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp6_3_BookRecipes
{
    public partial class MainWindow : Window
    {
        List<string> rcp_NameIngred;
        List<string> rcp_Cooking;
        List<Image> rcp_pictures;
        public MainWindow()
        {
            InitializeComponent();
            rcp_NameIngred = new List<string>();
            rcp_Cooking = new List<string>();
            rcp_pictures = new List<Image>();
            GetFilesFromDir("../../Recipes/");
        }
        private void GetFilesFromDir(string dirpath)
        {
            StreamReader sr;
            string[] files = Directory.GetFiles(dirpath);
            foreach (string f in files)
            {
                sr = new StreamReader(f);
                /*if (sr != null && sr.)
                {

                }*/
            }
        }
    }
}
