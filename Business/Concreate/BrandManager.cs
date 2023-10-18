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
        private readonly ICarManager _carManager;

        public BrandManager(IBrandDal brandDal, ICarManager carManager)
        {
            _brandDal = brandDal;
            _carManager = carManager;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Marka başarıyla eklendi");
        }

        public IResult Delete(int id)
        {
            _brandDal.Delete(id);
            return new SuccessResult($"{id}'ye ait marka silindi.");
        }
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Marka updatelendi");
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
            var result= _carManager.Where(x => x.BrandId == id);
            return new SuccessDataResult<List<Car>>(result.Data);
        }
    }
}
