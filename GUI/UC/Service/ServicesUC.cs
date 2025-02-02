using ColorOasisSystem.DAL.Entities;
using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service = ColorOasisSystem.Entities.Service;

namespace ColorOasisSystem.GUI.UC
{
    public partial class ServicesUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        ServiceRepo ServiceRepo;
        public ServicesUC()
        {
            InitializeComponent();
            ServiceRepo =new Entities.ServiceRepo();
            Buy_Price_Txt.AllowOnlyNumbers();
            Sell_Price_Txt.AllowOnlyNumbers();
            Barcode_Txtbox.AllowOnlyNumbers();
            Discount_Txt.AllowOnlyNumbers();
        }
        public override async void NewDataAsync()
        {
            base.NewDataAsync();
            ServiceCategoryRepo CategoryRepo = new ServiceCategoryRepo();
            List<ServiceCategory> serviceCategories = await CategoryRepo.GetAll();

            ServiceTypeRepo TypeRepo = new ServiceTypeRepo();
            List <ServiceType> serviceTypes=await TypeRepo.GetAll();

            ServiceCategory_ComboBox.DataSource = serviceCategories;
            ServiceCategory_ComboBox.DisplayMember = "Name";
            ServiceCategory_ComboBox.ValueMember = "Id";
            ServiceCategory_ComboBox.SelectedIndex = -1;

            ServiceType_ComboBox.DataSource = serviceTypes;
            ServiceType_ComboBox.DisplayMember = "Name";
            ServiceType_ComboBox.ValueMember = "Id";
            ServiceType_ComboBox.SelectedIndex=-1;

        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateString(Item_Name_Txt, "يرجى إدخال اسم الخدمه")) return;
            if (!ValidateString(Buy_Price_Txt, "يرجى إدخال السعر الاقل")) return;
            if (!ValidateString(Sell_Price_Txt, "يرجى إدخال السعر الاكبر")) return;
            if (!ValidateString(Barcode_Txtbox, "يرجى إدخال رقم الباركود")) return;
            if (!ValidateString(Discount_Txt, "يرجى إدخال قيمه الخصم")) return;
            if (!ValidateString(ServiceType_ComboBox, "يرجى اختيار نوع الخدمه")) return;
            if (!ValidateString(ServiceCategory_ComboBox, "يرجى اختيار فئه الخدمه")) return;
            if (Username_Pic.Image == Username_Pic.InitialImage)
            {
                popMessage("يرجي تغيير الصوره",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,5);
                return;
            }
            try
            {
                Service service = new Service();
                service.Name = Item_Name_Txt.Text;
                service.NameEn = Item_NameEn_Txt.Text;
                service.MinimumPrice=Convert.ToDecimal(Buy_Price_Txt.Text.Trim());
                service.MaximumPrice = Convert.ToDecimal(Sell_Price_Txt.Text.Trim());
                service.Barcode=Barcode_Txtbox.Text;
                service.Discount = Convert.ToDecimal(Discount_Txt.Text.Trim());
                service.Photo = ImageToByteArray(Username_Pic.Image, System.Drawing.Imaging.ImageFormat.Png);
                service.ServiceTypeId = Convert.ToInt32(ServiceType_ComboBox.SelectedValue);
                service.ServiceCategoryId = Convert.ToInt32(ServiceCategory_ComboBox.SelectedValue);
                service.IsDeleted = false;
                bool isSuccess=await ServiceRepo.Add(service);
                if (isSuccess)
                {
                    popMessage($"تمت اضافه الخدمه {service.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    await base.SaveDataAsync();
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
        }
        public override async Task EditData()
        {
            if (!ValidateString(Item_Name_Txt, "يرجى إدخال اسم الخدمه")) return;
            if (!ValidateString(Buy_Price_Txt, "يرجى إدخال السعر الاقل")) return;
            if (!ValidateString(Sell_Price_Txt, "يرجى إدخال السعر الاكبر")) return;
            if (!ValidateString(Barcode_Txtbox, "يرجى إدخال رقم الباركود")) return;
            if (!ValidateString(Discount_Txt, "يرجى إدخال قيمه الخصم")) return;
            if (!ValidateString(ServiceType_ComboBox, "يرجى اختيار نوع الخدمه")) return;
            if (!ValidateString(ServiceCategory_ComboBox, "يرجى اختيار فئه الخدمه")) return;
            if (Username_Pic.Image == Username_Pic.InitialImage)
            {
                popMessage("يرجي تغيير الصوره", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5);
                return;
            }
            try
            {
                Service service = new Service();
                service.Id = Convert.ToInt32(ID_TxtBox.Text);
                service.Name = Item_Name_Txt.Text;
                service.NameEn = Item_NameEn_Txt.Text;
                service.MinimumPrice = Convert.ToDecimal(Buy_Price_Txt.Text.Trim());
                service.MaximumPrice = Convert.ToDecimal(Sell_Price_Txt.Text.Trim());
                service.Barcode = Barcode_Txtbox.Text;
                service.Discount = Convert.ToDecimal(Discount_Txt.Text.Trim());
                service.Photo = ImageToByteArray(Username_Pic.Image, System.Drawing.Imaging.ImageFormat.Png);
                service.ServiceTypeId = Convert.ToInt32(ServiceType_ComboBox.SelectedValue);
                service.ServiceCategoryId = Convert.ToInt32(ServiceCategory_ComboBox.SelectedValue);
                service.IsDeleted = false;
                bool isSuccess = await ServiceRepo.Update(service);
                if (isSuccess)
                {
                    popMessage($"تمت تعديل الخدمه {service.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
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
                        Service service = new Service();
                        service.Id = Convert.ToInt32(ID_TxtBox.Text);
                        service.Name = Item_Name_Txt.Text;
                        service.NameEn = Item_NameEn_Txt.Text;
                        service.MinimumPrice = Convert.ToDecimal(Buy_Price_Txt.Text.Trim());
                        service.MaximumPrice = Convert.ToDecimal(Sell_Price_Txt.Text.Trim());
                        service.Barcode = Barcode_Txtbox.Text;
                        service.Discount = Convert.ToDecimal(Discount_Txt.Text.Trim());
                        service.Photo = ImageToByteArray(Username_Pic.Image, System.Drawing.Imaging.ImageFormat.Png);
                        service.ServiceTypeId = Convert.ToInt32(ServiceType_ComboBox.SelectedValue);
                        service.ServiceCategoryId = Convert.ToInt32(ServiceCategory_ComboBox.SelectedValue);
                        bool isSuccess = await ServiceRepo.Delete(service);
                        if (isSuccess)
                        {
                            popMessage($"تم حذف الخدمه {service.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        }

                        await base.DeleteData();
                    }

                }
            }
        }
        public override async Task Search_Data()
        {
            //todo:Change it for all screens
            List<string> list = new List<string>() { "#", "الاسم","الاسم ج", "الباركود" };
            List<string> Properties = new List<string>() { "ID", "Name","NameEn", "Barcode" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<Service>(this, await ServiceRepo.GetAll(), dataSource), 10);

            await base.Search_Data();
        }
        public override async Task LoadData(int ItemID)
        {
            Service ChosenService = new Service();
            ChosenService = await ServiceRepo.GetById(ItemID);
            ID_TxtBox.Text = ChosenService.Id.ToString();
            Item_Name_Txt.Text = ChosenService.Name;
            Item_NameEn_Txt.Text=ChosenService.NameEn;
            Buy_Price_Txt.Text = ChosenService.MinimumPrice.ToString();
            Sell_Price_Txt.Text = ChosenService.MaximumPrice.ToString();
            Barcode_Txtbox.Text = ChosenService.Barcode;
            Discount_Txt.Text = ChosenService.Discount.ToString();
            Username_Pic.Image =ByteArrayToImage(ChosenService.Photo);
            ServiceType_ComboBox.SelectedValue = ChosenService.ServiceTypeId;
            ServiceCategory_ComboBox.SelectedValue = ChosenService.ServiceCategoryId;
            await base.LoadData(ItemID);
        }

        private void ServicePic_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Image_Capture = this.Username_Pic;
            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.Showing_Page_On_Screen(false, true, "Camera_Shot");
            frm.Refresh();
        }
    }
}
