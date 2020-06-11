using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

namespace Biblioteka
{
    public partial class Pregledi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds_xml = new DataSet();
            ds_xml.ReadXml(@"C:\Users\Asus\Desktop\VebProgramiranje\A25\Biblioteka\Biblioteka\App_Data\biblioteka.xml");

            for (int i = 0; i < ds_xml.Tables[0].Rows.Count; ++i) 
            {
                int max = Convert.ToInt32(ds_xml.Tables[0].Rows[i].ItemArray[3]);
                for(int j = i+1; j<ds_xml.Tables[0].Rows.Count; ++j)
                {
                    if (max < Convert.ToInt32(ds_xml.Tables[0].Rows[j].ItemArray[3])) 
                    {
                        max = Convert.ToInt32(ds_xml.Tables[0].Rows[j].ItemArray[3]);
                        DataRow row = ds_xml.Tables[0].NewRow();
                        DataRow row1 = ds_xml.Tables[0].NewRow();
                        for (int k = 0; k < 4; ++k)
                        {
                            row[k] = ds_xml.Tables[0].Rows[i].ItemArray[k];
                            row1[k] = ds_xml.Tables[0].Rows[j].ItemArray[k];
                        }

                        ds_xml.Tables[0].Rows.Remove(ds_xml.Tables[0].Rows[i]);
                        ds_xml.Tables[0].Rows.InsertAt(row1, i);
                        ds_xml.Tables[0].Rows.Remove(ds_xml.Tables[0].Rows[j]);
                        ds_xml.Tables[0].Rows.InsertAt(row, j);
                    }
                }    
            }

            GridView1.DataSource = ds_xml.Tables[0];
            GridView1.DataBind();
        }
    }
}