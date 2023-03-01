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
    //istoric
    public partial class Form6 : Form
    {
        //------conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        // OleDbCommand cmd = new OleDbCommand();

        OleDbDataReader rd;
        //------sfarsit conexiune

        public Form3 f3;
        public Form5 f5;
        public int ok1,ok3;

        public Form6(int ok,int ok2)
        {
            ok1 = ok;
            ok3 = ok2;
            InitializeComponent();
            //parametrii string mymed, string mycnp, string mydoc,string myret
            //dataGridView1.Rows.Add();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Valabilitate' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'pharmacyDataSet.Reteta' table. You can move, or remove it, as needed.
           // this.retetaTableAdapter.Fill(this.pharmacyDataSet.Reteta);
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(ok1, ok3);
            f3.f6 = this;
            f3.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Istoric";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
