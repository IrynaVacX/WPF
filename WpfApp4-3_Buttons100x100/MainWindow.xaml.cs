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

namespace WpfApp4_3_Buttons100x100
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image im = new Image();
            im.Source = new BitmapImage(new Uri("../../1.png"));
            Image[,] arrim = new Image[100, 100];
            /*int imPartsOnSide;
            if (im.Width > im.Height)
                imPartsOnSide = (int)im.Width / 100;
            else
                imPartsOnSide = (int)im.Width / 100;*/
            FrameworkElement el = new FrameworkElement();
            
            List<Color> pixelList = getPixels(el);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    //arrim[i, j] = im.;
                }
            }
            Button b;
            for (int i = 0; i < 100; i++)
            {
                grid1.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
                grid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            }
            for (int i = 0, x = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++, x++)
                {
                    b = new Button() {
                        Name = "but" + x.ToString(),
                        Content = (x+1).ToString(),
                        Width = 100,
                        Height = 100 };
                    grid1.Children.Add(b);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                }
            }
        }

        List<Color> getPixels(FrameworkElement elem)
        {
            PresentationSource source = PresentationSource.FromVisual(this);
            double dpiX = 96.0 * source.CompositionTarget.TransformToDevice.M11;
            double dpiY = 96.0 * source.CompositionTarget.TransformToDevice.M22;

            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)elem.ActualWidth, (int)elem.ActualHeight, dpiX, dpiY, PixelFormats.Pbgra32);
            bitmap.Render(elem);

            int width = bitmap.PixelWidth;
            int height = bitmap.PixelHeight;
            int[] array = new int[width * 4 * height];

            bitmap.CopyPixels(array, width * 4, 0);

            List<Color> pixels = new List<Color>();
            for (int i = 0; i < array.Length; i++)
            {
                byte[] bytes = BitConverter.GetBytes(array[i]);
                Color pixel = Color.FromArgb(bytes[3], bytes[2], bytes[1], bytes[0]);
                pixels.Add(pixel);
            }

            return pixels;
        }

    }
}
