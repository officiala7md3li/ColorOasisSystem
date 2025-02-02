using ColorOasisSystem.Entities;
using ColorOasisSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class Inspection
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime DateTime { get; set; }
        public UnitType TypeofUnit { get; set; }
        public int RoomsNo { get; set; }
        public string UnitCode { get; set;}
        public string POBox { get; set; }
        public ClientType ClientType { get; set; }
        public int ClientId {  get; set; }
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public string ClientPhoneNo { get; set; }
        public string ClientTRN { get; set; }
        //internal Log
        public string AddedBy { get; set;}
        public string EditedBy { get;set; }
        public string DeletedBy { get; set; }
        public bool IsValid { get; set; }
        public bool IsDeleted { get; set; }
    }
}
