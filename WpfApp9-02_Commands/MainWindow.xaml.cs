using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp9_02_Commands
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Bold(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
        }
        private void Italic(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }
        private void Underline(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextBlock.TextDecorationsProperty, TextDecorations.Underline);
        }
        private void Clear(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
            {
                var textRange = new TextRange(rtb1.Selection.Start, rtb1.Selection.End);
                textRange.ApplyPropertyValue(TextElement.FontSizeProperty, (double)12);
                rtb1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                rtb1.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
                rtb1.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
                rtb1.Selection.ApplyPropertyValue(TextBlock.TextDecorationsProperty, null);
            }
        }
        private void FontSize15(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, 15.0);
        }
        private void FontSize30(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, 30.0);
        }
        private void colorRed(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
        }
        private void colorGreen(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.ForestGreen);
        }
        private void colorBlue(object sender, ExecutedRoutedEventArgs e)
        {
            if (!rtb1.Selection.IsEmpty)
                rtb1.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.DeepSkyBlue);
        }
    }
    public static class RTBCommands
    {
        static RTBCommands()
        {
            Bold = new RoutedCommand("Bold", typeof(RTBCommands));
            Italic = new RoutedCommand("Italic", typeof(RTBCommands));
            Underline = new RoutedCommand("Underline", typeof(RTBCommands));
            Clear = new RoutedCommand("Clear", typeof(RTBCommands));
            FontSize15 = new RoutedCommand("FontSize15", typeof(RTBCommands));
            FontSize30 = new RoutedCommand("FontSize30", typeof(RTBCommands));
            colorRed = new RoutedCommand("colorRed", typeof(RTBCommands));
            colorGreen = new RoutedCommand("colorGreen", typeof(RTBCommands));
            colorBlue = new RoutedCommand("colorBlue", typeof(RTBCommands));
        }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }
        public static RoutedCommand Clear { get; set; }
        public static RoutedCommand FontSize15 { get; set; }
        public static RoutedCommand FontSize30 { get; set; }
        public static RoutedCommand colorRed { get; set; }
        public static RoutedCommand colorGreen { get; set; }
        public static RoutedCommand colorBlue { get; set; }
    }
}
