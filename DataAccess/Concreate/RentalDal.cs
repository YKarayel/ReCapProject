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
    public class RentalDal : IRentalDal
    {
        public void Add(Rental entity)
        {

            using (var context = new AppDbContext())
            {
                context.Rentals.Add(entity);
                context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var rental = context.Rentals.SingleOrDefault(x => x.Id == id);
                context.Rentals.Remove(rental);
                context.SaveChanges();
            }
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Rentals.ToList() : context.Rentals.Where(filter).ToList();
            }
        }

        public Rental GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                var rental = context.Rentals.SingleOrDefault(x => x.Id == id);
                return rental;
            }
        }

        public void Update(Rental entity)
        {
            using (var context = new AppDbContext())
            {
                var rental = context.Rentals.SingleOrDefault(x => x.Id == entity.Id);
                rental.CarId = entity.CarId;
                rental.CustormerId = entity.CustormerId;
                rental.RentDate =  entity.RentDate;
                rental.ReturnDate = entity.ReturnDate;
                context.SaveChanges();
            }
        }

        public List<Rental> Where(Expression<Func<Rental, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(filter).ToList();
            }
        }
    }
}
