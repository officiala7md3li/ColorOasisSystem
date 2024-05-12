using System.Collections.Generic;

namespace ColorOasisSystem.Entities.Interfaces
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T GetById(int id);
        bool DeleteById(int id);
        bool Add(T Item);
        bool Update(T Item);
        bool Delete(T _Item);
       
    }
}