using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using Guna.UI2.WinForms;
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
    public partial class CompanyUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        CompanyRepo ClassRepo;
        public CompanyUC()
        {
            InitializeComponent();
            ClassRepo = new CompanyRepo();
            TRNTxtBox.AllowOnlyNumbers();
            Company_Phone_TxtBox.AllowOnlyNumbers();
        }
        public override async void NewDataAsync()
        {
            base.NewDataAsync();
            ClientRepo clientRepo = new ClientRepo();
            List<Client> clients = await clientRepo.GetAll();
            Dealer_ComboBox.DataSource = clients;
            Dealer_ComboBox.DisplayMember = "Name";
            Dealer_ComboBox.ValueMember = "ID";
        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateString(Company_Name_TxtBox, "يرجى إدخال اسم الشركه")) return;
            if (!ValidateString(Company_Phone_TxtBox, "يرجى إدخال رقم هاتف الشركه")) return;
            if (!ValidateString(Company_Address_TxtBox, "يرجى إدخال عنوان الشركه")) return;
            if (!ValidateString(Dealer_ComboBox, "يرجى إدخال مندوب الشركه")) return;
            try
            {
                Company Company = new Company();
                Company.Name = Company_Name_TxtBox.Text;
                Company.CompanyTRN= TRNTxtBox.Text;
                Company.NameEn = Company_NameEn_TxtBox.Text;
                Company.Phone = Company_Phone_TxtBox.Text;
                Company.Address = Company_Address_TxtBox.Text;
                Company.DealerId = Convert.ToInt32(Dealer_ComboBox.SelectedValue);
                bool isSuccess = await ClassRepo.Add(Company);
                if (isSuccess)
                {
                    popMessage($"تمت اضافه شركه {Company.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    await base.SaveDataAsync();
                }

            }
            catch (Exception ex)
            {
                // Handle the exception
                if (ex.Message == "يجب الالتزام بالقيود الخاصه بالاضافه")
                {
                    // Handle the case where there are no records in the database
                    popMessage("لايوجد مستخدمين سيتم تحويلك لاضافه عميل جديد", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else
                {
                    popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }


                throw;
            }
        }
        public override async Task EditData()
        {
            if (!ValidateString(Company_Name_TxtBox, "يرجى إدخال اسم الشركه")) return;
            if (!ValidateString(Company_Phone_TxtBox, "يرجى إدخال رقم هاتف الشركه")) return;
            if (!ValidateString(Company_Address_TxtBox, "يرجى إدخال عنوان الشركه")) return;
            if (!ValidateString(Dealer_ComboBox, "يرجى إدخال مندوب الشركه")) return;
            try
            {
                Company Company = new Company();
                Company.Id = Convert.ToInt32(ID_TxtBox.Text);
                Company.Name = Company_Name_TxtBox.Text;
                Company.CompanyTRN = TRNTxtBox.Text;
                Company.NameEn = Company_NameEn_TxtBox.Text;
                Company.Phone = Company_Phone_TxtBox.Text;
                Company.Address = Company_Address_TxtBox.Text;
                Company.DealerId = Convert.ToInt32(Dealer_ComboBox.SelectedValue);
                bool isSuccess = await ClassRepo.Update(Company);
                if (isSuccess)
                {
                    popMessage($"تمت تعديل بيانات شركه {Company.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }

            }
            catch (Exception ex)
            {
                // Handle the exception
                if (ex.Message == "يجب الالتزام بالقيود الخاصه بالاضافه")
                {
                    // Handle the case where there are no records in the database
                    popMessage("لايوجد مستخدمين سيتم تحويلك لاضافه عميل جديد", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else
                {
                    popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }


                throw;
            }


            await base.EditData();
        }
        public override async Task DeleteData()
        {
            if (MyHelper.IsFormOpen(typeof(MainMenuForm)))
            {
                MainMenuForm existingForm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                if (existingForm != null)
                {
                    if (existingForm.CustomMessage("هل تريد حذف البيانات؟", "نعم", "لا") == DialogResult.Yes)
                    {
                        Company Company = new Company();
                        Company.Id = Convert.ToInt32(ID_TxtBox.Text);
                        Company.Name = Company_Name_TxtBox.Text;
                        Company.CompanyTRN = TRNTxtBox.Text;
                        Company.NameEn = Company_NameEn_TxtBox.Text;
                        Company.Phone = Company_Phone_TxtBox.Text;
                        Company.Address = Company_Address_TxtBox.Text;
                        Company.DealerId = Convert.ToInt32(Dealer_ComboBox.SelectedValue);
                        bool isSuccess = await ClassRepo.Delete(Company);
                        if (isSuccess)
                        {
                            popMessage($"تم حذف شركه {Company.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        }

                        await base.DeleteData();
                    }

                }
            }

        }
        public override async Task LoadData(int ItemID)
        {
            Company ChosenClient =await ClassRepo.GetById(ItemID); 
            ID_TxtBox.Text = ChosenClient.Id.ToString();
            Company_Name_TxtBox.Text = ChosenClient.Name.ToString();
            TRNTxtBox.Text = ChosenClient.CompanyTRN;
            Company_NameEn_TxtBox.Text= ChosenClient.NameEn;
            Company_Phone_TxtBox.Text = ChosenClient.Phone.ToString();
            Company_Address_TxtBox.Text = ChosenClient.Address.ToString();
            Dealer_ComboBox.SelectedValue=ChosenClient.DealerId;
            ID_TxtBox.Text = ChosenClient.Id.ToString();
            await base.LoadData(ItemID);
        }

        public override async Task Search_Data()
        {
            List<string> list = new List<string>() { "#", "الاسم","الاسم ج", "العنوان", "رقم الهاتف" };
            List<string> Properties = new List<string>() { "ID", "Name","NameEn", "Address", "Phone" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<Company>(this, await ClassRepo.GetAll(), dataSource), 10);
            await base.Search_Data();
        }
    }
}
