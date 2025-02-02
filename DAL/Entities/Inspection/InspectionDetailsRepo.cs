using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class InspectionDetailsRepo
    {
        ApplicationDB DB;
        public InspectionDetailsRepo()
        {
            DB = new ApplicationDB();
        }
        public InspectionDetailsRepo(ApplicationDB dB)
        {
            DB = dB;
        }
        public async Task<List<InspectionDetails>> GetAll()
        {
            var InspectionDetails = await DB.InspectionDetails.ToListAsync();
            return InspectionDetails;
        }
        public async Task<List<InspectionDetails>> GetById(int id)
        {
            var InspectionDetails = await DB.InspectionDetails.Where(quote => quote.InspectionId == id).ToListAsync();
            if (InspectionDetails != null)
            {
                return InspectionDetails;
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
                List<InspectionDetails> inspectionDetails = await DB.InspectionDetails.Where(quote => quote.InspectionId == id).ToListAsync();
                if (inspectionDetails != null)
                {
                    DB.InspectionDetails.RemoveRange(inspectionDetails);
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
        public async Task<bool> Add(List<InspectionDetails> Item)
        {
            if (Item != null)
            {
                DB.InspectionDetails.AddRange(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(List<InspectionDetails> Item)
        {
            if (Item != null)
            {
                bool IsSuccess = await DeleteById(Item.FirstOrDefault().InspectionId);
                if (IsSuccess) DB.InspectionDetails.AddRange(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<InspectionDetails> inspectionsDetails = await GetAll();
            bool inspectionDetails = inspectionsDetails.Any();
            return !inspectionDetails; //if true table is empty
        }
    }
}
