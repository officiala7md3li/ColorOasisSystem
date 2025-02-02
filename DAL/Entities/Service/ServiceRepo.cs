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
    public class ServiceRepo:IRepo<Service>
    {
        ApplicationDB DB;
        public ServiceRepo() 
        {
            DB=new ApplicationDB();
        }
        public ServiceRepo(ApplicationDB DB)
        {
            this.DB=DB;
        }
        public async Task<List<Service>> GetAll()
        {
            var services = await DB.Services.Where(client => client.IsDeleted == false).ToListAsync();
            return services;
        }
        public async Task<Service> GetById(int id)
        {
            var service = await DB.Services.Where(user => user.IsDeleted == false && user.Id == id).FirstOrDefaultAsync();
            if (service != null)
            {
                return service;
            }
            return null;
        }
        public async Task<List<Service>> SelectListOfServices(string ItemName,int ItemCategory,int ItemType)
        {
            List<Service> service = await GetAll();
            if (!String.IsNullOrEmpty(ItemName))
            {
                service = service.Where(s => s.Name == ItemName).ToList();
            }
            if (ItemCategory > -1)
            {
                service = service.Where(s => s.ServiceCategoryId == ItemCategory).ToList();
            }
            if (ItemType > -1)
            {
                service = service.Where(s => s.ServiceTypeId == ItemType).ToList();
            }
            var result = service.Take(20).ToList();
            if (service != null)
            {
                return service;
            }
            return null;
        }
        public List<Service> SelectListOfServices(string ItemName, int ItemCategory, int ItemType, List<Service> service)
        {
            if (!String.IsNullOrEmpty(ItemName))
            {
                service = service.Where(s => s.Name == ItemName).ToList();
            }
            if (ItemCategory > -1)
            {
                service = service.Where(s => s.ServiceCategoryId == ItemCategory).ToList();
            }
            if (ItemType > -1)
            {
                service = service.Where(s => s.ServiceTypeId == ItemType).ToList();
            }
            var result = service.Take(20).ToList();
            if (service != null)
            {
                return service;
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
                Service service = await DB.Services.Where(client => client.Id == id).FirstOrDefaultAsync();
                if (service != null)
                {
                    service.IsDeleted = true;
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
        public async Task<bool> Add(Service Item)
        {
            if (Item != null)
            {
                DB.Services.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(Service Item)
        {
            if (Item != null)
            {
                DB.Services.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(Service service)
        {
            if (service != null)
            {
                service.IsDeleted = true;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<Service> services = await GetAll();
            bool Service = services.Any();
            return !Service; //if true table is empty
        }

    }
}
