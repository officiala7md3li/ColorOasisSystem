using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    internal class Inspection
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
        public string UnitCode { get; set;}
        public string POBox { get; set; }
        //internal Log
        public string AddedBy { get; set;}
        public string EditedBy { get;set; }
        public string DeletedBy { get; set; }
    }
}
