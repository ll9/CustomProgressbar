using Progressbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var pro = new ProgressbarControl { Text = "Lese Excel..." };
            pro.Show();
            await Task.Run((() => Thread.Sleep(50000)));
            pro.Close();
            button1.Enabled = true;
        }
    }
}
