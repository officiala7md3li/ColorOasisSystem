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
    public class CompanyRepo : IRepo<Company>
    {
        ApplicationDB DB;
        public CompanyRepo()
        {
            DB = new ApplicationDB();
        }
        public CompanyRepo(ApplicationDB db)
        {
            DB = db;
        }
        public async Task<List<Company>> GetAll()
        {
            var Companies = await DB.Companies.Where(company => company.IsDeleted == false).ToListAsync();
            return Companies;
        }
        public async Task<Company> GetById(int id)
        {
            var company = await DB.Companies.Where(Company => Company.IsDeleted == false && Company.Id == id).FirstOrDefaultAsync();
            if (company != null)
            {
                return company;
            }
            return null;
        }
        public async Task<Company> GetByName(string CompanyName)
        {
            var company = await DB.Companies.Where(Company => Company.IsDeleted == false && Company.Name == CompanyName).FirstOrDefaultAsync();
            if (company != null)
            {
                return company;
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
                Company company = await DB.Companies.   Where(Company => Company.Id == id).FirstOrDefaultAsync();
                if (company != null)
                {
                    company.IsDeleted = true;
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
        public async Task<bool> Add(Company Item)
        {
            if (Item != null)
            {
                DB.Companies.Add(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Update(Company Item)
        {
            if (Item != null)
            {
                DB.Companies.AddOrUpdate(Item);
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(Company company)
        {
            if (company != null)
            {
                company.IsDeleted = true;
                await DB.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> IsEmpty()
        {
            List<Company> companies = await GetAll();
            bool company = companies.Any();
            return !company; //if true table is empty
        }

    }
}
