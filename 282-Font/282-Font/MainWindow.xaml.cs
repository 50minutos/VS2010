using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _282_Font
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.FontFamily = new FontFamily("Old English Text MT");
            TextBox1.FontSize = 16;
            TextBox1.FontStretch = FontStretches.Expanded;
            TextBox1.FontStyle = FontStyles.Normal;
            TextBox1.FontWeight = FontWeights.ExtraBold;
        }
    }
}
