using ColorOasisSystem.DAL.Enums;
using ColorOasisSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class UserLog
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        public Screen ScreenId { get; set; }
        public UserBehivour UserBehivour { get; set; }
        public int DocumentId { get; set; }
        public string DocumentCode { get; set; }
        public DateTime DateTime { get; set; }
        public UserLog(int userId,string description,Screen screenId,UserBehivour userBehivour,int documentId,string documentCode)
        {
            UserId = userId;
            Description = description;
            ScreenId = screenId;
            UserBehivour = userBehivour;
            DocumentId = documentId;
            DocumentCode = documentCode;
            DateTime = DateTime.Now;
        }
    }
}
