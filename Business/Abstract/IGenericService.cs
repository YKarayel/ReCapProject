using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        IDataResult<T> GetById(int id);
        IDataResult<List<T>> GetAll();
        IResult Add(T nesne);
        IResult Update(T nesne);
        IResult Delete(int id);

    }
}
