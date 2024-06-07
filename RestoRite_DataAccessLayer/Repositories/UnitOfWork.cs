using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestoRite_DataAccessLayer.Data;
using RestoRite_DataAccessLayer.IRepositories;

namespace RestoRite_DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBaseRepository<T> GetRepository<T>() where T : class
        {
            return new BaseRepository<T>(_dbContext);
        }

        public int Save() => _dbContext.SaveChanges();

        public Task<int> SaveAsync() => _dbContext.SaveChangesAsync();

    }
}