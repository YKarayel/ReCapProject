using Business.Abstract;
using DataAccess.Abstract;
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
        
        private readonly ICarDal _productDal;

        public CarManager(ICarDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("Car eklendi");
            _productDal.Add(car);
        }

        public void Delete(int id)
        {
            Console.WriteLine(id + " numaralı data silindi.");
            _productDal.Delete(id);
        }

        public List<Car> GetAll()
        {
            var data = _productDal.GetAll();
            Console.WriteLine(data + " GetAll");
            return data;
        }

        public string GetById(int id)
        {
            var hasData = _productDal.GetById(id).ToString();
            Console.WriteLine(hasData + "GetById");
            return _productDal.GetById(id);
        }

        public void Update(Car car)
        {
            Console.WriteLine("Car updatelendi.");
            _productDal.Update(car);
        }
    }
}
