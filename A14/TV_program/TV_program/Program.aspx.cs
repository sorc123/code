using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace TV_program
{
    public partial class Program : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonTrazi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Vreme");
            dt.Columns.Add("Emisija");
            dt.Columns.Add("Slika");

            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A14\TV_program\TV_program\App_Data\" + DropDownListDatum.Text + ".txt");
            string citaj;
            string[] text;
            string[] sep = { " | " };
            citaj = sr.ReadLine();

            while (citaj != null) 
            {
                text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                if (text[2] == DropDownListTip.Text) 
                {
                    DataRow row = dt.NewRow();
                    row["Vreme"] = text[0];
                    row["Emisija"] = text[1];
                    row["Slika"] = text[3];
                    dt.Rows.Add(row);
                }

                citaj = sr.ReadLine();
            }

            sr.Close();

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}