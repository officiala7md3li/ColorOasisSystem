using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities.Interfaces
{
    public interface IPermissions
    {
        bool Lock { get; set; }
        bool AddNew { get; set; }
        bool Edit { get; set; }
        bool Delete { get; set; }
        bool Retrive { get; set; }
    }
}
