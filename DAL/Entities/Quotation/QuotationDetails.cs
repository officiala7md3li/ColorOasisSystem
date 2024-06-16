using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class QuotationDetails
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }
        public int ServiceId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }   
        public decimal Price { get; set; }
    }
}
