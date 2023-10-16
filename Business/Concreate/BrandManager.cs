using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand nesne)
        {
            _brandDal.Add(nesne);
            return new SuccessResult("Marka başarıyla eklendi");
        }

        public IResult Delete(int id)
        {
            _brandDal.Delete(id);
            return new SuccessResult($"{id}'ye ait marka silindi.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.GetById(id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            var hasData = _brandDal.GetById(id);

            var carbybrandid= _carDal.Where(x => x.BrandId == hasData.Id);
            return new SuccessDataResult<List<Car>>(carbybrandid);
        }

        public IResult Update(Brand nesne)
        {
            _brandDal.Update(nesne);
            return new SuccessResult("Marka updatelendi");
        }
    }
}
