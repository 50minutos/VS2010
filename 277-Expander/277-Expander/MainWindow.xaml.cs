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
using System.Windows.Markup;

namespace _277_Expander
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

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            foreach (var item in sp.Children)
            {
                ((Expander)item).IsExpanded = ((Expander)sender).Name == ((Expander)item).Name;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IAddChild container = sp;

            Expander ex = new Expander();
            ex.Header = "meu expander";
            ex.Margin = new Thickness(30);
            ex.Expanded += new RoutedEventHandler(Expander_Expanded);

            container.AddChild(ex);

            Button button1 = new Button();
            button1.Content = "Clique aqui";
            button1.Margin = new Thickness(30);

            container = ex;
            container.AddChild(button1);
        }
    }
}
