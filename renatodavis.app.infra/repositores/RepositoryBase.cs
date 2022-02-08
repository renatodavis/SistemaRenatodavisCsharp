using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.interfaces;
using renatodavis.app.infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace renatodavis.app.infra.repositores
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected AppContexto Db = new AppContexto();

        public async Task Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            await Db.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Db.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Db.Set<TEntity>().ToListAsync();

        }
        

        public async Task Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            await Db.SaveChangesAsync();
        }

        public async Task Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        
    }
}
