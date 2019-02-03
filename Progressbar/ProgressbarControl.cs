using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progressbar
{
    public partial class ProgressbarControl : Form
    {
        public int MarqueeAnimationSpeed { get => progressBar1.MarqueeAnimationSpeed; set => progressBar1.MarqueeAnimationSpeed = value; }

        public ProgressbarControl()
        {
            InitializeComponent();
        }
    }
}
