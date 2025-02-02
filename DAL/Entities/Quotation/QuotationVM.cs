using ColorOasisSystem.Entities;
using ColorOasisSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class QuotationVM
    {
        public string Code { get; set; }
        public string User { get; set; }
        public string DateTime { get; set; }
        public bool IsComapany { get; set; }
        public string TypeofUnit { get; set; }
        public int RoomsNo { get; set; }
        //Building Number
        public string UnitCode { get; set; }
        public string POBox { get; set; }
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public string ClientPhoneNo { get; set; }
        public string ClientTRN { get; set; }
        public string ClientCompany {  get; set; }
        //Pricing
        public decimal VAT { get; set; }
        public decimal SubTotal { get; set; }
        public decimal InvoiceDiscount { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Remain { get; set; }
        //Details
        public int ServiceIndex { get; set; }
        public string ServiceName { get; set; }
        public decimal Qty { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal MaximumPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public decimal Price { get; set; }
        //company 
        public Image CompanyLogo { get; set; }
        //public string CompanyName { get; set;}
        //public string CompanyDescription { get; set;}
        //public string CompanyPhoneNo { get; set; }
        //public string CompanyTRN { get;set; }
        public string Note {  get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string Region { get; set; }
        //public string PostalCode { get; set; }
    }
}
