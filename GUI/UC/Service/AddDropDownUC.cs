using ColorOasisSystem.Entities;
using ColorOasisSystem.Entities.Interfaces;
using ColorOasisSystem.Enums;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceType = ColorOasisSystem.Entities.ServiceType;

namespace ColorOasisSystem.GUI.UC
{
    public partial class AddDropDownUC : MasterUC 
    {
        ServiceTypeRepo ClassRepo;
        ServiceCategoryRepo ClassRepo1;
        AddDropDown AddDropDowntype { get; set; }
        public AddDropDownUC()
        {
            InitializeComponent();
        }

        public void SelectType(AddDropDown SelectDropDown)
        {
            AddDropDowntype = SelectDropDown;
            LogoLabel = SelectDropDown == AddDropDown.ItemType ? "نوع الخدمه" : "فئه الخدمه";
            Label1.Text = SelectDropDown == AddDropDown.ItemType ? "اسم نوع الخدمه" : "اسم فئه الخدمه";
            New_Name_TxtBox.PlaceholderText = SelectDropDown == AddDropDown.ItemType ? " ادخل اسم نوع الخدمه" : "ادخل اسم فئه الخدمه";
            Point point = new Point();
            point = Label1.Location;
            Label1.Location = new Point(New_Name_TxtBox.Right - Label1.Width, point.Y);
            if (SelectDropDown == AddDropDown.ItemType)
            {
                ClassRepo = new ServiceTypeRepo();
            }
            else
            {

                ClassRepo1 = new ServiceCategoryRepo();
            }
        }
        public override void NewDataAsync()
        {
            base.NewDataAsync();
        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateString(New_Name_TxtBox, $"يرجى إدخال {LogoLabel}")) return;
            try
            {
                if (AddDropDowntype==AddDropDown.ItemType)
                {
                    ServiceType serviceType = new ServiceType();
                    serviceType.Name=New_Name_TxtBox.Text;
                    serviceType.NameEn = New_NameEn_TxtBox.Text;
                    bool isSuccess=await ClassRepo.Add(serviceType);
                    if (isSuccess)
                    {
                        popMessage($"تمت اضافه النوع {serviceType.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    }

                }
                else
                {
                    ServiceCategory serviceCategory = new ServiceCategory();
                    serviceCategory.Name = New_Name_TxtBox.Text;
                    serviceCategory.NameEn = New_NameEn_TxtBox.Text;
                    bool isSuccess = await ClassRepo1.Add(serviceCategory);
                    if (isSuccess)
                    {
                        popMessage($"تمت اضافه النوع {serviceCategory.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        await base.SaveDataAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        public override async Task EditData()
        {
            if (!ValidateString(New_Name_TxtBox, $"يرجى إدخال {LogoLabel}")) return;
            try
            {
                if (AddDropDowntype == AddDropDown.ItemType)
                {
                    ServiceType serviceType = new ServiceType();
                    serviceType.Id = Convert.ToInt32(ID_TxtBox.Text);
                    serviceType.Name = New_Name_TxtBox.Text;
                    serviceType.NameEn = New_NameEn_TxtBox.Text;
                    bool isSuccess = await ClassRepo.Update(serviceType);
                    if (isSuccess)
                    {
                        popMessage($"تمت تعديل النوع {serviceType.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    }

                }
                else
                {
                    ServiceCategory serviceCategory = new ServiceCategory();
                    serviceCategory.Id = Convert.ToInt32(ID_TxtBox.Text);
                    serviceCategory.Name = New_Name_TxtBox.Text;
                    serviceCategory.NameEn = New_NameEn_TxtBox.Text;
                    bool isSuccess = await ClassRepo1.Update(serviceCategory);
                    if (isSuccess)
                    {
                        popMessage($"تمت تعديل النوع {serviceCategory.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
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
                        if (AddDropDowntype == AddDropDown.ItemType)
                        {
                            ServiceType serviceType = new ServiceType();
                            serviceType.Id = Convert.ToInt32(ID_TxtBox.Text);
                            serviceType.Name = New_Name_TxtBox.Text;
                            serviceType.NameEn = New_NameEn_TxtBox.Text;
                            bool isSuccess = await ClassRepo.Delete(serviceType);
                            if (isSuccess)
                            {
                                popMessage($"تمت حذف النوع {serviceType.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            }

                        }
                        else
                        {
                            ServiceCategory serviceCategory = new ServiceCategory();
                            serviceCategory.Id = Convert.ToInt32(ID_TxtBox.Text);
                            serviceCategory.Name = New_Name_TxtBox.Text;
                            serviceCategory.NameEn = New_NameEn_TxtBox.Text;
                            bool isSuccess = await ClassRepo1.Delete(serviceCategory);
                            if (isSuccess)
                            {
                                popMessage($"تمت حذف النوع {serviceCategory.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            }
                        }
                        await base.DeleteData();
                    }

                }
            }

        }
        public override async Task Search_Data()
        {
            //todo:Change it for all screens
            List<string> list = new List<string>() { "#", "الاسم","الاسم بالانجليزيه" };
            List<string> Properties = new List<string>() { "ID", "Name","NameEn" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            dynamic values;
             if(AddDropDowntype == AddDropDown.ItemType) 
            {
                values=await ClassRepo.GetAll();
                new WaitLoaderForm(frm, new SreachForm<ServiceType>(this,values , dataSource), 10);
            } 
            else 
            {
                values=await ClassRepo1.GetAll();
                new WaitLoaderForm(frm, new SreachForm<ServiceCategory>(this, values, dataSource), 10);
            }

            await base.Search_Data();
        }
        public override async Task LoadData(int ItemID)
        {
            if (AddDropDowntype == AddDropDown.ItemType)
            {
                ServiceType serviceType = await ClassRepo.GetById(ItemID);
                ID_TxtBox.Text = serviceType.Id.ToString();
                New_Name_TxtBox.Text = serviceType.Name.ToString();
                New_NameEn_TxtBox.Text = serviceType.NameEn.ToString();
                await base.LoadData(ItemID);
            }
            else
            {
                ServiceCategory serviceCategory = await ClassRepo1.GetById(ItemID);
                ID_TxtBox.Text = serviceCategory.Id.ToString();
                New_Name_TxtBox.Text = serviceCategory.Name.ToString();
                New_NameEn_TxtBox.Text = serviceCategory.NameEn.ToString();
                await base.LoadData(ItemID);
            }
        }
    }
}
