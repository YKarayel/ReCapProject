using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
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
                context.SaveChanges();
            }
        }
        
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Cars.ToList() : context.Cars.Where(filter).ToList();
            }
        }

        public Car GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                var data = context.Cars.SingleOrDefault(x => x.Id == id);
                return data;
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
                hasData.CarImageId = entity.CarImageId;
                context.SaveChanges();
            }
        }

        public List<Car> Where(Expression<Func<Car, bool>> filter)
        {
            using(var context = new AppDbContext()) 
            {

                var hasData = context.Cars.Where(filter).ToList();
                return hasData;
            }
        }
    }
}
