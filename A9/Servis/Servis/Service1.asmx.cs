using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        public string CirilicaULatinicu(string tekst) 
        {
            string prevod = "";
            for (int i = 0; i < tekst.Length; ++i) 
            {
                foreach (KeyValuePair<string, string> s in Konvertor.dict) 
                {
                    if (i != tekst.Length - 1) 
                    {
                        if ((tekst[i].ToString() + tekst[i + 1].ToString()) == s.Value) 
                        {
                            prevod += s.Key;
                            i++;
                            break;
                        }
                    }
                    if (tekst[i].ToString() == s.Value)
                    {
                        prevod += s.Key;
                        break;
                    }
                }
            }
            return prevod;
        }

        [WebMethod]
        public string LatinicaUCirilicu(string tekst)
        {
            string prevod = "";
            for (int i = 0; i < tekst.Length; ++i)
            {
                foreach (KeyValuePair<string, string> s in Konvertor.dict)
                {
                    if (i != tekst.Length - 1)
                    {
                        if ((tekst[i].ToString() + tekst[i + 1].ToString()) == s.Key)
                        {
                            prevod += s.Value;
                            i++;
                            break;
                        }
                    }
                    if (tekst[i].ToString() == s.Key)
                    {
                        prevod += s.Value;
                        break;
                    }
                }
            }
            return prevod;
        }
    }
}