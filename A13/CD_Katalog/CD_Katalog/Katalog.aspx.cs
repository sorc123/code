using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace CD_Katalog
{
    public partial class Katalog : System.Web.UI.Page
    {
        string[] sep = { " | " };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                GL.dt = new DataTable();
                GL.dt.Columns.Add("Putanja");
                GL.dt.Columns.Add("Izvodjac");
                GL.dt.Columns.Add("Naziv");
                GL.dt.Columns.Add("Zanr");
                GL.dt.Columns.Add("Godina");
                GL.dt.Columns.Add("Izdavac");

                StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A13\CD_Katalog\CD_Katalog\App_Data\katalog.txt");
                string[] text;
                string citaj = sr.ReadLine();

                while (citaj != null && citaj != "") 
                {
                    text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    DataRow row = GL.dt.NewRow();
                    for (int i = 0; i < text.Count()-1; ++i) 
                    {
                        row[i+1] = text[i];
                    }

                    row["Putanja"] = text[5];

                    GL.dt.Rows.Add(row);
                    citaj = sr.ReadLine();
                }

                sr.Close();

                DropDownListGodina.Items.Add("");
                DropDownListZanr.Items.Add("");

                for (int i = 0; i < GL.dt.Rows.Count; ++i) 
                {
                    ListItem l = new ListItem(GL.dt.Rows[i].ItemArray[3].ToString());
                    if (!DropDownListZanr.Items.Contains(l)) 
                    {
                        DropDownListZanr.Items.Add(l);
                    }
                    l = new ListItem(GL.dt.Rows[i].ItemArray[4].ToString());
                    if (!DropDownListGodina.Items.Contains(l))
                    {
                        DropDownListGodina.Items.Add(l);
                    }
                }  
            }
        }

        protected void ButtonTrazi_Click(object sender, EventArgs e)
        {
            LabelGreska.Text = "";

            GL.dt2 = new DataTable();
            GL.dt2.Columns.Add("Putanja");
            GL.dt2.Columns.Add("Izvodjac");
            GL.dt2.Columns.Add("Naziv");
            GL.dt2.Columns.Add("Zanr");
            GL.dt2.Columns.Add("Godina");
            GL.dt2.Columns.Add("Izdavac");

            Pretraga p = new Pretraga
                (
                TextBoxIzvodjac.Text,
                TextBoxNaziv.Text,
                DropDownListZanr.SelectedItem.Text,
                DropDownListGodina.SelectedItem.Text,
                TextBoxIzdavac.Text
                );

            if (p.Naziv_albuma == "" && p.Izvodjac == "" && p.Izdavacka_kuca == "" && p.Godina_izdanja == "" && p.Zanr == "")
            {
                LabelGreska.Text = "Unesite parametre.";
            }
            else 
            {
                for (int i = 0; i < GL.dt.Rows.Count; ++i)
                {
                    if ((GL.dt.Rows[i].ItemArray[1].ToString().StartsWith(p.Izvodjac) || p.Izvodjac == "") &&
                        (GL.dt.Rows[i].ItemArray[2].ToString().StartsWith(p.Naziv_albuma) || p.Naziv_albuma == "") &&
                        (GL.dt.Rows[i].ItemArray[3].ToString() == p.Zanr || p.Zanr == "") &&
                        (GL.dt.Rows[i].ItemArray[4].ToString() == p.Godina_izdanja || p.Godina_izdanja == "") &&
                        (GL.dt.Rows[i].ItemArray[5].ToString().StartsWith(p.Izdavacka_kuca) || p.Izdavacka_kuca == ""))
                    {
                        DataRow row = GL.dt2.NewRow();
                        row[0] = GL.dt.Rows[i].ItemArray[0].ToString();
                        row[1] = GL.dt.Rows[i].ItemArray[1].ToString();
                        row[2] = GL.dt.Rows[i].ItemArray[2].ToString();
                        row[3] = GL.dt.Rows[i].ItemArray[3].ToString();
                        row[4] = GL.dt.Rows[i].ItemArray[4].ToString();
                        row[5] = GL.dt.Rows[i].ItemArray[5].ToString();

                        GL.dt2.Rows.Add(row);
                    }
                }

                GridView1.DataSource = GL.dt2;
                GridView1.DataBind();
            } 
        }
    }
}