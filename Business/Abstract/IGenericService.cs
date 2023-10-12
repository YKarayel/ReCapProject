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
        T GetById(int id);
        List<T> GetAll();
        void Add(T nesne);
        void Update(T nesne);
        void Delete(int id);

    }
}
