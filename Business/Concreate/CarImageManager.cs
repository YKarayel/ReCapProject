using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CarImageManager : ICarImageManager
    {
        private readonly ICarImageDal _carImageDal;
        private readonly IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = CheckIfCarImageLimit(carImage.CarId);
            if (!result.Success)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, PathConstant.imagesPath);
            carImage.UploadDate = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult("Fotoğraf başarıyla yüklendi");
        }

        public IResult Delete(int id)
        {
            var result = _carImageDal.GetById(id);
            _carImageDal.Delete(id);
            _fileHelper.Delete(PathConstant.imagesPath + result.ImagePath);
            return new SuccessResult("Fotoğraf başarıyla silindi");
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var result = _carImageDal.GetById(carImage.Id);

            result.CarId = carImage.CarId;
            result.ImagePath = _fileHelper.Update(file, PathConstant.imagesPath + carImage.ImagePath, PathConstant.imagesPath);

            _carImageDal.Update(result);
            return new SuccessResult("Fotoğraf güncellendi");
        }
        public IDataResult<List<CarImage>> GetAll()
        {
           
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(id));
        }


        public IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;

            if (result >= 5) return new ErrorResult("Bir araba 5'ten fazla fotoğrafa sahip olamaz");
            
            return new SuccessResult();
        }
        public IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {

            List<CarImage> carImage = new List<CarImage>();

            carImage.Add(new CarImage { 
                CarId = carId, UploadDate = DateTime.Now, ImagePath = PathConstant.imagesPath + "DefaultImage.jpg" });

            return new SuccessDataResult<List<CarImage>>(carImage);
        }
        public IDataResult<List<CarImage>> CheckCarImage(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);

            if (result.Count > 0) 
                return new SuccessDataResult<List<CarImage>>(result);
            
            return new SuccessDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
        }
    }
}



