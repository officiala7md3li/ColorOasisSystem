using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class UserPermissions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Permission PermissionOfUser {  get; set; }
        public Permission PermissionOfPermission { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDeleted { get; set; }
    }
}
