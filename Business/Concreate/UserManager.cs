using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
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
    public class UserManager : IUserManager
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]

        public IResult Add(User nesne)
        {
            _userDal.Add(nesne);
            return new SuccessResult("Kullanıcı başarılı bir şekilde eklendi.");
        }

        public IResult Delete(int id)
        {
            _userDal.Delete(id);
            return new SuccessResult("Kullanıcı başarılı bir şekilde silindi");
        }
        public IResult Update(User nesne)
        {
            _userDal.Update(nesne);
            return new SuccessResult("Kullanıcı güncellendi");
        }
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.GetById(id));
        }

		public List<OperationClaim> GetClaims(User user)
		{
			return _userDal.GetClaims(user);
		}

		public User GetByMail(string email)
		{
			return _userDal.Get(u => u.Email == email);
		}
	}
}
