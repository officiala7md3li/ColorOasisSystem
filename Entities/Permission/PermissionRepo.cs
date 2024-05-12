using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    internal class PermissionRepo:IRepo<UserPermissions>
    {
        ApplicationDB db;
        public PermissionRepo() 
        { 
            db=new ApplicationDB();
        }
        public PermissionRepo(ApplicationDB db)
        {
            this.db=db;
        }
        public List<UserPermissions> GetAll()
        {
            var permissions =db.UserPermissions.ToList();
            return permissions;
        }
        public UserPermissions GetById(int id)
        {
            var permissions = db.UserPermissions.Where(permission=>permission.Id==id).FirstOrDefault();
            return permissions;
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
                UserPermissions userPermissions=db.UserPermissions.Where(permission => permission.Id == id).FirstOrDefault();
                if (userPermissions!=null)
                {
                    userPermissions.IsDeleted=true;
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
        public bool Add(UserPermissions userPermission) 
        {
            if (GetById(userPermission.Id)!=null)
            {
                db.UserPermissions.AddOrUpdate(userPermission);
                db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public bool Update(UserPermissions userPermission) 
        {
            db.UserPermissions.AddOrUpdate(userPermission);
            return true;
        }
        public bool Delete(UserPermissions userPermission)
        {
            if (GetById(userPermission.Id) != null)
            {
                db.UserPermissions.Remove(userPermission);
                return true;
            }
            return false ;
        }
        public bool IsEmpty()
        {
            return !db.UserPermissions.Any(); //if true table is empty
        }
       
    }
}
