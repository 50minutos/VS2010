using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace _296_OneWayBinding
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SliderTamanho_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (SliderTamanho != null)
                Texto.Text = String.Format("50minutos em fonte {0}", SliderTamanho.Value);
        }
    }
}
