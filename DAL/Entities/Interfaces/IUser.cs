using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.DAL.Entities.Interfaces
{
    internal interface IUser
    {
        Task<List<ColorOasisSystem.Entities.User>> GetAll();
        Task<ColorOasisSystem.Entities.User> GetById(int id);
        Task<bool> DeleteById(int id);
        Task<bool> Add(ColorOasisSystem.Entities.User Item);
        Task<bool> Update(ColorOasisSystem.Entities.User Item);
        Task<bool> Delete(ColorOasisSystem.Entities.User _Item);
        Task<ColorOasisSystem.Entities.User> ValidateUser(string _userName, string _password);
        Task<bool> IsEmpty();
        Task<ColorOasisSystem.Entities.User> GetByRecoveryWord(string _recoverWord);
        Task ChangePassword(int _id, string _password);
    }
}
