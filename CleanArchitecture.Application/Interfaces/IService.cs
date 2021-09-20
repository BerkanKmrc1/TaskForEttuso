using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IService<TEntity>
    {
        Task<bool> Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
