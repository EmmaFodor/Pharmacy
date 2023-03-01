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
    public partial class Form8 : Form
    {
        public Form5 f5;
        public Form7 f7;
        public int sem;
        
        

        //conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form8(string Value1,string Value2,string Value3,int ok)
        {
            //incerc daca transmit doar codul si dupa caut dupa cod in baza de date si imi afiseaza cu rd
            InitializeComponent();
            textBox1.Text = Value2;
            textBox2.Text = Value1;
            textBox3.Text = Value3;
            sem = ok;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicament' table. You can move, or remove it, as needed.
            //this.medicamentTableAdapter.Fill(this.pharmacyDataSet.Medicament);

        }

        private void medicamentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sem != 1)
            {

                f5.f8 = this;
                f5.Show();
                this.Hide();
            }
            else
            {
                f7.f8 = this;
                f7.Show();
                this.Hide();
            }
        }

        private void actiune_terapeuticaLabel_Click(object sender, EventArgs e)
        {

        }

        private void ambalajLabel_Click(object sender, EventArgs e)
        {

        }

        private void firma_tara_producatoareLabel_Click(object sender, EventArgs e)
        {

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

        private void actiune_terapeuticaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
