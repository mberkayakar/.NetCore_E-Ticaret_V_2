using AKAR.DataAccess.Abstract;
using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete.EntityFrameworkCore
{
    public class CategoryRepository : GenericRepository<Category, EFContext>, ICategoryRepository
    {

    }
}
