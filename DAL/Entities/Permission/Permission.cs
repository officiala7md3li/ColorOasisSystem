using ColorOasisSystem.DAL.Enums;
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
        public bool Additional { get; set; }
        //public int ScreenId { get; set; }
        public Permission() 
        {
            Lock = false;
            AddNew = false;
            Edit = false;
            Delete = false;
            Retrive = false;
            Additional = false;
        }
        public Permission(bool isAll) 
        {
            Lock = isAll;
            AddNew= isAll;
            Edit= isAll;
            Delete= isAll;
            Retrive= isAll;
            Additional = isAll;
        }
        public Permission(bool _lock,bool _addnew,bool _edit,bool _delete,bool _retrive, bool _additional)
        {
            Lock = _lock;
            AddNew = _addnew;
            Edit = _edit;
            Delete = _delete;
            Retrive = _retrive;
            Additional = _additional;
        }

    }
    public class PermissionVisibility
    {
        public Screen ScreenId { get; set; }
        public ScreenType ScreenType { get; set; }
    }

}
