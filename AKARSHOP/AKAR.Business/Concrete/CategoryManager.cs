using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public CategoryManager(ICategoryRepository _item) : base(_item)
        {

        }
    }
}
