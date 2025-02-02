using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class PermissionProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Permission> PermissionProfiles { get;}
        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDeleted { get; set; }

    }
}
