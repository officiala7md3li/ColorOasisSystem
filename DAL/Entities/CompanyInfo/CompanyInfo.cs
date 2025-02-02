using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyTRN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public string CompanyAccountIban { get; set; }
        public string CompanyAccountHolder { get; set; }
        public string BIC {  get; set; }
        public string BusinessAddress { get; set; }
        public string Currency { get; set; } = "AED";
        public string CurrencyAr { get; set; } = "د.إ";
    }
}