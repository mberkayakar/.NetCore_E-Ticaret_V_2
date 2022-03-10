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


    public class MYSQLProductRepository : GenericRepository<Product, EFContext>, IProductRepository
    {
        public List<Product> GetPOPULARProduct()
        {
            throw new NotImplementedException();
        }
    }
}
