using Core.Entities;
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

        public List<User> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Users.ToList();
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
                user.CustomerId = entity.CustomerId;
                user.Password = entity.Password;
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
    }
}
