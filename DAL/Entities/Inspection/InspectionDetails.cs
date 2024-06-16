using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class InspectionDetails
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal Qty {  get; set; } 
        public decimal MinimumPrice { get; set; }
        public decimal MaximumPrice { get; set; }
        public decimal Discount {  get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public decimal Price { get; set; }
        [ForeignKey("ServiceCategory")]
        public int CategoryId {  get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        [ForeignKey("ServiceType")]
        public int TypeId { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
