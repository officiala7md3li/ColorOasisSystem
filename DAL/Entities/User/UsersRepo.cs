using ColorOasisSystem.DAL.Entities.Interfaces;
using ColorOasisSystem.Entities.Interfaces;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.Entities
{
    internal class UserRepo: IRepo<User>
    {
        ApplicationDB db;
        public UserRepo()
        {
            db = new ApplicationDB();
        }
        
        public async Task<List<User>> GetAll()
        {
            
            var Useres = await db.Users.Where(user => user.IsDeleted == false).AsNoTracking().ToListAsync();
            return Useres;
        }
        public async Task<User> GetById(int id)
        {
            var User =await db.Users.Where(user => user.IsDeleted == false && user.Id==id).FirstOrDefaultAsync();
            if (User != null)
            {
                return User;
            }
            return null;
        }
        public async Task<bool> DeleteById(int id)
        {
            try
            {
                if (await IsEmpty())
                {
                    return false;
                    throw new Exception("No Record in Database");
                }
                User User =await db.Users.AsNoTracking().Where(user=>user.Id==id).FirstOrDefaultAsync();
                if (User != null)
                {
                    User.IsDeleted = true;
                    await db.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                    throw new Exception("the Record is null");
                }
            }
            catch (Exception exception)
            {
                return false;
                throw exception;
            }
        }
        public async Task<bool> Add(User Item)
        {
            if (Item != null)
            {
                db.Users.Add(Item);
                await db.SaveChangesAsync();
            }
            return false;
        }

        public async Task<bool> Update(User Item)
        {
            if (Item != null)
            {
                db.Users.AddOrUpdate(Item);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(User _Item)
        {
            User user = await GetById(_Item.Id);
            if (user != null)
            {
                user.IsDeleted = true;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<User> ValidateUser(string _userName , string _password)
        {
            if (await IsEmpty())
            {
                throw new Exception("No Record in Database");
            }
            User user =await (from u in db.Users
                        where u.UserName == _userName && u.Password == _password
                        select u).AsNoTracking().FirstOrDefaultAsync();
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User Not Found");
            }
        }
        public async Task<bool> IsEmpty()
        {
            List<User> users = await GetAll();
            bool user = users.Any();
            return !user; //if true table is empty
        }
        public async Task<User> GetByRecoveryWord(string _recoverWord)
        {
            User user= await db.Users.AsNoTracking().Where(x => x.RecoverWord == _recoverWord).FirstOrDefaultAsync();
            if (user != null) return user;
            return null;
        }
        public async Task ChangePassword(int _id, string _password)
        {
            var user =await db.Users.FindAsync(_id);
            if (user != null) 
            {
                user.Password = _password;
                await db.SaveChangesAsync();
            }
        }
        //public async Task AddTempUser()
        //{

        //}

    }
}
