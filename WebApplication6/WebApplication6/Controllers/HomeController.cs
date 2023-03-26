using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{

    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        private readonly IHostingEnvironment _hosting;
        public HomeController(IHostingEnvironment hosting)
        {
            _hosting = hosting;
        }
        Functions function;
        //public HomeController()
        //{
        //    function = new function();
        //}
        [HttpGet("[action]")]
        public List<Car> GetCars()//200
        {
            function = new Functions();
            return function.ToList();
        }


        [HttpGet("[action]/{id}")]
        public Car GetById(int id)//200
        {
            function = new Functions();
            return function.Find(id);
        }




        [HttpPut("[action]")]
        public Car UpdateCar([FromBody] Car car)//2000
        {
            function = new Functions();
            return function.Update(car);

        }

        [HttpDelete("[action]/{id}")]
        public void DeleteCar(int id)//200
        {
            function = new Functions();
            function.Delete(id);
        }
        [HttpPost("[action]")]
        public void CreatCar([FromForm] CarViewModel carvw/*string autosaloname*/ /*List<IFormFile> ImageUrl*/)//    Id = 404
        {
          
            var path = _hosting.WebRootPath;
            var filepath = path + @"\Content\image\" + carvw.ImageUrl.FileName;
            //var fullpath = Path.Combine(path, filepath);

            var stream = new FileStream(filepath, FileMode.Create);
            carvw.ImageUrl.CopyTo(stream);
            Car car = new Car()
            {
                Ad = carvw.Ad,
                AvtoTəchizatı = carvw.AvtoTəchizatı,
                Marka = carvw.Marka,
                Model = carvw.Model,
                BanNövü = carvw.BanNövü,
                Yürüş = carvw.Yürüş,
                OlcuVahidi = carvw.OlcuVahidi,
                Rəng = carvw.Rəng,
                Qiymet = carvw.Qiymet,
                PulVahidi = carvw.PulVahidi,
                MasinSahibiSayi = carvw.MasinSahibiSayi,
                Yerlerinsayi = carvw.Yerlerinsayi,
                ImageUrl = filepath,
                YanacağNövü = carvw.YanacağNövü,
                SürətlərQutusu = carvw.SürətlərQutusu,
                Ötürücü = carvw.Ötürücü,
                İl = carvw.İl,
                MühGücü = carvw.MühGücü,
                MühHəcmi = carvw.MühHəcmi,
                Bazar = carvw.Bazar,
                VinKod = carvw.VinKod,
                ƏlavəMəlumat = carvw.ƏlavəMəlumat,
                Kredit = carvw.Kredit,
                Barter = carvw.Barter,
                Şəhər = carvw.Şəhər,
                Email = carvw.Email,
                Telefon = carvw.Telefon,
                Vip = carvw.Vip,
                Premium = carvw.Premium,
                ElanQüvvəti = carvw.ElanQüvvəti
            };
          

            function = new Functions();
            function.Creat(car);

            //if (ImageUrl != null)
            //{
            //    car.ImageUrl = " ";
            //    foreach (FormFile item in ImageUrl)
            //    {
            //        var extension = Path.GetExtension(item.FileName);
            //        var newimagename = Guid.NewGuid() + extension;
            //        var location = Path.Combine(Directory.GetCurrentDirectory(), "~/Image/", newimagename);
            //        var stream = new FileStream(location, FileMode.Create);
            //        item.CopyTo(stream);
            //        car.ImageUrl += newimagename + ",";
            //    }



            //var x = cdb.AutoSalons.Find(autosaloname);
            //car.AutoSalonId = x.AutoSalonId;

        }
        //[HttpGet("[action]/{id}")]
        //    public Car GetIdCar(int id)
        //    {
        //        CarDbContext cdb = new CarDbContext();
        //        return cdb.Cars.Find(id);

        //    }
        [HttpGet("[action]/{pagevalue}/{size}")]//20000
        public List<Car> Page(int pagevalue = 0, int size = 5)
        {
            function = new Functions();
            return function.Page(pagevalue, size);
        }

        //[HttpGet("[action]")]
        //public List<AutoSalon> AutoSalons()
        //{
        //    CarDbContext cdb = new CarDbContext();
        //    return cdb.AutoSalons.Include(x => x.Cars).ToList();
        //}

        [HttpGet("[action]")]
        public List<Car> GetFilterCar([FromQuery] CarFilter carFilter)//20000
        {
            function = new Functions();
            return function.Filter(carFilter);

        }
        [HttpPut("[action]")]//sorus id ve boolu yazmaliyiq?//2000
        public void GetVip(int id, bool vip)
        {
            function = new Functions();
            function.Vip(id, vip);
        }
        [HttpGet("[action]")]
        public List<Car> VipCars()//2000
        {
            function = new Functions();
            return function.GetPremiumCars();
        }
        [HttpPut("[action]")]//sorus id ve boolu yazmaliyiq?//20000
        public void Ileri(int id)//?????
        {
            function = new Functions();
            function.IləriÇək(id);
        }
        [HttpPut("[action]")]//sorus id ve boolu yazmaliyiq?//2000
        public void GetPremium(int id, bool vip)//?????
        {
            function = new Functions();
            function.Premium(id, vip);
        }
        [HttpGet("[action]")]
        public List<Car> PremiumCars()//20000
        {
            function = new Functions();
            return function.GetPremiumCars();
        }
        [HttpGet("[action]")]
        public List<Car> OrderbyPrice()//200000
        {
            CarDbContext cdb = new CarDbContext();
            return cdb.Cars.OrderBy(x => x.Qiymet).ToList();
        }
        [HttpGet("[action]")]//200000
        public List<Car> OrderbyPriceDesc()
        {
            CarDbContext cdb = new CarDbContext();
            return cdb.Cars.OrderByDescending(x => x.Qiymet).ToList();
        }
        [HttpGet("[action]")]//2000000
        public List<Car> OrderbyYUrus()
        {
            CarDbContext cdb = new CarDbContext();
            return cdb.Cars.OrderByDescending(x => x.Yürüş).ToList();
        }
        [HttpGet("[action]")]//20000000
        public List<Car> OrderbyIl()
        {
            CarDbContext cdb = new CarDbContext();
            return cdb.Cars.OrderByDescending(x => x.İl).ToList();
        }




    }
}


