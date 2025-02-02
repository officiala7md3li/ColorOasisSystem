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
    public class ClientPaymentRepo:IRepo<ClientPayment>
    {
        ApplicationDB DB;
        public ClientPaymentRepo() 
        {
            DB = new ApplicationDB();
        }
        public ClientPaymentRepo(ApplicationDB DB)
        {
            this.DB = DB;
        }
        public async Task<List<ClientPayment>> GetAll()
        {
            var clientPayments = await DB.ClientPayments.ToListAsync();
            return clientPayments;
        }
        public async Task<ClientPayment> GetById(int id)
        {
            var clientPayment = await DB.ClientPayments.Where(payment => payment.Id == id).FirstOrDefaultAsync();
            if (clientPayment != null)
            {
                return clientPayment;
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
                ClientPayment clientPayment = await DB.ClientPayments.Where(payment => payment.Id == id).FirstOrDefaultAsync();
                if (clientPayment != null)
                {
                    DB.ClientPayments.Remove(clientPayment);
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
        public async Task<bool> Add(ClientPayment Item)
        {
            if (Item != null)
            {
                DB.ClientPayments.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(ClientPayment Item)
        {
            if (Item != null)
            {
                DB.ClientPayments.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(ClientPayment clientPayment)
        {
            if (clientPayment != null)
            {
                DB.ClientPayments.Remove(clientPayment);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<ClientPayment> clientPayments = await GetAll();
            bool client = clientPayments.Any();
            return !client; //if true table is empty
        }
    }
}
