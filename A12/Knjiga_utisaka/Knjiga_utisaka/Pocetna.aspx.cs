using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Knjiga_utisaka
{
    public partial class index : System.Web.UI.Page
    {
        int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=KSENIJA;Initial Catalog=KnjigaUtisaka;Integrated Security=True")) //<--ovde se menja konekcija
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM Utisak", con))
                {
                    con.Open();

                    if (cmd.ExecuteScalar() != DBNull.Value)
                        id = Convert.ToInt32(cmd.ExecuteScalar());

                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Utisak VALUES(@id, @ime, @email, @kom, @dat)", con))
                {
                    cmd.Parameters.AddWithValue("@id", ++id);
                    cmd.Parameters.AddWithValue("@ime", TextBoxIme.Text);
                    cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@kom", TextBoxKomentar.Text);
                    cmd.Parameters.AddWithValue("@dat", DateTime.Now);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    TextBoxIme.Text = String.Empty;
                    TextBoxEmail.Text = String.Empty;
                    TextBoxKomentar.Text = String.Empty;


                }
            }

        }
    }
}