using IKEA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Repositories
{
    public interface IGenaricRepo<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll(bool WithTracking = false);
        public TEntity GetById(int id);
        public int Add(TEntity item);
        public int Update(TEntity item);
        public int Delete(int id);


    }
}
