using ColorOasisSystem.DAL.Entities.Interfaces;
using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.DAL.Entities
{
    public class UnitOfWork //: IUnitOfWork
    {
        //private readonly DbContext _context;

        //public UnitOfWork(DbContext context)
        //{
        //    _context = context;
        //}

        //public IRepo<T> GetRepository<T>()
        //{
        //    return new Repository<T>(_context); // Replace with your repository implementation
        //}
        //public IRepo<T> GetRepository<T>()
        //{
        //    return new InMemoryRepository<T>(); // Replace with your actual repository implementation
        //}
        //public async Task CommitAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //public void Rollback() => _context.ChangeTracker.Clear();
    }
    //public class UnitOfWork //: IUnitOfWork
    //{
    //    //private readonly DbContext _context;

    //    //public UnitOfWork(DbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    //public IRepository<T> GetRepository<T>()
    //    //{
    //    //    return new Repository<T>(_context); // Replace with your repository implementation
    //    //}

    //    //public async Task CommitAsync()
    //    //{
    //    //    await _context.SaveChangesAsync();
    //    //}

    //    //public void Rollback()
    //    //{
    //    //    _context.ChangeTracker.Clear();
    //    //}
    //}
}
