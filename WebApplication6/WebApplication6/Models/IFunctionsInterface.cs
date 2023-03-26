using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    interface IFunctionsInterface
    {
        public List<Car> ToList();
        public Car Find(int id);
        public Car Update( Car car);
        public void Delete(int id);
        public void Creat(Car car /*string autosaloname*/ /*List<IFormFile> ImageUrl*/);
        public List<Car> Filter(CarFilter carFilter);
        public List<Car> Page(int pagevalue = 0, int size = 5);
        public void Vip(int id, bool vip);
        public List<Car> GetPremiumCars();
        public void Premium(int id, bool vip);
        public List<Car> GetVPremiumCars();
        public void IləriÇək(int id);
    }
}
