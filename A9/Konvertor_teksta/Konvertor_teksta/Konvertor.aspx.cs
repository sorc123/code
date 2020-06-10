using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Konvertor_teksta.localhost;

namespace Konvertor_teksta
{
    public partial class Konvertor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUCirilicu_Click(object sender, EventArgs e)
        {
            Service1 servis = new Service1();

            TextBoxCirilica.Text = servis.LatinicaUCirilicu(TextBoxLatinica.Text);
        }

        protected void ButtonULatinicu_Click(object sender, EventArgs e)
        {
            Service1 servis = new Service1();

            TextBoxLatinica.Text = servis.CirilicaULatinicu(TextBoxCirilica.Text);
        }
    }
}