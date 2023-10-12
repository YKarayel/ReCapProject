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
    public class ColorManager : IColorManager
    {
        private readonly IColorDal _colorDal;
        private readonly ICarDal _carDal;

        public ColorManager(IColorDal colorDal, ICarDal carDal)
        {
            _colorDal = colorDal;
            _carDal = carDal;
        }

        public void Add(Color nesne)
        {
            _colorDal.Add(nesne);
            Console.WriteLine("renk eklendi");
        }

        public void Delete(int id)
        {
            _colorDal.Delete(id);
            Console.WriteLine($"{id}'ye ait renk silindi.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.GetById(id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            var hasData = _colorDal.GetById(id);
            return _carDal.Where(x => x.BrandId == hasData.Id);
        }

        public void Update(Color nesne)
        {
            _colorDal.Update(nesne);
            Console.WriteLine("Marka updatelendi.");
        }
    }
}
