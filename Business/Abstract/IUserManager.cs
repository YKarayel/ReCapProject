using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserManager
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int id);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
		List<OperationClaim> GetClaims(User user);
		User GetByMail(string email);
	}

}

