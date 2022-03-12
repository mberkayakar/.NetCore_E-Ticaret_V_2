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

        public ProductManager(IProductRepository _item) : base(_item)
        {


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
