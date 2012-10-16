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

namespace _310_KeyPresses
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Texto_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.Control)
                lista.Items.Add(String.Format("KeyDown: {0}", e.Key));
        }

        private void Texto_TextChanged(object sender, TextChangedEventArgs e)
        {
            lista.Items.Add("TextChanged");
        }

        private void Texto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Ctrl)
                lista.Items.Add(String.Format("KeyUp: {0}", e.Key));
        }
    }
}
