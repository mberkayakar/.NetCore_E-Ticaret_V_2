using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete;
using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Business.Concrete
{


    public class ProductManager : GenericManager<Product>, IProductServices
    {


        IProductRepository _repo;
        public ProductManager(IProductRepository _item) : base(_item)
        {
            _repo = _item;

        }

        public List<Product> GetProductByCategory(string category)
        {
            return _repo.GetProductByCategory(category);
        }

        public Product GetProductDetails(int id)
        {
            return _repo.GetProductDetails(id);
        }




        #region Eski Kodlar (Busines Generic Versiyona çekilmeden önceki hali)

        //private IProductRepository _product;
        //public ProductManager(IGenericRepository<Product> product)
        //{
        //    _product = product;
        //}


        //public void Add(Product item)
        //{
        //    //İş kuralları Uygula
        //     _product.Add(item);
        //}

        //public void Delete(Product item)
        //{

        //    //iş Kuralları 
        //    _product.Delete(item);

        //}

        //public List<Product> GetAll()
        //{
        //    //İş kuralları Uygula
        //    return _product.GetAll();
        //}

        //public Product GetById(int id)
        //{
        //    //İş kuralları Uygula
        //    return _product.GetById(id);
        //}

        //public void Update(Product item)
        //{
        //    //İş kuralları Uygula
        //    throw new NotImplementedException();
        //}

        #endregion

    }
}
