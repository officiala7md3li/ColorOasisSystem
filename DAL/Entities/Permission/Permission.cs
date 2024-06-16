using ColorOasisSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Entities
{
    public class Permission : IPermissions
    {
        public bool Lock { get; set; }
        public bool AddNew { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool Retrive { get; set; }
        public Permission() 
        {
            Lock = false;
            AddNew = false;
            Edit = false;
            Delete = false;
            Retrive = false;

        }
        public Permission(bool isAll) 
        {
            Lock = isAll;
            AddNew= isAll;
            Edit= isAll;
            Delete= isAll;
            Retrive= isAll;
        }
        public Permission(bool _lock,bool _addnew,bool _edit,bool _delete,bool _retrive)
        {
            Lock = _lock;
            AddNew = _addnew;
            Edit = _edit;
            Delete = _delete;
            Retrive = _retrive;
        }

    }


}
