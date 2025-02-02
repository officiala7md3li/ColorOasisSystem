using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Enums
{

    public enum UserBehivour
    {
        New=0,
        Save=1,
        Edit=2, 
        Delete=3,
        Additional=4,
        Print=5
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
