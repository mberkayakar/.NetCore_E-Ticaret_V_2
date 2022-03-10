using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Business.Abstract
{
    public interface IProductServices
    {
        Product GetById(int id);
        void Add(Product item);
        void Update(Product item);
        void Delete(Product item);
        List<Product> GetAll();

    }
}
