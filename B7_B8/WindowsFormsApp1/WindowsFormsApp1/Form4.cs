using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public void prvi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select top 1 KlijentID,Ime,Prezime,Grad,BrojTelefona from Klijent", con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void poslednji()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select top 1 KlijentID,Ime,Prezime,Grad,BrojTelefona from Klijent order by KlijentID desc", con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void prethodni()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                int sifra = Convert.ToInt32(textBox1.Text)-1;
                SqlCommand com = new SqlCommand("select KlijentID,Ime,Prezime,Grad,BrojTelefona from Klijent where KlijentID=@p1", con);
                com.Parameters.AddWithValue("@p1", sifra);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void sledeci()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                int sifra = Convert.ToInt32(textBox1.Text) + 1;
                SqlCommand com = new SqlCommand("select KlijentID,Ime,Prezime,Grad,BrojTelefona from Klijent where KlijentID=@p1", con);
                com.Parameters.AddWithValue("@p1", sifra);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void novi()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
            int X = textBox1.Left + textBox1.Width / 2;
            int Y = textBox1.Top + textBox1.Height;
            Cursor.Position = new Point(X,Y);
        }
        public void upisi()
        {
            try
            {
                if (textBox1.Text != "")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                    con.Open();
                    SqlCommand com = new SqlCommand("insert into Klijent (KlijentID,Ime,Prezime,Grad,BrojTelefona,Adresa) values(@p1,@p2,@p3,@p4,@p5,'Adresa1')", con);
                    com.Parameters.AddWithValue("@p1", textBox1.Text);
                    com.Parameters.AddWithValue("@p2", textBox2.Text);
                    com.Parameters.AddWithValue("@p3", textBox3.Text);
                    com.Parameters.AddWithValue("@p4", textBox4.Text);
                    com.Parameters.AddWithValue("@p5", textBox5.Text);
                    com.ExecuteReader();
                    MessageBox.Show("Uspesan upis");
                    con.Close();
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Unesi sifru");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void resetuj()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        public void ucitaj()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select Top 1 KlijentID,Ime,Prezime,Grad,BrojTelefona from Klijent", con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                prvi();
            }
            if (textBox1.Text != "")
            {
                prethodni();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                poslednji();
            }
            if (textBox1.Text != "")
            {
                sledeci();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            upisi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            resetuj();
        }
    }
}
