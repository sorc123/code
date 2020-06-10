using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kursna_lista.localhost;

namespace Kursna_lista
{
    public partial class Azuriranje_kursa : System.Web.UI.Page
    {
        Service1 servis = new Service1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string s in servis.ProcitajSveValute())
                {
                    DropDownListValuta.Items.Add(s);
                }
            } 
        }

        protected void ButtonUpisi_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.ToShortDateString() != "01-Jan-01" && TextBoxKurs.Text != "") 
            {
                servis.UpisiKursNaDan(Calendar1.SelectedDate, DropDownListValuta.SelectedItem.Text, Convert.ToDouble(TextBoxKurs.Text));
            }
        }
    }
}