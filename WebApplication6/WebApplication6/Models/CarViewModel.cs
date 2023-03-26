using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class CarViewModel
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string BanNövü { get; set; }
        public float Yürüş { get; set; }
        public string OlcuVahidi { get; set; }
        public string Rəng { get; set; }
        public int Qiymet { get; set; }
        public string PulVahidi { get; set; }
        public string MasinSahibiSayi { get; set; }
        public int Yerlerinsayi { get; set; }
       
        public IFormFile ImageUrl { get; set; }
        //public int AutoSalonId { get; set; }
        //public AutoSalon AutoSalon { get; set; }
        public string YanacağNövü { get; set; }

        public string Ötürücü { get; set; }
        public string SürətlərQutusu { get; set; }
        public int İl { get; set; }
        public int MühHəcmi { get; set; }
        public int MühGücü { get; set; }
        public string Bazar { get; set; }
        public string VinKod { get; set; }
        public string ƏlavəMəlumat { get; set; }
        public string Vəziyəti { get; set; }
        public string AvtoTəchizatı { get; set; }
        public bool Kredit { get; set; } = false;
        public bool Barter { get; set; } = false;
        public string Ad { get; set; }
        public string Şəhər { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool Vip { get; set; } = false;
        public bool Premium { get; set; } = false;
        public int ElanQüvvəti { get; set; }
    }
}
