using Core.Entities.Concrete;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
		public List<OperationClaim> GetClaims(User user);
		public User Get(Expression<Func<User, bool>> filter);
	}
}
