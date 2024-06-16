using ColorOasisSystem.Entities;
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
    public class QuotationDetailsRepo
    {
        ApplicationDB DB;
        public QuotationDetailsRepo() 
        { 
            DB = new ApplicationDB();
        }
        public QuotationDetailsRepo(ApplicationDB dB)
        {
            DB = dB;
        }
        public async Task<List<QuotationDetails>> GetAll()
        {
            var QuotationDetails = await DB.QuotationDetails.AsNoTracking().ToListAsync();
            return QuotationDetails;
        }

        public async Task<List<QuotationDetails>> GetById(int id)
        {
            var QuotationDetails = await DB.QuotationDetails.Where(quote => quote.QuoteId == id).ToListAsync();
            if (QuotationDetails != null)
            {
                return QuotationDetails;
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
                List<QuotationDetails> quotationDetails = await DB.QuotationDetails.AsNoTracking().Where(quote => quote.QuoteId == id).ToListAsync();
                if (quotationDetails != null)
                {
                    DB.QuotationDetails.RemoveRange(quotationDetails);
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
        public async Task<bool> Add(List<QuotationDetails> Item)
        {
            if (Item != null)
            {
                DB.QuotationDetails.AddRange(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(List<QuotationDetails> Item)
        {
            if (Item != null)
            {
                bool IsSuccess= await DeleteById(Item.FirstOrDefault().QuoteId);
                if (IsSuccess)DB.QuotationDetails.AddRange(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<QuotationDetails> quotations = await GetAll();
            bool quotation = quotations.Any();
            return !quotation; //if true table is empty
        }

    }
}
