using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Enums
{
    public enum Screen
    {
        User=0,
        Permission=1,
        Client=2,
        Company=3,
        Inspection=4,
        Quotation=5,
        Payment=6
    }

    public enum UserBehivour
    {
        New=0,
        Save=1,
        Edit=2, 
        Delete=3,
        Restored=4
    }
    public enum AddDropDown
    {
        ItemType=0,
        ItemCategory=1
    }
    public enum UnitType
    {
        Villa=0,
        Flat=1,
        Other=2
    }
    public enum ClientType
    {
        Customer=0,
        Company=1
    }
    public enum AddNumType
    {
        Qty=0,
        Discount=1,
        Price=2
    }
}
