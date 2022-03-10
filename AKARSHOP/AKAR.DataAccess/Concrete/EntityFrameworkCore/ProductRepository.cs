using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete.EntityFrameworkCore;
using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete
{


    public class MYSQLProductRepository : IProductRepository
    {
        private EFContext db = new EFContext();

        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> where = null, params Expression<Func<Product, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Product GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetPOPULARProduct()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
