using OnlineStore.Core.Entities;
using System;
using System.Threading.Tasks;

namespace OnlineStore.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> CompleteAsync();
    }
}
