using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 || car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult("Araba eklendi");
            }
            else return new ErrorResult("Lütfen araba ismini yada günlük fiyatı kontrol ediniz.");

        }

        public IResult Delete(int id)
        {
            _carDal.Delete(id);
            return new SuccessResult($"{id}'ye ait araba silindi.");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car); 
            return new SuccessResult("Car updatelendi.");
        }

 
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(id));
           
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
    }
}
