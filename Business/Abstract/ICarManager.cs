using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarManager
    {
        
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int id);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> Where(Expression<Func<Car, bool>> filter);
        IDataResult<List<CarImage>> CheckCarImages(int carId);
    }
}
