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
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ColorManager : IColorManager
    {
        private readonly IColorDal _colorDal;
        private readonly ICarDal _carDal;

        public ColorManager(IColorDal colorDal, ICarDal carDal)
        {
            _colorDal = colorDal;
            _carDal = carDal;
        }

        [ValidationAspect(typeof(ColorValidator))]

        public IResult Add(Color nesne)
        {
            _colorDal.Add(nesne);
            return new SuccessResult("renk eklendi");
        }

        public IResult Delete(int id)
        {
            _colorDal.Delete(id);
            return new SuccessResult($"{id}'ye ait renk silindi.");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.GetById(id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            var hasData = _colorDal.GetById(id);
            return new SuccessDataResult<List<Car>>(_carDal.Where(x => x.BrandId == hasData.Id));
        }

        public IResult Update(Color nesne)
        {
            _colorDal.Update(nesne);
            return new SuccessResult("Renk güncellendi");
        }
    }
}
