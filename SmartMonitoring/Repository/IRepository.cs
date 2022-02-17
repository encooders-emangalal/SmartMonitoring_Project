using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.Repository
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(object id);
        IEnumerable<T> GetAll();
        int Commit();
    }
}
