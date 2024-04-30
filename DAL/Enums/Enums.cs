using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Enums
{
    internal enum Screen
    {
        User=0,
        Permission=1,
        Client=2,
        Company=3,
        Inspection=4,
        Quotation=5,
        Payment=6
    }

    internal enum UserBehivour
    {
        New=0,
        Save=1,
        Edit=2, 
        Delete=3,
        Restored=4
    }
}
