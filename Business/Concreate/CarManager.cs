using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CarManager : ICarManager
    {

        private readonly ICarDal _carDal;
        private readonly ICarImageManager _carImageManager;

        public CarManager(ICarDal productDal, ICarImageManager carImageManager)
        {
            _carDal = productDal;
            _carImageManager = carImageManager;
        }

        [ValidationAspect(typeof(CarValidator))]
		[CacheRemoveAspect("ICarService.Get")]
		public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("Araba eklendi");

        }

        [ValidationAspect(typeof(CarValidator))]
		[CacheRemoveAspect("ICarService.Get")]
		public IResult Delete(int id)
        {
            _carDal.Delete(id);
            return new SuccessResult($"{id}'ye ait araba silindi.");
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Car updatelendi.");
        }

		[CacheAspect]
		public IDataResult<Car> GetById(int id)
        {
            var data = _carDal.GetById(id);
            return new SuccessDataResult<Car>(data);

        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> Where(Expression<Func<Car, bool>> filter)
        {
            return new SuccessDataResult<List<Car>>(_carDal.Where(filter));
        }
        public IDataResult<List<CarImage>> CheckCarImages(int carId)
        {
            return _carImageManager.CheckCarImage(carId); //result is already incoming with SuccesDataResult from CarImageManager. There is no need to write another SuccessDataResult
        }
    }
}