using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.DAL.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        IRepo<T> GetRepository<T>();
        Task CommitAsync();
        void Rollback();
    }
}
