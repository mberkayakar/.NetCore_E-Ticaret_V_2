using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Business.Abstract
{
    public interface IProductServices : IGenericService<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductByCategory(string category);


    }
}
