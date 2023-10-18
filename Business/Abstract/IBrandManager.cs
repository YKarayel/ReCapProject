using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandManager
    {

        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(int id);
        IDataResult<Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
    }
}
