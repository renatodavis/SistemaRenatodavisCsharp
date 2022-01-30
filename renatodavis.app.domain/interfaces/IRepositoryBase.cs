using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace renatodavis.app.domain.interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task Add(TEntity obj);        
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity obj);
        Task Remove(TEntity obj);
     
        void Dispose();
    }
}
