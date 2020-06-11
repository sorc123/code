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
    public partial class Recnik : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=KSENIJA;Initial Catalog=Elektronski_Recnik;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPrevedi_Click(object sender, EventArgs e)
        {
            try
            {
                LabelGreska.Text = "";
                TextBoxPrevod.Text = "";
                TextBoxOpis.Text = "";

                SqlCommand cmd = new SqlCommand(@"SELECT Srpski, Engleski, Opis FROM Recnik", con);
                SqlDataReader rd;

                if (TextBoxRec.Text != "")
                {
                    switch (DropDownListSmer.SelectedIndex)
                    {
                        case 1:
                            con.Open();

                            rd = cmd.ExecuteReader();
                            while (rd.Read())
                            {
                                if (rd[0].ToString() == TextBoxRec.Text.ToLower()) 
                                {
                                    TextBoxPrevod.Text = rd[1].ToString();
                                    TextBoxOpis.Text = rd[2].ToString();
                                }        
                            }

                            rd.Close();
                            con.Close();
                            break;
                        case 2:
                            con.Open();

                            rd = cmd.ExecuteReader();
                            while (rd.Read())
                            {
                                if (rd[1].ToString() == TextBoxRec.Text.ToLower())
                                {
                                    TextBoxPrevod.Text = rd[0].ToString();
                                    TextBoxOpis.Text = rd[2].ToString();
                                }        
                            }

                            rd.Close();
                            con.Close();
                            break;
                    }
                }
                else
                    throw new NoNullAllowedException();
            }
            catch (NoNullAllowedException) 
            {
                LabelGreska.Text = "Unesite rec za prevodjenje!";
            }
            
        }
    }
}