using AKAR.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete
{

    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> 
        where TEntity : class
        where TContext : DbContext , new()
    
    {

        public void Add(TEntity item)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(item);
                context.SaveChanges();
            }
                    
        }

        public void Delete(TEntity item)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return  context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity item)
        {
            using (TContext context = new TContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
