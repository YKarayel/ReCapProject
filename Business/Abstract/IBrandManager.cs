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
        public List<Car> GetCarsByBrandId(int id);
    }
}
