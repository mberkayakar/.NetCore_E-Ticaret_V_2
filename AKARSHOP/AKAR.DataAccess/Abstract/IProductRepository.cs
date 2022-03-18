using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Abstract
{

    /* 
     
     Bu şekilde intefaceler ile birlikte artık sınıfa özgü olup diğer sınıflarda olmayan methodlarıda bu aşamada tanımlayabilmekteyiz*/
    public interface IProductRepository:IGenericRepository<Product>
    {
        /*Yukarıdaki bahsedilen açıklamalar burada gerçekleşecektir. */
        List<Product> GetPOPULARProduct();


        // Her repository nin kendisine özel bir fonksiyonunun olabilmesi için IProductRepository içerisinde getoprduct details ile inclue kullanarak joinleme alabilmek için
        // interface imzası bu şekilde tanımlanmıştır.
        Product GetProductDetails(int id);


        // kategory e göre ürün getirme işlemi
        List<Product> GetProductByCategory(string category);
    }
}
