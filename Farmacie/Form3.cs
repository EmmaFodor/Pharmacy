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
    public partial class Form3 : Form
    {
        public Form1 f1;
        public Form2 f2;
        public Form4 f4;
        public Form5 f5;
        public Form6 f6;
        public Form7 f7;
        public string myVal,mycnp,st2="0",cnpp,cnp,ret,med,doc,numedoc;
        public int ok1, ok3,st,x,y;
        //public string firstname;
        //public string lastname, cnp1;
        
        //-------conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ""C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb""");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        //-------sfarsit conexiune

        public Form3(int ok,int ok2)
        {
            ok1 = ok;
            ok3 = ok2;
            InitializeComponent();            
            if (ok == 2)           //asistentul nu poate modifica stocul medicamentelor
                stocToolStripMenuItem.Visible = true;
            else
            {
                if (ok2 == 2)     //directorul poate modifica stocul medicamentelor
                    stocToolStripMenuItem.Visible = false;
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            textBox1.Hide();
            textBox2.Hide();
            // TODO: This line of code loads data into the 'pharmacyDataSet.Pacient' table. You can move, or remove it, as needed.
           // this.pacientTableAdapter.Fill(this.pharmacyDataSet.Pacient);

        }

        private void inapoiLaPaginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.f3 = this;
            f1.Show();
            this.Hide();
        }

        private void pacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form4 f4 = new Form4(myVal,mycnp,ok1,ok3,cnpp,numedoc);
                f4.f3 = this;
                f4.Show();
                this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        //-----afisare date din tabela
        
        public void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText="select * from pacient where cnp='" + cnpTextBox.Text+"'";
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                numeTextBox.Text = rd[1].ToString();
                prenumeTextBox.Text = rd[2].ToString();
                telefonTextBox.Text = rd[3].ToString();
                orasTextBox.Text = rd[4].ToString();
                cod_retetaTextBox.Text = rd[6].ToString();
                //firstname = rd[2].ToString();
                //lastname = rd[1].ToString();
                //cnp1 = cnpTextBox.Text;
                mycnp = cnpTextBox.Text;
                myVal = rd[6].ToString();
                cnpp = cnpTextBox.Text;
                if (myVal == "null")                    ///verifica daca individul are reteta
                {
                    MessageBox.Show("Nu aveți rețetă!");
                    pacientToolStripMenuItem.Enabled = false;
                }
                else
                    pacientToolStripMenuItem.Enabled = true;
                
            }
            con.Close();
        }

        private void cnpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnpLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void telefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void orasLabel_Click(object sender, EventArgs e)
        {

        }

        private void orasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(ok1,ok3);
            f6.f3 = this;
            f6.Show();
            this.Hide();
        }

        public void cod_retetaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnpTextBox.Clear();
            numeTextBox.Clear();
            prenumeTextBox.Clear();
            telefonTextBox.Clear();
            orasTextBox.Clear();
            cod_retetaTextBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
        }

        private void faraRetetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(mycnp, myVal);
            f7.f3 = this;
            f7.Show();
            this.Hide();
        }

        private void stocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "update Medicament set Stoc='"+textBox1.Text+"' where (Stoc='"+textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();

        }

        private void cod_retetaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
