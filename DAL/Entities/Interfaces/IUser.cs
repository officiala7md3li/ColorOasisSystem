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
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task<bool> DeleteById(int id);
        Task<bool> Add(User Item);
        Task<bool> Update(User Item);
        Task<bool> Delete(User _Item);
        Task<User> ValidateUser(string _userName, string _password);
        Task<bool> IsEmpty();
        Task<User> GetByRecoveryWord(string _recoverWord);
        Task ChangePassword(int _id, string _password);
    }
}
