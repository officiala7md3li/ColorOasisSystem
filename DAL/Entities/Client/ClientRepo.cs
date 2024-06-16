using ColorOasisSystem.Entities.Interfaces;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class ClientRepo:IRepo<Client>
    {
        ApplicationDB DB;
        public ClientRepo() 
        { 
            DB = new ApplicationDB();
        }
        public ClientRepo(ApplicationDB DB)
        {
            this.DB = DB;
        }
        public async Task<List<Client>>GetAll()
        {
            var Clients = await DB.Clients.Where(client => client.IsDeleted == false).AsNoTracking().ToListAsync();
            return Clients;
        }

        public async Task<Client> GetById(int id)
        {
            var client = await DB.Clients.Where(user => user.IsDeleted == false && user.Id == id).FirstOrDefaultAsync();
            if (client != null)
            {
                return client;
            }
            return null;
        }
        public async Task<Client> GetByName(string CompanyName)
        {
            var client = await DB.Clients.Where(Client => Client.IsDeleted == false && Client.Name == CompanyName).FirstOrDefaultAsync();
            if (client != null)
            {
                return client;
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
                Client Client = await DB.Clients.AsNoTracking().Where(client => client.Id == id).FirstOrDefaultAsync();
                if (Client != null)
                {
                    Client.IsDeleted = true;
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
        public async Task<bool> Add(Client Item)
        {
            if (Item != null)
            {
                DB.Clients.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(Client Item)
        {
            if (Item != null)
            {
                DB.Clients.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(Client Client)
        {
            if (Client != null)
            {
                Client.IsDeleted = true;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<Client> clients = await GetAll();
            bool client = clients.Any();
            return !client; //if true table is empty
        }
    }
}
