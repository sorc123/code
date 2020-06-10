using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raspored_casova.Models
{
    public class Raspored
    {
        public int Redni_broj { get; set; }
        public string Ponedeljak { get; set; }
        public string Utorak { get; set; }
        public string Sreda { get; set; }
        public string Cetvrtak { get; set; }
        public string Petak { get; set; }
    }
}