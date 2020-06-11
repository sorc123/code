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
    public partial class Form3 : Form
    {
        public void ucitajCB1()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("Select Tip from Tip_Sobe order by Tip asc", con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void ucitajCB2()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("Select distinct Drzava from Turisticka_destinacija order by Drzava asc", con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public void ucitajDVG()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Teodor-PC\SQLEXPRESS;Initial Catalog=B7_8;Integrated Security=True");
                con.Open();
                SqlDataAdapter com = new SqlDataAdapter("select Hotel.Naziv,count(Turisticki_Aranzman.HotelID)/2 as BrojAranzmana from Hotel join Turisticki_Aranzman on Turisticki_Aranzman.HotelID = Hotel.HotelID join Rezervacija_Hotela on Rezervacija_Hotela.HotelID = Hotel.HotelID join Soba on Soba.SobaID = Rezervacija_Hotela.SobaID join Tip_sobe on Tip_sobe.TipSobeID = Soba.TipSobeID join Turisticka_destinacija on Turisticka_destinacija.DestinacijaID = Turisticki_Aranzman.DestinacijaID where Tip_sobe.Tip = @p1 and Turisticka_destinacija.Drzava = @p2 and Turisticki_Aranzman.DatumPolaska = @p3 and Turisticki_Aranzman.DatumPovratka = @p4 group by Hotel.Naziv order by Hotel.Naziv asc", con);
                com.SelectCommand.Parameters.AddWithValue("@p1", comboBox1.Text);
                com.SelectCommand.Parameters.AddWithValue("@p2", comboBox2.Text);
                com.SelectCommand.Parameters.AddWithValue("@p3", monthCalendar1.SelectionRange.Start.ToShortDateString());
                com.SelectCommand.Parameters.AddWithValue("@p4", monthCalendar2.SelectionRange.Start.ToShortDateString());
                DataTable dt = new DataTable();
                com.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Greska");
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucitajDVG();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ucitajCB1();
            ucitajCB2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
