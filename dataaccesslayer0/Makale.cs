﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer0
{
    public class Makale
    {
        public int ID { get; set; }
        public int Kategori_ID { get; set; }
        public string Kategori { get; set; }
        public int Yazar_ID { get; set; }
        public string Yazar { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public string KapakResim { get; set; }
        public DateTime EkelemeTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int Bagenisayi { get; set; }
        public int GoruntulemeSayi { get; set; }
        public bool Aktif { get; set; }
        public bool Silinmis { get; set; }
    }
}
