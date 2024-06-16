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
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsComapany { get; set; }
        public string TypeofUnit { get; set; }
        public string RoomsNo { get; set; }
        public string UnitCode { get; set; }
        public string POBox { get; set; }
        //Pricing
        public decimal VAT { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        //internal Log
        public string AddedBy { get; set; }
        public string EditedBy { get; set; }
        public string DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
