using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CarManager : ICarManager
    {
        
        private readonly ICarDal _carDal;

        public CarManager(ICarDal productDal)
        {
            _carDal = productDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 || car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Car eklendi");
            }
            else Console.WriteLine("Lütfen araba ismini yada günlük fiyatı kontrol ediniz.");

        }

        public void Delete(int id)
        {
            _carDal.Delete(id);
            Console.WriteLine($"{id}'ye ait araba silindi.");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car updatelendi.");
        }

 
        public Car GetById(int id)
        {
            return _carDal.GetById(id);
           
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
