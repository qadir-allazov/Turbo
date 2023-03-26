using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class CarFilter
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string BanNövü { get; set; }
        public int YürüşMin { get; set; }
        public int YürüşMax { get; set; }
        public bool Kredit { get; set; }
        public bool Barter { get; set; }
        public string Şəhər { get; set; }
        public int QiymətMin { get; set; }
        public int QiymətMax { get; set; }
        public string PulVahidi { get; set; }
        public int İlMin { get; set; }
        public int İlMax { get; set; }
        public string Rəng { get; set; }
        public string YanacağNövü { get; set; }
        public string Ötürücü { get; set; }
        public string SürətlərQutusu { get; set; }
        public int MühHəcmiMin { get; set; }
        public int MühHəcmiMax { get; set; }
        public int MühGücüMin { get; set; }
        public int MühGücüMax { get; set; }
        public string MasinSahibiSayi { get; set; }
        public int Yerlerinsayi { get; set; }
        public string Bazar { get; set; }
        public string Vəziyəti { get; set; }
        public string AvtoTəchizatı { get; set; }
    }
}
