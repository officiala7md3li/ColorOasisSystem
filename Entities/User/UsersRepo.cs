using ColorOasisSystem.Entities.Interfaces;
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
    internal class UserRepo:IRepo<User>
    {
        ApplicationDB db;
        public UserRepo()
        {
            db = new ApplicationDB();
        }
        
        public List<User> GetAll()
        {
            
            var Useres = db.Users.ToList();
            return Useres;
        }
        public User GetById(int id)
        {
            var User = db.Users.Find(id);
            return User;
        }
        public bool DeleteById(int id)
        {
            try
            {
                if (IsEmpty())
                {
                    return false;
                    throw new Exception("No Record in Database");
                }
                User User = db.Users.Where(user=>user.Id==id).FirstOrDefault();
                if (User != null)
                {
                    User.IsDeleted = true;
                    db.SaveChangesAsync();
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
        public bool Add(User Item)
        {
            if (GetById(Item.Id) != null)
            {
                db.Users.Add(Item);
                db.SaveChanges();
            }
            return false;
        }

        public bool Update(User Item)
        {
            db.Users.AddOrUpdate(Item);
            db.SaveChanges();
            return true;
        }
        public bool Delete(User _Item)
        {
            if (GetById(_Item.Id) != null)
            {
                User brnach = db.Users.Find(_Item.Id);
                brnach.IsDeleted = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public User ValidateUser(string _userName , string _password)
        {
            if (IsEmpty())
            {
                throw new Exception("No Record in Database");
            }
            var user = (from u in db.Users
                        where u.UserName == _userName && u.Password == _password
                        select u).FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User Not Found");
            }
        }
        public bool IsEmpty()
        {
            return !db.Users.Any(); //if true table is empty
        }
        public User GetByRecoveryWord(string _recoverWord)
        {
            return db.Users.Select(x=>x).Where(x=>x.RecoverWord == _recoverWord).FirstOrDefault();
        }
        public void ChangePassword(int _id, string _password)
        {
            var user = db.Users.Find(_id);
            user.Password = _password;
            db.SaveChanges();
        }

    }
}
