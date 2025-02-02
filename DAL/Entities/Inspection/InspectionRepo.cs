using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using ColorOasisSystem.GUI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class InspectionRepo:IRepo<Inspection>
    {
        ApplicationDB DB;
        public InspectionRepo() 
        { 
            DB = new ApplicationDB();
        }
        public InspectionRepo(ApplicationDB db)
        {
            DB = db;
        }
        public async Task<List<Inspection>> GetAll()
        {
            var Clients = await DB.Inspections.Where(client => client.IsDeleted == false).ToListAsync();
            return Clients;
        }
        public async Task<Inspection> GetById(int id)
        {
            var inspection = await DB.Inspections.Where(user => user.IsDeleted == false && user.Id == id).FirstOrDefaultAsync();
            if (inspection != null)
            {
                return inspection;
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
                Inspection inspection = await DB.Inspections.Where(I => I.Id == id).FirstOrDefaultAsync();
                if (inspection != null)
                {
                    inspection.IsDeleted = true;
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
        public async Task<bool> Add(Inspection Item)
        {
            if (Item != null)
            {
                DB.Inspections.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(Inspection Item)
        {
            if (Item != null)
            {
                DB.Inspections.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(Inspection inspection)
        {
            if (inspection != null)
            {
                DB.Inspections.Remove(inspection);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<Inspection> inspections = await GetAll();
            bool inspection = inspections.Any();
            return !inspection; //if true table is empty
        }
    }
}
