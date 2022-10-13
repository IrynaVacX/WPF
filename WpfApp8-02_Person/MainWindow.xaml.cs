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
using System.ComponentModel;

namespace WpfApp8_02_Person
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_Change_Click(object sender, RoutedEventArgs e)
        {
            int res;
            ((Person)this.Resources["ClassPerson"]).Name = tb_name.Text;
            ((Person)this.Resources["ClassPerson"]).Surname = tb_surname.Text;
            ((Person)this.Resources["ClassPerson"]).Age = Int32.TryParse(tb_age.Text, out res) ? res : 0;
            MessageBox.Show("changed!");
        }
        private void but_ShowState_Click(object sender, RoutedEventArgs e)
        {
            (this.Resources["ClassPerson"] as Person).ShowState();
        }
    }
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void ShowState()
        {
            MessageBox.Show("Name : " + Name + "\nSurname : " + Surname + "\nAge : " + Age);
        }
    }
}
