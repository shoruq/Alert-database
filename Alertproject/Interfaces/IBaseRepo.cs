using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alertproject.Interfaces
{
     public interface IBaseRepo<T> where T : class
    {
    
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(int id, T t);
       

    }
}
