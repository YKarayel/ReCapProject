using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class BrandManager : IBrandManager
    {
        private readonly IBrandDal _brandDal;
        private readonly ICarDal _carDal;

        public BrandManager(IBrandDal brandDal, ICarDal carDal)
        {
            _brandDal = brandDal;
            _carDal = carDal;
        }

        public void Add(Brand nesne)
        {
            _brandDal.Add(nesne);
            Console.WriteLine("Marka eklendi");
        }

        public void Delete(int id)
        {
            _brandDal.Delete(id);
            Console.WriteLine($"{id}'ye ait marka silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            var hasData = _brandDal.GetById(id);
            return _carDal.Where(x => x.BrandId == hasData.Id);
        }

        public void Update(Brand nesne)
        {
            _brandDal.Update(nesne);
            Console.WriteLine("Marka updatelendi.");
        }

    }
}
