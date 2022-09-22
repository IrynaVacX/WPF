using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid myGrid = new Grid();
            myGrid.Width = this.Width;
            myGrid.Height = this.Height;
            myGrid.HorizontalAlignment = HorizontalAlignment.Center;
            myGrid.VerticalAlignment = VerticalAlignment.Center;
            myGrid.ShowGridLines = true;

            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());

            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.RowDefinitions.Add(new RowDefinition());

            Button but;
            double r;
            for (int i = 0, index = 1; i < 3; i++)
            {
                for (int j = 0; j < 3; j++, index++)
                {
                    but = new Button();
                    but.FontSize = 20;
                    but.Width = myGrid.Width / 3;
                    but.Height = myGrid.Height / 3;
                    but.Name = "button" + index;
                    but.Content = "Button" + index;

                    GradientStopCollection gsc = new GradientStopCollection();
                    gsc.Add(new GradientStop()
                    {
                        Color = Color.FromRgb(((byte)new Random().Next(90, 255)), ((byte)new Random().Next(90, 255)), ((byte)new Random().Next(90, 255))),
                        Offset = 0
                    });
                    gsc.Add(new GradientStop()
                    {
                        Color = Color.FromRgb(((byte)new Random().Next(90, 255)), ((byte)new Random().Next(90, 255)), ((byte)new Random().Next(90, 255))),
                        Offset = 0.55
                    });
                    r = new Random().NextDouble();
                    but.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0, r),
                        EndPoint = new Point(r, 1)
                    };
                    Grid.SetRow(but, i);
                    Grid.SetColumn(but, j);
                    myGrid.Children.Add(but);
                }
            }
            this.Content = myGrid;
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }
    }
}
