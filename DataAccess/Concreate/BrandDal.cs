﻿using Core.Utilities.Results;
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
    public class BrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (var context = new AppDbContext())
            {
                context.Brands.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var hasData = context.Brands.FirstOrDefault(x=> x.Id == id);
                context.Brands.Remove(hasData);
                context.SaveChanges();

            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (var context = new AppDbContext())
            {
                return filter == null ? context.Brands.ToList() : context.Brands.Where(filter).ToList();
            }
        }

        public List<Brand> GetAll()
        {
            using (var context = new AppDbContext())
            {
                var result = context.Brands.ToList();
                return result;

            }
        }


        public Brand GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Brands.FirstOrDefault(x=>x.Id == id);
            }
        }

        public void Update(Brand entity)
        {
            using (var context = new AppDbContext())
            {
                var hasData = context.Brands.FirstOrDefault(x => x.Id == entity.Id);
                hasData.Name = entity.Name;
                context.SaveChanges();
            }
        }

        public List<Brand> Where(Expression<Func<Brand, bool>> filter)
        {
            using(var context = new AppDbContext()) 
            {
                var hasData = context.Brands.Where(filter);
                return hasData.ToList();
            }

        }
    }
}
