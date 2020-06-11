using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Veb_prodavnica
{
    public partial class Veb_prodavnica : System.Web.UI.Page
    {
        DataTable dt;
        DataTable dt2;

        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A8\Veb_prodavnica\Veb_prodavnica\App_Data\vebprodavnica.txt"); //<--putanja ka datoteci se menja ovde
            string citaj;

            dt = new DataTable();
            dt.Columns.Add("Slika");
            dt.Columns.Add("Sifra");
            dt.Columns.Add("Naziv");
            dt.Columns.Add("Proizvodjac");
            dt.Columns.Add("RAM");
            dt.Columns.Add("Tip");
            dt.Columns.Add("Kamera");
            dt.Columns.Add("Ekran");
            dt.Columns.Add("Cena");

            while ((citaj = rd.ReadLine()) != null) 
            {
                DataRow row = dt.NewRow();
                row["Slika"] = citaj.Substring(91, 29).TrimEnd();
                row["Sifra"] = citaj.Substring(0, 5).TrimEnd();
                row["Naziv"] = citaj.Substring(6, 24).TrimEnd();
                row["Proizvodjac"] = citaj.Substring(31, 19).TrimEnd();
                row["RAM"] = citaj.Substring(51, 5).TrimEnd();
                row["Tip"] = citaj.Substring(56, 14).TrimEnd();
                row["Kamera"] = citaj.Substring(71, 9).TrimEnd();
                row["Ekran"] = citaj.Substring(81, 9).TrimEnd();
                row["Cena"] = citaj.Substring(121).TrimEnd();

                dt.Rows.Add(row);

                if (!DropDownListProizvodjac.Items.Contains(new ListItem(citaj.Substring(31, 19).TrimEnd())))
                    DropDownListProizvodjac.Items.Add(citaj.Substring(31, 19).TrimEnd());
                if (!DropDownListProcesor.Items.Contains(new ListItem(citaj.Substring(56, 14).TrimEnd())))
                    DropDownListProcesor.Items.Add(citaj.Substring(56, 14).TrimEnd());
                if (!DropDownListKamera.Items.Contains(new ListItem(citaj.Substring(71, 9).TrimEnd())))
                    DropDownListKamera.Items.Add(citaj.Substring(71, 9).TrimEnd());
                if (!DropDownListEkran.Items.Contains(new ListItem(citaj.Substring(81, 9).TrimEnd())))
                    DropDownListEkran.Items.Add(citaj.Substring(81, 9).TrimEnd());
            }

            rd.Close();  
        }

        protected void ButtonTrazi_Click(object sender, EventArgs e)
        {
            if (!(DropDownListProizvodjac.Text == "" &&
               DropDownListRAM.Text == "" &&
               DropDownListProcesor.Text == "" &&
               DropDownListKamera.Text == "" &&
               DropDownListEkran.Text == ""))
            {
                dt2 = new DataTable();
                dt2.Columns.Add("Slika");
                dt2.Columns.Add("Sifra");
                dt2.Columns.Add("Naziv");
                dt2.Columns.Add("Proizvodjac");
                dt2.Columns.Add("RAM");
                dt2.Columns.Add("Tip");
                dt2.Columns.Add("Kamera");
                dt2.Columns.Add("Ekran");
                dt2.Columns.Add("Cena");

                for (int i = 0; i < dt.Rows.Count; ++i)
                {

                    if ((DropDownListProizvodjac.Text == dt.Rows[i].ItemArray[3].ToString() || DropDownListProizvodjac.Text == "") &&
                   (DropDownListRAM.Text == dt.Rows[i].ItemArray[4].ToString() || DropDownListRAM.Text == "") &&
                   (DropDownListProcesor.Text == dt.Rows[i].ItemArray[5].ToString() || DropDownListProcesor.Text == "") &&
                   (DropDownListKamera.Text == dt.Rows[i].ItemArray[6].ToString() || DropDownListKamera.Text == "") &&
                   (DropDownListEkran.Text == dt.Rows[i].ItemArray[7].ToString() || DropDownListEkran.Text == ""))
                    {
                        DataRow row = dt2.NewRow();
                        row["Slika"] = dt.Rows[i].ItemArray[0].ToString();
                        row["Sifra"] = dt.Rows[i].ItemArray[1].ToString();
                        row["Naziv"] = dt.Rows[i].ItemArray[2].ToString();
                        row["Proizvodjac"] = dt.Rows[i].ItemArray[3].ToString();
                        row["RAM"] = dt.Rows[i].ItemArray[4].ToString();
                        row["Tip"] = dt.Rows[i].ItemArray[5].ToString();
                        row["Kamera"] = dt.Rows[i].ItemArray[6].ToString();
                        row["Ekran"] = dt.Rows[i].ItemArray[7].ToString();
                        row["Cena"] = dt.Rows[i].ItemArray[8].ToString();
                        dt2.Rows.Add(row);
                    }
                }

                GridView1.DataSource = dt2;
                GridView1.DataBind();

            }
            else 
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }
    }
}