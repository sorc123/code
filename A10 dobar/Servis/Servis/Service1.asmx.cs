using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Globalization;

namespace Servis
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double ProcitajKursNaDan(DateTime Datum, string valuta) 
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A10\Servis\Servis\App_Data\KursnaLista.txt");
            string citaj = sr.ReadLine();
            string[] sep = {" | "};
            string[] text;
            double kurs = 0;

            while (citaj != null) 
            {
                if (citaj == "") 
                {
                    citaj = sr.ReadLine();
                    continue;
                } 
                text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                if (DateTime.Parse(text[0]) == Datum && text[1] == valuta) 
                {
                    kurs = Convert.ToDouble(text[2]);
                    break;
                }
                citaj = sr.ReadLine();
            }

            sr.Close();

            return kurs;
        }

        [WebMethod]
        public bool UpisiKursNaDan(DateTime Datum, string valuta, double Kurs) 
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\VebProgramiranje\A10\Servis\Servis\App_Data\KursnaLista.txt", true);

            sw.WriteLine(Datum.ToShortDateString() + " | " + valuta + " | " + Kurs);

            sw.Close();

            return true;
        }

        [WebMethod]
        public List<string> ProcitajSveValute()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A10\Servis\Servis\App_Data\KursnaLista.txt");
            List<string> valute = new List<string>();

            string[] text;
            string citaj = sr.ReadLine();
            string[] sep = { " | " };

            while (citaj != null) 
            {
                if (citaj == "")
                {
                    citaj = sr.ReadLine();
                    continue;
                } 
                text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                if (!valute.Contains(text[1]))
                    valute.Add(text[1]);
                citaj = sr.ReadLine();
            }

            sr.Close();

            return valute;
        }
    }
}