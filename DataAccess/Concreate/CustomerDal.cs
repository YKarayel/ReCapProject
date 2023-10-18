using Castle.Core.Resource;
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
    public class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (var context = new AppDbContext())
            {
                context.Add<Customer>(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.SingleOrDefault(x => x.Id == id);
                context.Remove<Customer>(customer);
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Customers.ToList() : context.Customers.Where(filter).ToList();

            }
        }

        public Customer GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.SingleOrDefault(x => x.Id == id);
                return customer;
            }
        }

        public void Update(Customer entity)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.SingleOrDefault(x => x.Id == entity.Id);
                customer.CompanyName = entity.CompanyName;
                context.SaveChanges();
            }
        }

        public List<Customer> Where(Expression<Func<Customer, bool>> filter = null)
        {
             using (var context = new AppDbContext())
            {
                var customers = context.Customers.Where(filter).ToList();
                return customers;
            }
        }
    }
}
