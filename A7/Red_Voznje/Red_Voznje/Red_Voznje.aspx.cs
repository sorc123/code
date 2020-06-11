using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Red_Voznje
{
    public partial class Red_Voznje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownListLinija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DropDownListSmer.Items.Clear();
                if (DropDownListLinija.SelectedIndex != 0)
                {
                    string linija = DropDownListLinija.Text;
                    StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A7\Red_Voznje\Red_Voznje\App_Data\" + linija + ".txt");
                    string citaj;

                    while ((citaj = sr.ReadLine()) != null)
                    {
                        if (citaj.Substring(0, 5) == "SMER:")
                        {
                            DropDownListSmer.Items.Add(citaj.Substring(5, citaj.Length - 5));
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                
            }
        }

        protected void ButtonTrazi_Click(object sender, EventArgs e)
        {
            try 
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Redni broj polaska");
                dt.Columns.Add("Vreme polaska");

                string linija = DropDownListLinija.SelectedValue.ToString();
                StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A7\Red_Voznje\Red_Voznje\App_Data\" + linija + ".txt");
                string citaj;

                while ((citaj = sr.ReadLine()) != null)
                {
                    if (citaj.Substring(5, citaj.Length-5) == DropDownListSmer.SelectedValue.ToString()) 
                    {
                        int rbr = 1;
                        while ((citaj = sr.ReadLine()) != null && citaj.Substring(0, 1) != "S") 
                        {
                            DataRow row = dt.NewRow();
                            row["Redni broj polaska"] = rbr++;
                            row["Vreme polaska"] = citaj;
                            dt.Rows.Add(row);
                        }
                        break;
                    }
                }

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
    }
}