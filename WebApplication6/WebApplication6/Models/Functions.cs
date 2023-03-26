using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Functions : IFunctionsInterface
    {
        CarDbContext cdb = new CarDbContext();
        public void Creat(Car car)
        {
            if (car.OlcuVahidi == "Mi")
            {
                car.Yürüş = car.Yürüş / 0.62137f;
                car.OlcuVahidi = "Km";
            }
            cdb.Cars.Add(car);
            cdb.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = cdb.Cars.Find(id);
            cdb.Cars.Remove(car);
            cdb.SaveChanges();
        }

        public Car Update(Car car)
        {
            cdb.Cars.Update(car);
            cdb.SaveChanges();
            return car;
        }

        public List<Car> ToList()
        {
            return cdb.Cars.OrderByDescending(x => x.ElanQüvvəti).ToList();
        }

        public List<Car> Filter(CarFilter carFilter)
        {
            List<Car> cars = new List<Car>();
            cars = cdb.Cars.Where(x => x.Model == carFilter.Model || x.Marka == carFilter.Marka || x.Şəhər == carFilter.Şəhər || (x.Qiymet > carFilter.QiymətMin && x.Qiymet < carFilter.QiymətMax)
            || x.PulVahidi == carFilter.PulVahidi || x.Kredit == carFilter.Kredit || x.Marka == carFilter.Marka || x.BanNövü == carFilter.BanNövü
            || (x.İl > carFilter.İlMin && x.İl < carFilter.İlMax) || x.Rəng == carFilter.Rəng || x.YanacağNövü == carFilter.YanacağNövü
            || x.Ötürücü == carFilter.Ötürücü || x.SürətlərQutusu == carFilter.SürətlərQutusu || (x.MühHəcmi > carFilter.MühHəcmiMin && x.MühHəcmi < carFilter.MühHəcmiMax)
            || (x.MühGücü > carFilter.MühGücüMin && x.MühGücü < carFilter.MühGücüMax) || (x.Yürüş > carFilter.YürüşMin && x.Yürüş < carFilter.YürüşMax)
            || x.MasinSahibiSayi == carFilter.MasinSahibiSayi || x.Yerlerinsayi == carFilter.Yerlerinsayi || x.Bazar == carFilter.Bazar || x.Vəziyəti == carFilter.Vəziyəti
                || x.AvtoTəchizatı == carFilter.AvtoTəchizatı).ToList();
            return cars;
        }

        public List<Car> Page(int pagevalue = 0, int size = 5)
        {
            return cdb.Cars.Skip(pagevalue).Take(size).ToList();
        }

        public Car Find(int id)
        {
            return cdb.Cars.Find(id);
        }

        public void Vip(int id, bool vip)
        {
            var car = cdb.Cars.Find(id);
            car.Vip = vip;
            cdb.Cars.Update(car);
            cdb.SaveChanges();
        }

        public List<Car> GetPremiumCars()
        {
            var cars = cdb.Cars.Where(x => x.Vip == true).ToList();
            return cars;
           
        }

        public void Premium(int id, bool premium)
        {
            var car = cdb.Cars.Find(id);
            car.Premium = premium;
            cdb.Cars.Update(car);
            cdb.SaveChanges();
        }

        public List<Car> GetVPremiumCars()
        {
            var cars = cdb.Cars.Where(x => x.Premium == true).ToList();
            return cars;
        }

        public void IləriÇək(int id)
        {

            var car = cdb.Cars.Find(id);
            car.ElanQüvvəti += 10;
            cdb.Cars.Update(car);
            cdb.SaveChanges();
        }

        
    }
}
