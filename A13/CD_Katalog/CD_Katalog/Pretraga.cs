using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CD_Katalog
{
    public class Pretraga
    {
        public string Izvodjac { get; set; }
        public string Naziv_albuma { get; set; }
        public string Zanr { get; set; }
        public string Godina_izdanja { get; set; }
        public string Izdavacka_kuca { get; set; }

        public Pretraga(string izvodjac, string naziv_albuma, string zanr, string godina_izdanja, string izdavacka_kuca)
        {
            Izvodjac = izvodjac;
            Naziv_albuma = naziv_albuma;
            Zanr = zanr;
            Godina_izdanja = godina_izdanja;
            Izdavacka_kuca = izdavacka_kuca;
        }
            
    }
}