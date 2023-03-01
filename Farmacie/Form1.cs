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
    public partial class Form1 : Form
    {
        public Form2 f2 = new Form2();
        public Form3 f3;
        
        public Form10 f10 = new Form10();
        public Form1()
        {
            InitializeComponent();
        }

        private void intrareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f2.f1 = this;
            f2.Show();
            this.Hide();
        }

        private void iesireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10.f1 = this;
            f10.Show();
            this.Hide();
        }

        private void intrareToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            f2.f1 = this;
            f2.Show();
            this.Hide();
        }
    }
}
