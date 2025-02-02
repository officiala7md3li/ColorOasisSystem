using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal MaximumPrice { get; set; }
        public string Barcode { get; set; }
        public decimal Discount { get; set; }
        [ForeignKey("ServiceType")]
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        [ForeignKey("ServiceCategory")]
        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public bool IsDeleted { get; set; }
    }
}
