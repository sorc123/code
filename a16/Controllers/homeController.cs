using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Data;
using Raspored_casova.Models;
using System.IO;

namespace Raspored_casova.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ucitavanje() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ucitavanje(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0) 
            {
                string putanja = Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(file.FileName));
                file.SaveAs(putanja);
                TempData["File"] = file.FileName.ToString();
            }

            return View();
        }

        public ActionResult Prikaz() 
        {
            List<Raspored> raspored = new List<Raspored>();

            if (TempData["File"] != null) 
            {
                string ime_fajla = @"C:\Users\Asus\Desktop\VebProgramiranje\A16\Raspored_casova\Raspored_casova\App_Data\" + TempData["File"].ToString();

                DataSet ds = new DataSet();
                ds.ReadXml(ime_fajla);

                Dictionary<int, string> pon = new Dictionary<int, string>();
                Dictionary<int, string> uto = new Dictionary<int, string>();
                Dictionary<int, string> sre = new Dictionary<int, string>();
                Dictionary<int, string> cet = new Dictionary<int, string>();
                Dictionary<int, string> pet = new Dictionary<int, string>();
                int max = 0;

                for (int i = 0; i < ds.Tables[0].Rows.Count; ++i) 
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]) > max)
                        max = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                    switch (ds.Tables[0].Rows[i].ItemArray[1].ToString()) 
                    {
                        case "Ponedeljak":
                            pon.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[2].ToString());
                            break;
                        case "Utorak":
                            uto.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[2].ToString());
                            break;
                        case "Sreda":
                            sre.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[2].ToString());
                            break;
                        case "Cetvrtak":
                            cet.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[2].ToString());
                            break;
                        case "Petak":
                            pet.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]), ds.Tables[0].Rows[i].ItemArray[2].ToString());
                            break;
                    }   
                }

                string value;
                for (int i = 1; i <= max; ++i) 
                {
                    if (!pon.TryGetValue(i, out value)) 
                    {
                        pon.Add(i, "");
                    }
                    if (!uto.TryGetValue(i, out value))
                    {
                        uto.Add(i, "");
                    }
                    if (!sre.TryGetValue(i, out value))
                    {
                        sre.Add(i, "");
                    }
                    if (!cet.TryGetValue(i, out value))
                    {
                        cet.Add(i, "");
                    }
                    if (!pet.TryGetValue(i, out value))
                    {
                        pet.Add(i, "");
                    }

                    raspored.Add(new Raspored
                    {
                        Redni_broj = i,
                        Ponedeljak = pon[i],
                        Utorak = uto[i],
                        Sreda = sre[i],
                        Cetvrtak = cet[i],
                        Petak = pet[i],

                    });
                }
            }
            return View(raspored);
        }

    }
}
