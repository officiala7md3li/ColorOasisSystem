using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities.Interfaces
{
    public interface IRepo<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> DeleteById(int id);
        Task<bool> Add(T Item);
        Task<bool> Update(T Item);
        Task<bool> Delete(T _Item);
        Task<bool> IsEmpty();
    }
}