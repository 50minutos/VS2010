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

namespace _308_MouseWheel
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.Focus();
        }
        
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);

            txbMouseWheelValue.Text = string.Format("Mouse Wheel Value: {0}", e.Delta);

            if (e.Delta > 0)
            {
                scaleBrdWheeler.ScaleX += 0.1;
                scaleBrdWheeler.ScaleY += 0.1;
                //rotateBrdWheeler.Angle += 10;
            }
            else
            {
                scaleBrdWheeler.ScaleX -= 0.1;
                scaleBrdWheeler.ScaleY -= 0.1;
                //rotateBrdWheeler.Angle -= 10;
            }
        }
    }
}
