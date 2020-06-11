using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Elektronski_recnik
{
    public partial class Dodavanje : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=KSENIJA;Initial Catalog=Elektronski_Recnik;Integrated Security=True");
        int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT MAX(ID) FROM Recnik", con);

            con.Open();

            id = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
        }

        protected void ButtonSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                LabelGreska.Text = "";

                SqlCommand cmd = new SqlCommand(@"INSERT INTO Recnik VALUES(@id, @eng, @srp, @opis)", con);

                if (TextBoxEngleski.Text == "" ||
                   TextBoxSrpski.Text == "")
                    throw new NoNullAllowedException();
                else 
                {
                    cmd.Parameters.AddWithValue("@id", ++id);
                    cmd.Parameters.AddWithValue("@eng", TextBoxEngleski.Text.ToLower());
                    cmd.Parameters.AddWithValue("@srp", TextBoxSrpski.Text.ToLower());
                    cmd.Parameters.AddWithValue("@opis", TextBoxOpis.Text);

                    con.Open();

                    if (cmd.ExecuteNonQuery() != 0)
                        LabelGreska.Text = "Podaci uspesno upisani.";

                    con.Close();

                    TextBoxSrpski.Text = "";
                    TextBoxEngleski.Text = "";
                    TextBoxOpis.Text = "";
                }

            }
            catch (NoNullAllowedException) 
            {
                LabelGreska.Text = "Unesite vrednosti u sva polja!";
            }
        }
    }
}