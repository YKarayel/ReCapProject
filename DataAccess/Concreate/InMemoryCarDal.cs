using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {

                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=100000, ModelYear="2020", Description="Renault"},
                new Car {Id=2, BrandId=2, ColorId=2, DailyPrice=200000, ModelYear="2022", Description="Audi"},
                new Car {Id=3, BrandId=1, ColorId=3, DailyPrice=150000, ModelYear="2021", Description="Ford"},
                new Car {Id=4, BrandId=3, ColorId=1, DailyPrice=300000, ModelYear="2023", Description="Opel"},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            var hasData = _cars.FirstOrDefault(c => c.Id == id);
            if (hasData != null) _cars.Remove(hasData);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public string GetById(int id)
        {
            string hasData = _cars.FirstOrDefault(x => x.Id == id).ToString();
            return hasData;

        }

        public void Update(Car car)
        {
            var hasData = _cars.FirstOrDefault(x => x.Id == car.Id);
      
            hasData.BrandId = car.BrandId;
            hasData.ColorId = car.ColorId;
            hasData.ModelYear = car.ModelYear;
            hasData.DailyPrice = car.DailyPrice;
            hasData.Description = car.Description;
        }
    }
}
