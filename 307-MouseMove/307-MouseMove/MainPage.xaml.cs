﻿using System;
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

namespace _307_MouseMove
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_MouseMove(object sender, MouseEventArgs e)
        {
            Posicao.Text = String.Format("   posição do cursor do mouse: ({0},{1})",
    e.GetPosition(this).X, e.GetPosition(this).Y);
        }
    }
}