using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ServiceType = ColorOasisSystem.Entities.ServiceType;

namespace ColorOasisSystem.Entities
{
    public class ServiceTypeRepo:IRepo<ServiceType>
    {
        ApplicationDB DB;
        public ServiceTypeRepo() 
        {
            DB=new ApplicationDB();
        }
        public ServiceTypeRepo(ApplicationDB db)
        {
            DB = db;
        }
        public async Task<List<ServiceType>> GetAll()
        {

            var serviceTypes = await DB.ServiceTypes.ToListAsync();
            return serviceTypes;
        }
        public async Task<ServiceType> GetById(int id)
        {
            var serviceType = await DB.ServiceTypes.FirstOrDefaultAsync();
            if (serviceType != null)
            {
                return serviceType;
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
                ServiceType serviceType = await DB.ServiceTypes.Where(s => s.Id == id).FirstOrDefaultAsync();
                if (serviceType != null)
                {
                    DB.ServiceTypes.Remove(serviceType);
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
        public async Task<bool> Add(ServiceType Item)
        {
            if (Item != null)
            {
                DB.ServiceTypes.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(ServiceType Item)
        {
            if (Item != null)
            {
                DB.ServiceTypes.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(ServiceType _Item)
        {
            ServiceType serviceType = await GetById(_Item.Id);
            if (serviceType != null)
            {
                DB.ServiceTypes.Remove(serviceType);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<ServiceType> ServiceTypes = await GetAll();
            bool ServiceType = ServiceTypes.Any();
            return !ServiceType; //if true table is empty
        }

    }
}
