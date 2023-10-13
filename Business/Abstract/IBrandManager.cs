using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandManager : IGenericService<Brand>
    { 
        IDataResult<List<Car>> GetCarsByBrandId(int id);
    }
}
