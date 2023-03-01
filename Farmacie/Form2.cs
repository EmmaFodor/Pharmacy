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
    public partial class Form2 : Form
    {
        public Form1 f1;
        public Form2 f2;
        public int ok = 1, ok2 = 1;
        public Form3 f3;
        public string nume;
        ///----conexiune 
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        ///-----sfarsit conexiune
        public Form2()
        {
            InitializeComponent();                    ///butoanele de logare nu sunt vizibile
            nume_utilizatorTextBox.Visible = false;
            parolaTextBox.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            parolaTextBox.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Asistent' table. You can move, or remove it, as needed.
            //this.asistentTableAdapter.Fill(this.pharmacyDataSet.Asistent);
            cmd.Connection = con;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ok==2)
            {
               Form3 f3 = new Form3(ok,ok2);
               f3.f2 = this;
               f3.Show();
               this.Hide();
            }
            else
                if(ok2==2)
               {
                   Form3 f3 = new Form3(ok,ok2); 
                   f3.f2 = this;
                   f3.Show();
                   this.Hide();
               }
            con.Open();
            cmd.CommandText = "insert into Asistent (nume_utilizator, Parola) values ('" + nume_utilizatorTextBox.Text + "', '" + parolaTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
        }

        private void circularButton2_Click(object sender, EventArgs e) ///la alegerea optiunii se poate loga 
        {
            button1.Visible = true;
            button2.Visible = false;
            circularButton2.Visible = false;
            circularButton3.Visible = false;
            nume_utilizatorTextBox.Visible = true;
            parolaTextBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            ok = 2;
        }

        private void circularButton3_Click(object sender, EventArgs e)     ///la alegerea optiunii se poate loga
        {
            button1.Visible = true;
            button2.Visible = true;
            circularButton2.Visible = false;
            circularButton3.Visible = false;
            nume_utilizatorTextBox.Visible = true;
            parolaTextBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            ok2 = 2;
           
        }

        private void nume_utilizatorTextBox_TextChanged(object sender, EventArgs e)
        {
            nume = nume_utilizatorTextBox.Text;
        }

        private void parolaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nume_utilizatorLabel_Click(object sender, EventArgs e)
        {

        }

        private void parolaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            circularButton2.Visible = true;
            circularButton3.Visible = true;
            nume_utilizatorTextBox.Visible = false;
            parolaTextBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            ok2 = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
