using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Entities
{
    public class ProductCategory
    {

        /* 
         
        Bu aşamada Bir kategorinin birden fazla ürünü olabileceği 
         
        Ve bir ürününde birden fazla kategorisi olabileceği düşünülerek 
        
        Çoka Çok bir ilişki gerçekleştirilmiştir. 
         */
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
