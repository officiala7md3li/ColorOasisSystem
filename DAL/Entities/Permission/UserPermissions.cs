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
        public string NameEn { get; set; }
        public int Selection {  get; set; }
        public Permission UserUCPermission {  get; set; }
        public Permission PermissionUCPermission { get; set; }
        public Permission SettingsUCPermission { get; set; }
        public Permission CompanyInfoUCPermission { get; set; }
        public Permission ClientSecondUCPermission { get; set; }
        public Permission ClientWorkUCPermission { get; set; }
        public Permission ServiceSecondUCPermission { get; set; }
        public Permission SettingsSecondUCPermission { get; set; }
        public Permission WelcomeUCPermission { get; set; }
        public Permission ServiceTypeUCPermission { get; set; }
        public Permission ServiceCategoryUCPermission { get; set; }
        public Permission ServiceUCPermission { get; set; }
        public Permission ClientUCPermission { get; set; }
        public Permission CompanyUCPermission { get; set; }
        public Permission InspectionUCPermission { get; set; }
        public Permission QuotationUCPermission { get; set; }
        public Permission ClientPaymentUCPermission { get; set; }
        public Permission CompanyPaymentUCPermission { get; set; }
        public Permission ClientTransUCPermission { get; set; }
        public Permission CompanyTransUCPermission { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDeleted { get; set; }
        public UserPermissions(int id, string name,string nameEn, Permission userUCPermission, Permission permissionUCPermission, Permission settingsUCPermission, Permission companyInfoUCPermission, Permission clientSecondUCPermission, Permission clientWorkUCPermission, Permission serviceSecondUCPermission, Permission settingsSecondUCPermission, Permission welcomeUCPermission, Permission serviceTypeUCPermission, Permission serviceCategoryUCPermission, Permission serviceUCPermission, Permission clientUCPermission, Permission companyUCPermission, Permission inspectionUCPermission, Permission quotationUCPermission, Permission clientPaymentUCPermission, Permission companyPaymentUCPermission, Permission clientTransUCPermission, Permission companyTransUCPermission, bool isAdmin, bool isLocked, bool isDeleted)
        {
            Id = id;
            Name = name;
            NameEn = nameEn;
            UserUCPermission = userUCPermission;
            PermissionUCPermission = permissionUCPermission;
            SettingsUCPermission = settingsUCPermission;
            CompanyInfoUCPermission = companyInfoUCPermission;
            ClientSecondUCPermission = clientSecondUCPermission;
            ClientWorkUCPermission = clientWorkUCPermission;
            ServiceSecondUCPermission = serviceSecondUCPermission;
            SettingsSecondUCPermission = settingsSecondUCPermission;
            WelcomeUCPermission = welcomeUCPermission;
            ServiceTypeUCPermission = serviceTypeUCPermission;
            ServiceCategoryUCPermission = serviceCategoryUCPermission;
            ServiceUCPermission = serviceUCPermission;
            ClientUCPermission = clientUCPermission;
            CompanyUCPermission = companyUCPermission;
            InspectionUCPermission = inspectionUCPermission;
            QuotationUCPermission = quotationUCPermission;
            ClientPaymentUCPermission = clientPaymentUCPermission;
            CompanyPaymentUCPermission = companyPaymentUCPermission;
            ClientTransUCPermission = clientTransUCPermission;
            CompanyTransUCPermission = companyTransUCPermission;
            IsAdmin = isAdmin;
            IsLocked = isLocked;
            IsDeleted = isDeleted;
        }
        public UserPermissions()
        {
            Id = 0;
            Name = "";
            NameEn = "";
            UserUCPermission = new Permission(false) ;
            PermissionUCPermission = new Permission(false);
            SettingsUCPermission = new Permission(false);
            CompanyInfoUCPermission = new Permission(false);
            ClientSecondUCPermission = new Permission(true);
            ClientWorkUCPermission = new Permission(true);
            ServiceSecondUCPermission = new Permission(true);
            SettingsSecondUCPermission = new Permission(true);
            WelcomeUCPermission = new Permission(true);
            ServiceTypeUCPermission = new Permission(false);
            ServiceCategoryUCPermission = new Permission(false);
            ServiceUCPermission = new Permission(false);
            ClientUCPermission = new Permission(false);
            CompanyUCPermission = new Permission(false);
            InspectionUCPermission = new Permission(false);
            QuotationUCPermission = new Permission(false);
            ClientPaymentUCPermission = new Permission(false);
            CompanyPaymentUCPermission = new Permission(false);
            ClientTransUCPermission = new Permission(false);
            CompanyTransUCPermission = new Permission(false);
            IsAdmin = false;
            IsLocked = false;
            IsDeleted = false;
        }
        public UserPermissions(string name)
        {
            Id = 0;
            Name = name;
            NameEn = name;
            UserUCPermission = new Permission(true);
            PermissionUCPermission = new Permission(true);
            SettingsUCPermission = new Permission(true);
            CompanyInfoUCPermission = new Permission(true);
            ClientSecondUCPermission = new Permission(true);
            ClientWorkUCPermission = new Permission(true);
            ServiceSecondUCPermission = new Permission(true);
            SettingsSecondUCPermission = new Permission(true);
            WelcomeUCPermission = new Permission(true);
            ServiceTypeUCPermission = new Permission(true);
            ServiceCategoryUCPermission = new Permission(true);
            ServiceUCPermission = new Permission(true);
            ClientUCPermission = new Permission(true);
            CompanyUCPermission = new Permission(true);
            InspectionUCPermission = new Permission(true);
            QuotationUCPermission = new Permission(true);
            ClientPaymentUCPermission = new Permission(true);
            CompanyPaymentUCPermission = new Permission(true);
            ClientTransUCPermission = new Permission(true);
            CompanyTransUCPermission = new Permission(true);
            IsAdmin = true;
            IsLocked = false;
            IsDeleted = false;
        }

    }
}
