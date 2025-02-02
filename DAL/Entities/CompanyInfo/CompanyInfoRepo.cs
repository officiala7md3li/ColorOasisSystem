using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.DAL.Entities
{
    public class CompanyInfoRepo
    {
        ApplicationDB DB;
        public CompanyInfoRepo() 
        {
            DB=new ApplicationDB();
        }
        public CompanyInfoRepo(ApplicationDB db)
        {
            DB=db;
        }
        public async Task<CompanyInfo> GetCompanyInfo()
        {
            CompanyInfo companyInfo = await DB.CompanyInfo.FirstOrDefaultAsync();
            return companyInfo;
        }
        public async Task<bool> AddorUpdate(CompanyInfo companyInfo)
        {
            if (companyInfo != null)
            {
                DB.CompanyInfo.AddOrUpdate(companyInfo);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            bool IsEmpty=await DB.CompanyInfo.AnyAsync();
            return !IsEmpty;//if true table is empty
        }
    }
}
