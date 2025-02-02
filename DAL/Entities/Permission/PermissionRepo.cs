using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public async Task<List<UserPermissions>> GetAll()
        {
            var permissions =await db.UserPermissions.Where(permission=> permission.IsDeleted == false && permission.IsLocked == false).ToListAsync();
            return permissions;
        }
        public async Task<UserPermissions> GetById(int id)
        {
            var permissions = await db.UserPermissions.Where(permission => permission.Id == id&& permission.IsDeleted == false && permission.IsLocked == false).FirstOrDefaultAsync();
            return permissions;
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
                UserPermissions userPermissions=await db.UserPermissions.Where(permission => permission.Id == id && permission.IsDeleted == false &&permission.IsLocked==false).FirstOrDefaultAsync();
                if (userPermissions!=null)
                {
                    userPermissions.IsDeleted=true;
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
        public async Task<bool> Add(UserPermissions userPermission) 
        {
            if (userPermission!=null)
            {
                db.UserPermissions.AddOrUpdate(userPermission);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(UserPermissions userPermission) 
        {
            if (userPermission != null)
            {
                db.UserPermissions.AddOrUpdate(userPermission);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(UserPermissions userPermission)
        {
            if (userPermission != null)
            {
                db.UserPermissions.Remove(userPermission);
                await db.SaveChangesAsync();
                return true;
            }
            return false ;
        }
        public async Task<bool> IsEmpty()
        {
            List<UserPermissions> permissions= await GetAll();
            bool result = permissions.Any();
            return !result; //if true table is empty
        }
        public int GetFirstAdmin()
        {
            return db.UserPermissions.Where(x=>x.IsAdmin==true&&x.IsDeleted==false).FirstOrDefault().Id;
        }
    }
}
