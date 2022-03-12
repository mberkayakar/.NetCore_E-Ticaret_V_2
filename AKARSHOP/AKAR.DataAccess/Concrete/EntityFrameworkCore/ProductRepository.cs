using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete.EntityFrameworkCore;
using AKAR.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete
{


    public class ProductRepository : GenericRepository<Product, EFContext>, IProductRepository
    {
        public List<Product> GetPOPULARProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            using (var contex = new EFContext())
            {
                return contex.Products.Where(p => p.ProductId == id).
                    Include(p => p.ProductCategory).
                    ThenInclude(p => p.Category).
                    FirstOrDefault();
            }

        }
    }
}
