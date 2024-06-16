using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using ColorOasisSystem.GUI.UC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    internal class QuotationRepo:IRepo<Quotation>
    {
        ApplicationDB DB;
        public QuotationRepo() 
        { 
            DB = new ApplicationDB();
        }
        public QuotationRepo(ApplicationDB dB)
        {
            DB = dB;
        }
        public async Task<List<Quotation>> GetAll()
        {
            List<Quotation> Quotations = await DB.Quotations.Where(quote=> quote.IsDeleted==false).AsNoTracking().ToListAsync();
            return Quotations;
        }
        public async Task<Quotation> GetById(int id)
        {
            Quotation Quotation = await DB.Quotations.Where(quote => quote.IsDeleted == false && quote.Id==id).FirstOrDefaultAsync();
            if (Quotation != null)
            {
                return Quotation;
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
                Quotation quotation = await DB.Quotations.AsNoTracking().Where(quote => quote.Id == id).FirstOrDefaultAsync();
                if (quotation != null)
                {
                    quotation.IsDeleted = true;
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
        public async Task<bool> Add(Quotation Item)
        {
            if (await GetById(Item.Id) != null)
            {
                DB.Quotations.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
            }
            return false;
        }
        public async Task<bool> Update(Quotation Item)
        {
            if(Item!= null)
            {
                DB.Quotations.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(Quotation quotation)
        { 
            if (quotation != null)
            {
                quotation.IsDeleted = true;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<Quotation> quotations =await GetAll();
            bool Quote = quotations.Any();
            return !Quote; //if true table is empty
        }
    }
}
