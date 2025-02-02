using ColorOasisSystem.DAL.Entities;
using ColorOasisSystem.Entities;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class CompanyInfoUC : MasterUC
    {
        CompanyInfoRepo CompanyRepo;
        public CompanyInfoUC()
        {
            InitializeComponent();
            CompanyRepo=new CompanyInfoRepo();
            TRNTxtbox.AllowOnlyNumbers();
            CompanyPhoneTxtbox.AllowOnlyNumbers();
            ManagerPhoneTxtbox.AllowOnlyNumbers();
        }
        public async void LoadData()
        {
            if(await CompanyRepo.IsEmpty())
            {
                popMessage("لم تتم اضافه بيانات للشركه بعد",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                return;
            }
            else
            {
                CompanyInfo companyInfo = await CompanyRepo.GetCompanyInfo();
                if(companyInfo != null)
                {
                    ID_TxtBox.Text= companyInfo.Id.ToString();
                    CompanyNameTxtbox.Text = companyInfo.Name;
                    AddressTxtbox.Text = companyInfo.Address;
                    TRNTxtbox.Text= companyInfo.CompanyTRN;
                    CompanyPhoneTxtbox.Text= companyInfo.PhoneNumber;
                    ManagerPhoneTxtbox.Text= companyInfo.ManagerPhoneNumber;
                    BankAccountHolderTxtbox.Text = companyInfo.CompanyAccountHolder;
                    CurrencyTxtbox.Text =companyInfo.Currency;
                    CurrencyArTxtbox.Text =companyInfo.CurrencyAr;
                    CompanyIBANTxtbox.Text= companyInfo.CompanyAccountIban;
                    BusinessAddressTxtbox.Text = companyInfo.BusinessAddress;
                    BICTxtbox.Text = companyInfo.BIC;
                }
            }
        }
        public async override Task SaveDataAsync()
        {
            if (!ValidateString(CompanyNameTxtbox, "يرجى إدخال اسم الشركه")) return;
            if (!ValidateString(AddressTxtbox, "يرجى إدخال عنوان الشركه")) return;
            if (!ValidateString(TRNTxtbox, "يرجى إدخال الرقم الضريبي")) return;
            if (!ValidateString(CompanyPhoneTxtbox, "يرجى إدخال رقم هاتف الشركه")) return;
            if (!ValidateString(ManagerPhoneTxtbox, "يرجى إدخال رقم هاتف مدير الشركه")) return;
            if (!ValidateString(BankAccountHolderTxtbox, "يرجى إدخال اسم الشركه في البنك")) return;
            if (!ValidateString(CurrencyTxtbox, "يرجى إدخال اسم العمله بالانجليزيه")) return;
            if (!ValidateString(CurrencyArTxtbox, "يرجى إدخال اسم العمله بالعربيه")) return;
            if (!ValidateString(CompanyIBANTxtbox, "يرجى إدخال الايبان")) return;
            if (!ValidateString(BusinessAddressTxtbox, "يرجى إدخال عنوان الشركه في البنك")) return;
            if (!ValidateString(BICTxtbox, "يرجى إدخال كود السوفت")) return;
            CompanyInfo companyInfo =new CompanyInfo();
            if (await CompanyRepo.IsEmpty()!=true) companyInfo.Id= Convert.ToInt32(ID_TxtBox.Text);
            companyInfo.Name = CompanyNameTxtbox.Text;
            companyInfo.Address = AddressTxtbox.Text;
            companyInfo.CompanyTRN = TRNTxtbox.Text;
            companyInfo.PhoneNumber = CompanyPhoneTxtbox.Text;
            companyInfo.ManagerPhoneNumber = ManagerPhoneTxtbox.Text;
            companyInfo.CompanyAccountHolder = BankAccountHolderTxtbox.Text;
            companyInfo.Currency = CurrencyTxtbox.Text;
            companyInfo.CurrencyAr = CurrencyArTxtbox.Text;
            companyInfo.CompanyAccountIban = CompanyIBANTxtbox.Text;
            companyInfo.BusinessAddress = BusinessAddressTxtbox.Text;
            companyInfo.BIC = BICTxtbox.Text;
            bool IsSuccess = await CompanyRepo.AddorUpdate(companyInfo);
            if(IsSuccess)popMessage($"تمت اضافه بيانات شركتكم بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

    }
}
