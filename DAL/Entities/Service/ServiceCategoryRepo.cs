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
    public class ServiceCategoryRepo:IRepo<ServiceCategory>
    {
        ApplicationDB DB;
        public ServiceCategoryRepo() 
        {
            DB = new ApplicationDB();
        }
        public ServiceCategoryRepo(ApplicationDB DB)
        {
            this.DB = DB;
        }
        public async Task<List<ServiceCategory>> GetAll()
        {

            var serviceCategories = await DB.ServiceCategories.AsNoTracking().ToListAsync();
            return serviceCategories;
        }
        public async Task<ServiceCategory> GetById(int id)
        {
            var serviceCategory = await DB.ServiceCategories.FirstOrDefaultAsync();
            if (serviceCategory != null)
            {
                return serviceCategory;
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
                ServiceCategory serviceCategory = await DB.ServiceCategories.AsNoTracking().Where(user => user.Id == id).FirstOrDefaultAsync();
                if (serviceCategory != null)
                {
                    DB.ServiceCategories.Remove(serviceCategory);
                    await DB.SaveChangesAsync();
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
        public async Task<bool> Add(ServiceCategory Item)
        {
            if (Item != null)
            {
                DB.ServiceCategories.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(ServiceCategory Item)
        {
            if (Item != null)
            {
                DB.ServiceCategories.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(ServiceCategory _Item)
        {
            ServiceCategory serviceCategory= await GetById(_Item.Id);
            if (serviceCategory != null)
            {
                DB.ServiceCategories.Remove(serviceCategory);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<ServiceCategory> serviceCategories = await GetAll();
            bool serviceCategory = serviceCategories.Any();
            return !serviceCategory; //if true table is empty
        }

    }
}
