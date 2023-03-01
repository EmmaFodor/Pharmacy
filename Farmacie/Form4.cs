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
    public partial class Form4 : Form
    {
        public Form3 f3;
        public Form5 f5;
        public string val,mcnp,ret,doc,cnpac,nume;
        public string med;
        public string data;
        public int ok, ok2;

       

        //conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form4(string Str_value,string mycnp,int ok4,int ok3,string cnpp,string numedoc)    ///trasmiterea valorii din formul anterior
        {
            InitializeComponent();
            retetaTextBox.Text = Str_value;
            ret = Str_value;
            ok = ok4;
            ok2 = ok3;
            cnpac = cnpp;
            nume = numedoc;
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            textBox1.Hide();
            // TODO: This line of code loads data into the 'pharmacyDataSet.Reteta' table. You can move, or remove it, as needed.
            //this.retetaTableAdapter.Fill(this.pharmacyDataSet.Reteta);

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.f4 = this;
            f3.Show();
            this.Hide();
            medicamentToolStripMenuItem.Enabled = true;

        }

        private void medicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(med,mcnp,ret,doc,ok,ok2,cnpac);
            f5.f4 = this;
            f5.Show();
            this.Hide();
        }

        private void retetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.retetaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        public void retetaTextBox_TextChanged(object sender, EventArgs e)
        {
            //rd = cmd.ExecuteReader();
            //retetaTextBox.Text = Form3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from reteta where cod_reteta='" + retetaTextBox.Text + "'";
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                cod_medicamentTextBox.Text = rd[2].ToString();
                id_doctorTextBox.Text = rd[3].ToString();
                data_emisaDateTimePicker.Text = rd[4].ToString();
                data_expDateTimePicker.Text = rd[5].ToString();
                med = rd[2].ToString();
                data = rd[5].ToString();
                doc = id_doctorTextBox.Text;
            }
            con.Close();
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = Convert.ToDateTime(data);
            if(dt2<dt1)                                        ///verificarea valabilitatii retetei
            {
                MessageBox.Show("Reteta a expirat!");
                medicamentToolStripMenuItem.Enabled = false;
            }
            

        }

        private void cod_medicamentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_emisaLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_doctorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cnpac = textBox1.Text;
        }

        private void cod_retetaLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_emisaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void data_expDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
