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

namespace _271_GridLayoutDinamico
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
        
        private void Chk_Unchecked(object sender, RoutedEventArgs e)
        {
            Voltar.Content = "voltar";
            Avancar.Content = "avançar";
        }

        private void Chk_Checked(object sender, RoutedEventArgs e)
        {
            Voltar.Content = "clique aqui para voltar";
            Avancar.Content = "clique aqui para avançar";
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("voltei (mentira)");
        }

        private void Avancar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("avancei (mentira)");
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
