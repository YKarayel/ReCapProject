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
    public class ColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (var context = new AppDbContext())
            {
                context.Colors.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var hasData = context.Colors.FirstOrDefault(x => x.Id == id);
                context.Colors.Remove(hasData);
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Colors.ToList() : context.Colors.Where(filter).ToList();
            }
        }

        public List<Color> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Colors.ToList();
            }
        }


        public Color GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Colors.FirstOrDefault(x=>x.Id == id);
            }
        }

        public void Update(Color entity)
        {
            using (var context = new AppDbContext())
            {
                var hasData = context.Colors.FirstOrDefault(x => x.Id == entity.Id);
                hasData.Name = entity.Name;
                context.SaveChanges();
            }
        }

        public List<Color> Where(Expression<Func<Color, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return context.Colors.Where(filter).ToList();
            }
        }
    }
}
