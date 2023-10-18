using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorManager
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(int id);
        IDataResult<Color> GetById(int id);
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int id);

    }
}
