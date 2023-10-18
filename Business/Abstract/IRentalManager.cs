using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalManager
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(int id);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();

    }
}
