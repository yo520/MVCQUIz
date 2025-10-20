using IKEA.DAL.Contexts;
using IKEA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Repositories
{
 

    public class genaricRepository<TEntity> : IGenaricRepo<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext context;

        public genaricRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return context.Set<TEntity>().ToList();
            }
            else
            {
                return context.Set<TEntity>().AsNoTracking().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        public int Add(TEntity item)
        {
            context.Set<TEntity>().Add(item);
            return context.SaveChanges();
        }

        public int Update(TEntity item)
        {
            context.Set<TEntity>().Update(item);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            var item = context.Set<TEntity>().Find(id);
            context.Set<TEntity>().Remove(item);
            return context.SaveChanges();

        }
    }
}
