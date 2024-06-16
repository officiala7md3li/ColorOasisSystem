using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class ClientPayment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public bool IsCompany { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public string Statement { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
