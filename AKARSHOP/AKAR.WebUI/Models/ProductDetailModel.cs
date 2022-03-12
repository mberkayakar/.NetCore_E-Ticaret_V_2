using AKAR.Entities;
using System.Collections.Generic;

namespace AKAR.WebUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
    }
}
