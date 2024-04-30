using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    internal class InspectionDetails
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        //todo:Add Service
        public decimal Qty {  get; set; } 
    }
}
