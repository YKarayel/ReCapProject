using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        string GetById(int id);
        void GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
