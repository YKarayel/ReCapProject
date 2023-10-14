using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class RentalManager : IRentalManager
    {
        private readonly IRentalDal _rentalsDal;

        public RentalManager(IRentalDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rental nesne)
        {
            if (nesne.ReturnDate <= nesne.RentDate)
                return new ErrorResult("kiralama tarihi araç iade tarihinden küçük olamaz");

            _rentalsDal.Add( nesne );
            return new SuccessResult("Kiralama başarılı bir şekilde eklendi");
        }

        public IResult Delete(int id)
        {
            _rentalsDal.Delete( id );
            return new SuccessResult("Kiralama başarılı bir şekilde silindi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalsDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalsDal.GetById(id));
        }

        public IResult Update(Rental nesne)
        {
            _rentalsDal.Update( nesne );
            return new SuccessResult("Kiralama başarılı bir şekilde güncellendi");
        }
    }
}
