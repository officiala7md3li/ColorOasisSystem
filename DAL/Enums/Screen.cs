using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.DAL.Enums
{
    public enum ScreenType
    {
        ScreenwithAdditional=1,
        ScreenwithoutAdditional=2,
        SecondScreen=3
    }
    [Serializable]
    public enum Screen
    {
        User = 1,
        Permission= 2,
        Settings= 3,
        CompanyInfo= 4,
        ClientSecondUC= 5,
        ClientWorksUC= 6,
        ServiceSecondUC= 7,
        SettingsSecondUC= 8,
        WelcomeUC= 9,
        ServiceType= 10,//AddDropdown
        ServiceCategory= 11,//AddDropdown
        Service= 12,
        Client= 13,
        Company= 14,
        Inspection= 15,
        Quotation= 16,
        PaymentIn= 17,//client
        PaymentOut= 18,//Company
        ClientTransaction= 19,
        CompanyTransaction= 20,
    }
    public class ScreenName
    {
        public Screen ScreenId;
        public string Name {  get; set; }
        public int Id { get => (int)ScreenId; }
    }
    static public class Screens
    {
        static public ScreenName[] Screen =
        {
            new ScreenName { ScreenId= Enums.Screen.User, Name="المستخدم"},
            new ScreenName { ScreenId= Enums.Screen.Permission, Name="الصلاحيات"},
            new ScreenName { ScreenId= Enums.Screen.Settings, Name="الاعدادات"},
            new ScreenName { ScreenId= Enums.Screen.CompanyInfo, Name="معلومات الشركه"},
            new ScreenName { ScreenId= Enums.Screen.ClientSecondUC, Name="شاشه العملاء الرئيسيه"},
            new ScreenName { ScreenId= Enums.Screen.ClientWorksUC, Name="شاشه اعمال العملاء الرئيسيه"},
            new ScreenName { ScreenId= Enums.Screen.ServiceSecondUC, Name="شاشه الخدمات الرئيسيه"},
            new ScreenName { ScreenId= Enums.Screen.SettingsSecondUC, Name="شاشه الاعدادات الرئيسيه"},
            new ScreenName { ScreenId= Enums.Screen.WelcomeUC, Name="الشاشه الرئيسيه"},
            new ScreenName { ScreenId= Enums.Screen.ServiceType, Name="نوع الخدمه"},
            new ScreenName { ScreenId= Enums.Screen.ServiceCategory, Name="تصنيف الخدمه"},
            new ScreenName { ScreenId= Enums.Screen.Service, Name="الخدمات"},
            new ScreenName { ScreenId= Enums.Screen.Client, Name="العملاء"},
            new ScreenName { ScreenId= Enums.Screen.Company, Name="الشركات"},
            new ScreenName { ScreenId= Enums.Screen.Inspection, Name="التوصيف"},
            new ScreenName { ScreenId= Enums.Screen.Quotation, Name="التسعير"},
            new ScreenName { ScreenId= Enums.Screen.PaymentIn, Name="المقبوضات"},
            new ScreenName { ScreenId= Enums.Screen.PaymentOut, Name="المدفوعات"},
            new ScreenName { ScreenId= Enums.Screen.ClientTransaction, Name="حركات العملاء"},
            new ScreenName { ScreenId= Enums.Screen.CompanyTransaction, Name="حركات الشركات"}
        };
        static public ScreenName[] ScreenEn =
{
            new ScreenName { ScreenId= Enums.Screen.User, Name="User"},
            new ScreenName { ScreenId= Enums.Screen.Permission, Name="Permission"},
            new ScreenName { ScreenId= Enums.Screen.Settings, Name="Settings"},
            new ScreenName { ScreenId= Enums.Screen.CompanyInfo, Name="Company Info"},
            new ScreenName { ScreenId= Enums.Screen.ClientSecondUC, Name="Client Main Menu"},
            new ScreenName { ScreenId= Enums.Screen.ClientWorksUC, Name="Client Works Main Menu"},
            new ScreenName { ScreenId= Enums.Screen.ServiceSecondUC, Name="Servies Main Menu"},
            new ScreenName { ScreenId= Enums.Screen.SettingsSecondUC, Name="Settings Main Menu"},
            new ScreenName { ScreenId= Enums.Screen.WelcomeUC, Name="Main Menu"},
            new ScreenName { ScreenId= Enums.Screen.ServiceType, Name="Service Type"},
            new ScreenName { ScreenId= Enums.Screen.ServiceCategory, Name="Service Category"},
            new ScreenName { ScreenId= Enums.Screen.Service, Name="Services"},
            new ScreenName { ScreenId= Enums.Screen.Client, Name="Clients"},
            new ScreenName { ScreenId= Enums.Screen.Company, Name="Companies"},
            new ScreenName { ScreenId= Enums.Screen.Inspection, Name="Inspection"},
            new ScreenName { ScreenId= Enums.Screen.Quotation, Name="Quotation"},
            new ScreenName { ScreenId= Enums.Screen.PaymentIn, Name="Payment In"},
            new ScreenName { ScreenId= Enums.Screen.PaymentOut, Name="Payment Out"},
            new ScreenName { ScreenId= Enums.Screen.ClientTransaction, Name="Clients Transactions"},
            new ScreenName { ScreenId= Enums.Screen.CompanyTransaction, Name="Companies Transactions"}
        };
        static public PermissionVisibility[] permissionsVisibility = new PermissionVisibility[]
        {
            new PermissionVisibility{ ScreenId= Enums.Screen.User, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Permission, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Settings, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.CompanyInfo, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.ClientSecondUC, ScreenType=ScreenType.SecondScreen},
            new PermissionVisibility{ ScreenId= Enums.Screen.ClientWorksUC, ScreenType=ScreenType.SecondScreen},
            new PermissionVisibility{ ScreenId= Enums.Screen.ServiceSecondUC, ScreenType=ScreenType.SecondScreen},
            new PermissionVisibility{ ScreenId= Enums.Screen.SettingsSecondUC, ScreenType=ScreenType.SecondScreen},
            new PermissionVisibility{ ScreenId= Enums.Screen.WelcomeUC, ScreenType=ScreenType.SecondScreen},
            new PermissionVisibility{ ScreenId= Enums.Screen.ServiceType, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.ServiceCategory, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Service, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Client, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Company, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Inspection, ScreenType=ScreenType.ScreenwithAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.Quotation, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.PaymentIn, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.PaymentOut, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.ClientTransaction, ScreenType=ScreenType.ScreenwithoutAdditional},
            new PermissionVisibility{ ScreenId= Enums.Screen.CompanyTransaction, ScreenType=ScreenType.ScreenwithoutAdditional},
        };
        static public ScreenType GetScreenType(Screen screenId)
        {
            return permissionsVisibility.ToList().Where(p => p.ScreenId == screenId).FirstOrDefault().ScreenType;
        }
        static public List<ScreenName> GetScreenNames()
        {
            return Screen.ToList();
        }
    }
}

