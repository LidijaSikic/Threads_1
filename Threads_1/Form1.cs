using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread Nit = new Thread(printaj);
                Nit.Name = "Nit" + i;
                Nit.Start();
                Thread.Sleep(1000);
            }
        }

        private void printaj()
        {
            for (int i = 1; i <= 10; i++)
            {
                Debug.WriteLine($"{Thread.CurrentThread.Name}: prolaz {i}");
                //Thread.Sleep(1000);
            }
        }
    }
}
