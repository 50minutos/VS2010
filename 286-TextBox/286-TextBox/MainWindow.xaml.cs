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

namespace _286_TextBox
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

        private void txt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txtSelection != null)
                txtSelection.Text = String.Format(
                    "Seleção a partir do caractere {0} com {1} caracteres de comprimento é \"{2}\"",
                    txt.SelectionStart, txt.SelectionLength, txt.SelectedText);
        }

        private void txt_MouseEnter(object sender, MouseEventArgs e)
        {
            txt.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
        }

        private void txt_MouseLeave(object sender, MouseEventArgs e)
        {
            txt.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
        }
    }
}
