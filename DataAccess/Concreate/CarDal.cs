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
    public class CarDal : ICarDal
 
    {
        public void Add(Car entity)
        {
            using (var context = new AppDbContext())
            {
                context.Add<Car>(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var hasData = context.Cars.SingleOrDefault(x=> x.Id == id);
                context.Cars.Remove(hasData);
            }
        }



        public List<Car> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.ToList();
            }
        }

        public Car GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.SingleOrDefault(x=>x.Id == id);
            }
        }

        public void Update(Car entity)
        {
            using (var context = new AppDbContext())
            {
               var hasData = context.Cars.FirstOrDefault(x => x.Id == entity.Id);
               hasData.DailyPrice = entity.DailyPrice;
                hasData.BrandId = entity.BrandId;
                hasData.ColorId = entity.ColorId;
                hasData.DailyPrice = entity.DailyPrice;
                hasData.Description = entity.Description;
                context.SaveChanges();
            }
        }

        public List<Car> Where(Expression<Func<Car, bool>> filter)
        {
            using(var context = new AppDbContext()) 
            {
                return context.Cars.Where(filter).ToList();
            }
        }
    }
}
