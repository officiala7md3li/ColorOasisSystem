using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string CompanyTRN { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [ForeignKey("Dealer")]
        public int DealerId { get; set; }
        public Client Dealer { get; set;}
        public bool IsDeleted { get; set; }
    }
}
