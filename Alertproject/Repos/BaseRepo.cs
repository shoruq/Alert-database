using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;

namespace Alertproject.Repos
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {


        private AppContext _app;
        public BaseRepo(AppContext app)
        {
            this._app = app;
        }
        public void Add(T t)
        {
            _app.Set<T>().Add(t);
            _app.SaveChanges();
        }

        public T Get(int id)
        {
            return _app.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _app.Set<T>().ToList();
        }

        public void Update(int id, T t)
        {
            _app.Set<T>().Update(t);
            _app.SaveChanges();
        }
    }
}
