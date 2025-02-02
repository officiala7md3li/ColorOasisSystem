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
            List<Quotation> Quotations = await DB.Quotations.Where(quote=> quote.IsDeleted==false&& quote.IsValid == true).ToListAsync();
            return Quotations;
        }
        public async Task<Quotation> GetById(int id)
        {
            Quotation Quotation = await DB.Quotations.Where(quote => quote.IsDeleted == false && quote.Id==id && quote.IsValid == true).FirstOrDefaultAsync();
            if (Quotation != null)
            {
                return Quotation;
            }
            return null;
        }
        public async Task<int> GetbySourceId(int sourceId)
        {
            if (sourceId > 0)
            {
                if (await IsEmpty())
                {
                    return 0;
                }
                var quoteId =await  DB.Quotations.Where(quote => quote.IsDeleted == false && quote.InspectionId == sourceId && quote.IsValid)?.FirstOrDefaultAsync();
                return quoteId!=null? quoteId.Id:0;
            }
            else
            {
                return 0;
            }

        }
        public async Task<bool> CloseById(int id)
        { 
            Quotation quotation=await GetById(id);
            if (quotation != null)
            {
                quotation.IsValid = false;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Convert2InvoiceById(int id)
        {
            Quotation quotation = await GetById(id);
            if (quotation != null)
            {
                quotation.IsPaid = true;
                quotation.IsConverted = true;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
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
                Quotation quotation = await DB.Quotations.Where(quote => quote.Id == id && quote.IsValid == true).FirstOrDefaultAsync();
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
            if (Item != null)
            {
                DB.Quotations.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
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
