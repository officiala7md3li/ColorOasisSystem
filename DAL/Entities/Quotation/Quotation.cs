using ColorOasisSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class Quotation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("Inspection")]
        public int InspectionId { get; set; }
        public Inspection Inspection { get; set; }
        public bool IsComapany { get; set; }
        public UnitType TypeofUnit { get; set; } 
        public int RoomsNo { get; set; }
        public string UnitCode { get; set; }
        public string POBox { get; set; }
        public string Note { get; set; } = "";
        //Client
        public ClientType ClientType { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public string ClientPhoneNo { get; set; }
        public string ClientTRN { get; set; }
        //Pricing
        public decimal VAT { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Remain { get; set; }
        //Internal Log
        public string AddedBy { get; set; }
        public string EditedBy { get; set; }
        public string DeletedBy { get; set; }
        public bool IsPaid { get; set; }
        public bool IsConverted { get; set; }
        public bool IsValid { get; set; }
        public bool IsDeleted { get; set; }
    }
}
