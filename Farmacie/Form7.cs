using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Farmacie
{
    // fara reteta
    public partial class Form7 : Form
    {
        public Form3 f3;
        public Form8 f8;
        public string reteta, cnpp,amb,ft,act;
        public int ok = 1;

        //-----conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        //-----sfarsit conexiune
        public Form7(string cnp,string ret)
        {
            InitializeComponent();
            textBox1.Text = cnp;
            textBox2.Text = ret;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicament' table. You can move, or remove it, as needed.
            //this.medicamentTableAdapter.Fill(this.pharmacyDataSet.Medicament);
            cmd.Connection = con;
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();

        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.f7 = this;
            f3.Show();
            this.Hide();
        }

        private void cod_medicamentLabel_Click(object sender, EventArgs e)
        {

        }

        private void cod_medicamentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dulapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void raftTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public string a;
        public int st;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            a = comboBox1.Text;
            cmd.CommandText = "select * from medicament where denumire_comerciala='" + a + "'";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cod_medicamentTextBox.Text = rd[3].ToString();
                stocTextBox.Text = rd[5].ToString();
                dulapTextBox.Text = rd[6].ToString();
                raftTextBox.Text = rd[7].ToString();
                st = int.Parse(rd[5].ToString());
                amb = rd[0].ToString();
                act = rd[1].ToString();
                ft = rd[4].ToString();
            }
            if (st == 0)    //intoarcerea la pagina principala cand stocul este 0
            {
                DialogResult dialogResult1 = MessageBox.Show("Medicamentul nu mai este pe stoc!","Reveniti la pagina principala!", MessageBoxButtons.OK);
                confirmareToolStripMenuItem.Enabled = false;
                /*if (dialogResult1 == DialogResult.OK)
                {
                    f3.f7 = this;
                    f3.Show();
                    this.Hide();
                }*/
            }
            else
            {
                confirmareToolStripMenuItem.Enabled = true;
            }
            con.Close();
        }

        private void confirmareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmat!", "Reteta", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)     //confirmarea retetei
            {

                con.Open();
                if (st > 0)
                {
                    st--;       //decrementarea stocului
                    stocTextBox.Text = Convert.ToString(st);
                    cmd.CommandText = "update medicament set stoc='" + stocTextBox.Text + "'where (cod_medicament=" + cod_medicamentTextBox.Text + ")";
                    if (textBox2.Text == "null")
                        textBox3.Text = "null";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    con.Close();

                    con.Open();
                    cmd.CommandText = "insert into Istoric (doctor,CNP,nume_reteta,cod_medicament) values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + cod_medicamentTextBox.Text  + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    con.Close();
                    f3.f7 = this;
                    f3.Show();
                    this.Hide();
                }
                con.Close();
            }
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void detaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(amb, act, ft,ok);
            f8.f7 = this;
            f8.Show();
            this.Hide();
        }
    }
}
