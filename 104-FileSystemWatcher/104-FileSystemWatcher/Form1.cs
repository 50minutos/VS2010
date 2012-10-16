using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace _104_FileSystemWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Thread.Sleep(18000);

            String destino = String.Format(@"C:\Users\Usuario\Desktop\BKP\{0}", e.Name);
            
            File.Copy(e.FullPath, destino); 
        }
    }
}
