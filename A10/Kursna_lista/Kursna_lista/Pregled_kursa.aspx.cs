using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kursna_lista.localhost;

namespace Kursna_lista
{
    public partial class Pregled_kursa : System.Web.UI.Page
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

        protected void ButtonPrikazi_Click(object sender, EventArgs e)
        {
            LabelKurs.Text = "";
            if (Calendar1.SelectedDate.ToShortDateString() != "01-Jan-01") 
            {
                double kurs = servis.ProcitajKursNaDan(Calendar1.SelectedDate, DropDownListValuta.SelectedItem.Text);
                if (kurs != 0)
                    LabelKurs.Text = "Kurs na dan " + Calendar1.SelectedDate.ToShortDateString() + " za valutu " + DropDownListValuta.SelectedItem.Text + " je " + kurs;
                else
                    LabelKurs.Text = "Trazeni podatak ne postoji.";
            }
        }
    }
}