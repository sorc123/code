using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vozni_Park.Models
{
    public class Ukupno
    {
        public string Registarski_broj { get; set; }
        public string Marka { get; set; }
        public string Godina { get; set; }
        public int Ukupno_kilometara { get; set; }
    }
}