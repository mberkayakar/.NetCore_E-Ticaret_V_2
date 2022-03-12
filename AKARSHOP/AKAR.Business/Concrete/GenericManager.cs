using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T>
    {
        private IGenericRepository<T> _item;
         
        public GenericManager(IGenericRepository<T> _item)
        {
            this._item = _item;
        }

        public void Add(T item)
        {
            _item.Add(item);

        }

        public void Delete(T item)
        {
            _item.Delete(item);
        }

        public List<T> GetAll()
        {
            return _item.GetAll();
        }

        public T GetById(int id)
        {
            
            return _item.GetById(id);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
