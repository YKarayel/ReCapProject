using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class CarImageDal : ICarImageDal
    {
        public void Add(CarImage entity)
        {
            using (var context = new AppDbContext())
            {
                context.CarImages.Add(entity); 
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var result = context.CarImages.FirstOrDefault(c => c.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
        }

        public List<CarImage> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.CarImages.ToList();
            }
        }

        public List<CarImage> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.CarImages.ToList() : context.CarImages.Where(filter).ToList();


            }
        }

        public CarImage GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.CarImages.FirstOrDefault(c => c.Id == id);
            }
        }

        public void Update(CarImage entity)
        {
            using (var context = new AppDbContext())
            {
                var result = context.CarImages.FirstOrDefault(c => c.Id == entity.Id);
                result.CarId = entity.CarId;
                result.ImagePath = entity.ImagePath;
                result.UploadDate = entity.UploadDate;
                context.SaveChanges();
            }
        }

        public List<CarImage> Where(Expression<Func<CarImage, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return context.CarImages.Where(filter).ToList();
            }
        }
    }
}
