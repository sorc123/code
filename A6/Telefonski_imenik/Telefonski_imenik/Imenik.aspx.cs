using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Telefonski_imenik
{
    public partial class Imenik : System.Web.UI.Page
    {
        DataTable dt;
        DataTable dt2;
        string[] sep = { " | " };

        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A6\Telefonski_imenik\Telefonski_imenik\App_Data\imenik.txt"); // <--Ovde promeniti putanju ka tekstualnoj datoteci
            string[] text;
            string citaj;

            dt = new DataTable();
            dt.Columns.Add("Sifra korisnika");
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Adresa");
            dt.Columns.Add("Mesto");
            dt.Columns.Add("Broj telefona");
            dt.Columns.Add("E-mail");

            while ((citaj = rd.ReadLine()) != null) 
            {
                DataRow row = dt.NewRow();
                text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < text.Length; ++i) 
                {
                    row[i] = text[i];
                    if(!DropDownListMesto.Items.Contains(new ListItem(text[4])))
                        DropDownListMesto.Items.Add(text[4]);
                }
                dt.Rows.Add(row);
            }
        }

        protected void ButtonTrazi_Click(object sender, EventArgs e)
        {
            if (TextBoxIme.Text == "" &&
               TextBoxPrezime.Text == "" &&
               TextBoxAdresa.Text == "" &&
               DropDownListMesto.SelectedItem.Text == "" &&
               TextBoxBrojTelefona.Text == "")
            {
                LabelGreska.Text = "Unesite parametre za pretragu";
            }
            else 
            {
                LabelGreska.Text = "";

                dt2 = new DataTable();
                dt2.Columns.Add("Sifra korisnika");
                dt2.Columns.Add("Ime");
                dt2.Columns.Add("Prezime");
                dt2.Columns.Add("Adresa");
                dt2.Columns.Add("Mesto");
                dt2.Columns.Add("Broj telefona");
                dt2.Columns.Add("E-mail");

                for (int i = 0; i < dt.Rows.Count; ++i) 
                {
                    if ((dt.Rows[i].ItemArray[1].ToString().StartsWith(TextBoxIme.Text) || TextBoxIme.Text == "") &&
                        (dt.Rows[i].ItemArray[2].ToString().StartsWith(TextBoxPrezime.Text) || TextBoxPrezime.Text == "") &&
                        (dt.Rows[i].ItemArray[3].ToString().StartsWith(TextBoxAdresa.Text) || TextBoxAdresa.Text == "") &&
                        (dt.Rows[i].ItemArray[4].ToString().StartsWith(DropDownListMesto.Text) || DropDownListMesto.Text == "") &&
                        (dt.Rows[i].ItemArray[5].ToString().StartsWith(TextBoxBrojTelefona.Text) || TextBoxBrojTelefona.Text == ""))
                    {
                        DataRow row = dt2.NewRow();
                        for(int j = 0; j<dt.Columns.Count; ++j)
                        {
                            row[j] = dt.Rows[i].ItemArray[j];
                        }
                        dt2.Rows.Add(row);
                    }
                }

                GridView1.DataSource = dt2;
                GridView1.DataBind();
            }
        }
    }
}