using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoRite_DataAccessLayer.IRepositories
{
    public interface IUnitOfWork
    {
        IBaseRepository<T> GetRepository<T>() where T : class;

        int Save();

        Task<int> SaveAsync();

    }
}