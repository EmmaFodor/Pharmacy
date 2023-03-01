using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacie
{
    
    public partial class Form10 : Form
    {
        public Form1 f1;
        public Form10()
        {
            InitializeComponent();
        }

        private void înapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.f10 = this;
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
