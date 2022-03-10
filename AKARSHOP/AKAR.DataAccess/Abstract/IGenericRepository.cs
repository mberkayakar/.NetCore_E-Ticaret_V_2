using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Abstract
{

    /* Herhangi bir tip bağımlılığı olmamamsı için generic olarak ürettik bu sebeple bu
     interface i generic oluşturduk */
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);

        List<T> GetAll();


        //List<T> GetAll(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperties);

    }
}
