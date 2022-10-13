using System.Windows;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace WpfApp10_02_ViewModel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void butAdd_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });

            Label lable1 = new Label() { Content = VM._Color.Color, Margin = new Thickness(5, 5, 5, 5) };
            Grid.SetColumn(lable1, 0);
            grid.Children.Add(lable1);

            Rectangle rectangle1 = new Rectangle() { Width = 400, Height = 25, Fill = VM._Color, Margin = new Thickness(5, 5, 5, 5) };
            Grid.SetColumn(rectangle1, 1);
            grid.Children.Add(rectangle1);

            Button button1 = new Button() { Content = "Delete", Width = 100, Height = 25, Margin = new Thickness(5, 5, 5, 5) };
            button1.Click += butDelete_Click;
            Grid.SetColumn(button1, 2);
            grid.Children.Add(button1);

            lb1.Items.Add(grid);
        }
        private void butDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (var it in lb1.Items)
                if ((it as Grid) != null)
                    foreach (var i in (it as Grid).Children)
                        if (i == (sender as Button))
                        {
                            lb1.Items.Remove(it);
                            return;
                        }
        }
    }
}
