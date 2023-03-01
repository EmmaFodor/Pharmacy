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
    public partial class Form5 : Form
    {
        public Form4 f4;
        public Form3 f3;
        public Form8 f8;
        public Form6 f6;
        public int st,ok,ok2,ok3=3;
        public string amb,ft,act,doc2,str_med,cnpm,retm,cnpp,nume;

        //conexiune
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\fodor\OneDrive\Desktop\An 3 sem 1\Testare\Atestat\Farmacie\Pharmacy.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rd;
        public Form5(string str_med1,string cnpm1,string retm1,string doc,int ok1,int ok3,string cnpac)     ///transmiterea valorii din formul anterior
        {
            InitializeComponent();
            cod_medicamentTextBox.Text = str_med1;
            nume = doc;
            textBox1.Text = nume;
            cnpp = cnpac;
            textBox2.Text = cnpp;
            str_med = str_med1;
            cnpm = cnpm1;
            retm = retm1;
            textBox3.Text = retm;
            ok = ok1;
            ok2 = ok3;

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.f5 = this;
            f4.Show();
            this.Hide();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicamentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicament' table. You can move, or remove it, as needed.
            //this.medicamentTableAdapter.Fill(this.pharmacyDataSet.Medicament);

        }

        private void cod_medicamentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void denumire_comercialaTextBox_TextChanged(object sender, EventArgs e)
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText ="select * from medicament where cod_medicament=" + cod_medicamentTextBox.Text +"";
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                denumire_comercialaTextBox.Text = rd[2].ToString();
                stocTextBox.Text = rd[5].ToString();
                dulapTextBox.Text = rd[6].ToString();
                raftTextBox.Text = rd[7].ToString();
                amb = rd[0].ToString();
                act = rd[1].ToString();
                ft = rd[4].ToString();
                st = int.Parse(rd[5].ToString());
               
            }
            if (st == 0)    //intoarcerea la pagina principala cand stocul este 0
            {
                DialogResult dialogResult1 = MessageBox.Show("Reveniti la pagina principala!", "Medicamentul nu mai este pe stoc!", MessageBoxButtons.OK);
                if (dialogResult1 == DialogResult.OK)
                {
                    Form3 f3 = new Form3(ok, ok2);
                    f3.f5 = this;
                    f3.Show();
                    this.Hide();
                }
            }
            con.Close();
        }

        private void detaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(amb,act,ft,ok3);
            f8.f5 = this;
            f8.Show();
            this.Hide();
            ///detalii medicament,pret,tara,actiune
        }

        private void finalizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmat!","Reteta", MessageBoxButtons.OK);
             if (dialogResult == DialogResult.OK)     //confirmarea retetei
            {

                con.Open();
                if (st > 0)
                {
                    st--;       //decrementarea stocului
                    stocTextBox.Text = Convert.ToString(st);
                    cmd.CommandText = "update medicament set stoc='" + stocTextBox.Text + 
                   "'where (cod_medicament="+cod_medicamentTextBox.Text+")";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    con.Close();

                    con.Open();
                    cmd.CommandText= "insert into Istoric (doctor,CNP,nume_reteta,cod_medicament) " +
                    "values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+cod_medicamentTextBox.Text+"')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    con.Close();
                    
                    Form3 f3 = new Form3(ok, ok2);
                    f3.f5 = this;
                    f3.Show();
                    this.Hide();
   
                }
                con.Close();
                
                //cmd.CommandText="insert into istoric (nume,prenume,cnp,reteta,medicament) values (" +"

            }

            //inserare in istoric
            
        }
    }
}
