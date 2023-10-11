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

        public void GetAll()
        {
            _productDal.GetAll();
        }

        public void GetById(int id)
        {
            var hasData = _productDal.GetById(id).ToString();
            Console.WriteLine(hasData + "GetById");
        }

        public void Update(Car car)
        {
            Console.WriteLine("Car updatelendi.");
            _productDal.Update(car);
        }
    }
}
