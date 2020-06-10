using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Vozni_Park.Models;

namespace Vozni_Park.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Evidentiranje()
        {
            string[] text;
            string citaj;
            string[] sep = { " | " };
            List<Podaci_o_vozilima> vozila = new List<Podaci_o_vozilima>();

            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\vozila.txt");
            citaj = sr.ReadLine();
            while (citaj != null) 
            {
                text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                vozila.Add(new Podaci_o_vozilima
                {
                    RegistarskiBroj = text[0],
                    Marka = text[1],
                    Godina = text[2],
                    Boja = text[3]
                });
                citaj = sr.ReadLine();
            }
            sr.Close();

            TempData["reg_broj"] = Request.Form["reg_broj"];
            TempData["datum"] = Request.Form["datum"];
            TempData["od_mesta"] = Request.Form["od_mesta"];
            TempData["do_mesta"] = Request.Form["do_mesta"];
            TempData["kilometri"] = Request.Form["kilometri"];

            if (TempData["reg_broj"] != null)
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\" + TempData["reg_broj"].ToString() + ".txt", true);
                sw.Write("\n" + TempData["datum"].ToString() + " | " + TempData["od_mesta"].ToString() + " | " + TempData["do_mesta"].ToString() + " | " + TempData["kilometri"].ToString());
                sw.Close();
            }

            return View(vozila);
        }

        public ActionResult Prikaz() 
        {
            string[] sep = { " | " };

            TempData["reg_broj"] = Request.Form["reg_broj"];
            if (TempData["reg_broj"] != null)
            {
                ViewBag.da_ne = "da";

                string reg_broj = TempData["reg_broj"].ToString();

                StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\vozila.txt");
                string citaj;
                string[] text;
                citaj = sr.ReadLine();
                while (citaj != null)
                {
                    text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    if (text[0] == reg_broj)
                    {
                        ViewBag.Reg = text[0];
                        ViewBag.Marka = text[1];
                        ViewBag.Godina = text[2];
                    }
                    citaj = sr.ReadLine();
                }
                sr.Close();

                StreamReader sr_vozilo = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\" + reg_broj + ".txt");
                citaj = sr_vozilo.ReadLine();
                int sum = 0;
                while (citaj != null)
                {
                    if (citaj != "")
                    {
                        text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        sum += Convert.ToInt32(text[3]);
                    }
                    citaj = sr_vozilo.ReadLine();
                }
                ViewBag.Kilometri = sum;
                sr_vozilo.Close();

                return View();
            }
            else 
            {
                ViewBag.da_ne = "ne";

                List<Ukupno> tabela = new List<Ukupno>();

                StreamReader sr_sve = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\vozila.txt");

                string citaj_sve;
                string[] text_sve;

                citaj_sve = sr_sve.ReadLine();

                while (citaj_sve != null) 
                {
                    text_sve = citaj_sve.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                    StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\VebProgramiranje\A15\Vozni_Park\Vozni_Park\App_Data\" + text_sve[0] + ".txt");
                    int sum = 0;
                    string citaj;
                    string[] text;
                    citaj = sr.ReadLine();
                    while (citaj != null)
                    {
                        if (citaj != "")
                        {
                            text = citaj.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                            sum += Convert.ToInt32(text[3]);
                        }
                        citaj = sr.ReadLine();
                    }
                    sr.Close();

                    tabela.Add(new Ukupno
                    {
                        Registarski_broj = text_sve[0],
                        Marka = text_sve[1],
                        Godina = text_sve[2],
                        Ukupno_kilometara = sum
                    });

                    citaj_sve = sr_sve.ReadLine();
                }

                sr_sve.Close();

                return View(tabela);
            } 
        }
    }
}
