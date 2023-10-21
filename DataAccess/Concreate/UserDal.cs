using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class UserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (var context = new AppDbContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.SingleOrDefault(x => x.Id == id);
                context.Remove(user);
                context.SaveChanges();
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Users.ToList() : context.Users.Where(filter).ToList();
            }
        }

        public User GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Users.SingleOrDefault(x => x.Id == id);
            }
        }

        public void Update(User entity)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.SingleOrDefault(x => x.Id == entity.Id);
                //user.CustomerId = entity.CustomerId;
                //user.Password = entity.Password;
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Email = entity.Email;
                context.SaveChanges();
                
            }
        }

        public List<User> Where(Expression<Func<User, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return context.Users.Where(filter).ToList();

            }
        }

		public User Get(Expression<Func<User, bool>> filter)
		{
			using (var context = new AppDbContext())
			{
				return context.Users.SingleOrDefault(filter);

			}
		}
		public List<OperationClaim> GetClaims(User user)
        {

            using (var context = new AppDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationsClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
