using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorOasisSystem.DAL;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.GUI.Helping_Program;
using ColorOasisSystem.Enums;
using ColorOasisSystem.Helper;
using Microsoft.SqlServer.Management.Sdk.Sfc;
namespace ColorOasisSystem.GUI.UC
{
    public partial class InspectionUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        ServiceRepo ServiceRepo;
        ServiceCategoryRepo CategoryRepo;
        ServiceTypeRepo TypeRepo;
        ClientRepo ClientRepo;
        CompanyRepo CompanyRepo;
        InspectionRepo InspectionRepo;
        InspectionDetailsRepo InspectionDetailsRepo;
        List<Service > Services;
        public InspectionUC()
        {
            InitializeComponent();
            DGV_Search.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(216, 179, 103);
            RemoveItem.DefaultCellStyle.BackColor = Color.FromArgb(220, 117, 93);//227, 99, 89
            RemoveItem.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 99, 89);
            RemoveItem.CellTemplate.Style.BackColor=Color.FromArgb(228, 159, 115);

            PoBoxTxtBox.AllowOnlyNumbers();
            UnitRoomsNoTxtbox.AllowOnlyNumbers();
            ClientTRNTxtBox.AllowOnlyNumbers();

            ServiceRepo = new ServiceRepo();
            CategoryRepo = new ServiceCategoryRepo();
            TypeRepo = new ServiceTypeRepo();
            ClientRepo = new ClientRepo();
            CompanyRepo = new CompanyRepo();
            InspectionRepo = new InspectionRepo();
            InspectionDetailsRepo=new InspectionDetailsRepo();
            Services = new List<Service>();
        }
        public async override void NewDataAsync()
        {
            base.NewDataAsync();
            Services = await ServiceRepo.GetAll();
            Item_Name_TxtBox.AutoCompleteCustomSource.Clear();
            Item_Name_TxtBox.AutoCompleteCustomSource.AddRange(Services.Select(service => service.Name).ToArray());

            List<ServiceCategory> serviceCategories = await CategoryRepo.GetAll();

            List<ServiceType> serviceTypes = await TypeRepo.GetAll();

            ServiceCategory_ComboBox.DataSource = null;
            ServiceCategory_ComboBox.Items.Clear();
            ServiceCategory_ComboBox.DataSource = serviceCategories;
            ServiceCategory_ComboBox.DisplayMember = "Name";
            ServiceCategory_ComboBox.ValueMember = "Id";
            ServiceCategory_ComboBox.SelectedIndex = -1;

            ServiceType_ComboBox.DataSource = null;
            ServiceType_ComboBox.Items.Clear();
            ServiceType_ComboBox.DataSource = serviceTypes;
            ServiceType_ComboBox.DisplayMember = "Name";
            ServiceType_ComboBox.ValueMember = "Id";
            ServiceType_ComboBox.SelectedIndex = -1;
            IdTextBox.Clear();
            UnitTypeComboBox.SelectedIndex=-1;
            UnitRoomsNoTxtbox.Clear();
            UnitCodeTxtBox.Clear();
            PoBoxTxtBox.Clear();
            ClientTypeComboBox.SelectedIndex = -1;
            ClientIdTxtBox.Clear();
            ClientNameTxtBox.Clear();
            ClientLocationTxtBox.Clear();
            ClientPhoneTxtBox.Clear();
            ClientTRNTxtBox.Clear();
            DGV_Search.Rows.Clear();

        }

        private async void Search_Items_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                RoundedFLowLayoutPanel1.Height = SiticonePanel1.Height;
                panel2.Dock= DockStyle.None;
                int cat = ServiceCategory_ComboBox.SelectedValue == null ? -1 : (int)ServiceCategory_ComboBox.SelectedValue;
                int type = ServiceType_ComboBox.SelectedValue == null ? -1 : (int)ServiceType_ComboBox.SelectedValue;
                List<Service> services = await SideBarLoadItems(Item_Name_TxtBox.Text.Trim(), cat, type);
                if (services != null)
                {
                    CreateItemsOnFLP(services);
                }
                else
                {
                    popMessage("There's no items for the selected values", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    RoundedFLowLayoutPanel1.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        public async Task<List<Service>> SideBarLoadItems(string ItemName,int ItemCategory,int ItemType )
        {
            List<Service> services = new List<Service>();
            services = ServiceRepo.SelectListOfServices(ItemName, ItemCategory, ItemType,Services);
            return services;
        }
        public void CreateItemsOnFLP(List<Service> services)
        {
            RoundedFLowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                Service service = services[i];
                var Pnl = new Guna.UI2.WinForms.Guna2CustomGradientPanel()
                {
                    Size = new Size(140, 150),
                    BorderRadius = 10,
                    BackColor = Color.Transparent
                };
                // Set the custom tag with additional properties
                var customTag = new CustomTag
                {
                    Id = service.Id,
                    obj = service
                };
                var Pic_item = new A7MD_Library.Pictures.AImageButton()
                {
                    Size = new Size(90, 90),
                    BackColor = Color.Transparent
                };
                Image ServiceImage = ByteArrayToImage(service.Photo);
                if (ServiceImage != null)
                {
                    Pic_item.Image = ServiceImage;
                }
                else
                {
                    Pic_item.Image = Pic_item.InitialImage;
                }
                Pic_item.Click += new EventHandler(QuickSearchbtn_Click);
                Pnl.Controls.Add(Pic_item);
                Pic_item.Tag = customTag;
                Pic_item.Location = new Point(25, 24);

                var Add_Pic = new A7MD_Library.Pictures.AImageButton()
                {
                    BackColor = Color.Transparent,
                    Size = new Size(25, 25),
                    Image = Properties.Resources.ColorOasisLogo,
                    ImageActive = Properties.Resources.ColorOasisLogo
                };
                Add_Pic.Click += new EventHandler(QuickSearchbtn_Click);
                Add_Pic.Tag = customTag;

                Pnl.Controls.Add(Add_Pic);
                Add_Pic.BringToFront();
                Add_Pic.Location = new Point(110, 3);

                var Lbl = new Label
                {
                    Text = service.Name,
                    BackColor = Color.Transparent,
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true
                };
                Pnl.Controls.Add(Lbl);
                Lbl.Location = new Point(3, 123);

                var Lbl_Price = new Label
                {
                    Text = service.MaximumPrice + " L.E",
                    BackColor = Color.Transparent,
                    ForeColor = Color.YellowGreen,
                    Font = new Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Size = new Size(88, 16)
                };
                Pnl.Controls.Add(Lbl_Price);
                Lbl_Price.Location = new Point(89, 123);

                if (service.Discount > 0)
                {
                    var Lbl_Discount = new Label
                    {
                        Text = service.MaximumPrice + " L.E",
                        BackColor = Color.Transparent,
                        ForeColor = Color.IndianRed,
                        Font = new Font("Century Gothic", 7.0F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0))),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(88, 16)
                    };
                    Pnl.Controls.Add(Lbl_Discount);
                    Lbl_Discount.Location = new Point(88, 114);

                    var Sale_Banner = new A7MD_Library.NewControls.A2SBanner
                    {
                        Text = "Sale",
                        Location = new Point(-18, 1),
                        Size = new Size(63, 20)
                    };
                    Lbl_Price.Location = new Point(89, 131);
                    Sale_Banner.Refresh();
                    Pnl.Controls.Add(Sale_Banner);

                    Lbl_Price.Text = (service.MaximumPrice - Convert.ToInt32(service.Discount)) + " L.E";
                }
                RoundedFLowLayoutPanel1.Controls.Add(Pnl);
                RoundedFLowLayoutPanel1.Refresh();
            }
        }
        public void QuickSearchbtn_Click(object sender, EventArgs e)
        {
            var button = sender as A7MD_Library.Pictures.AImageButton;
            CustomTag customTag = button.Tag as CustomTag;
            if (button != null && customTag!=null)
            {
                int ItemId = customTag.Id;
                Service service = customTag.obj as Service;
                if (service!=null)
                {
                    AddToDGV(service);
                }
            if (SiticonePanel1.Size != new Size(SiticonePanel1.PanelWidthExpanded, SiticonePanel1.Size.Height))
            {
                    SiticonePanel1.Size = new Size(SiticonePanel1.PanelWidthCollapsed, SiticonePanel1.Size.Height);
                    Spread_Panel_Btn.Checked = !Spread_Panel_Btn.Checked;
            }
            }            
            this.Refresh();
            this.Invalidate();
        }
        public void AddToDGV(Service service)
        {

            for (int i = 0; i < DGV_Search.Rows.Count; i++)
            {

                if (DGV_Search.Rows[i].Cells[1].Value.ToString() == service.Id.ToString())
                {
                    DGV_Search.Rows[i].Cells[3].Value = Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value) + 1;
                    DGV_Search[11, DGV_Search.CurrentRow.Index].Selected = false;
                    DGV_Calculations();
                    return;
                }
            }
            DGV_Search.Rows.Add();
            int Barcod = DGV_Search.Rows.Count - 1;
            DGV_Search[0, Barcod].Value = DGV_Search.Rows.Count; // My.Settings.Ahmed or DT.Rows[0]["ITEM_CODE"]
            DGV_Search[1, Barcod].Value = Convert.ToInt32(service.Id);
            DGV_Search[2, Barcod].Value = service.Name;
            DGV_Search[3, Barcod].Value = 1;
            DGV_Search[4, Barcod].Value = Convert.ToDecimal(service.MinimumPrice);
            DGV_Search[5, Barcod].Value = Convert.ToDecimal(service.MaximumPrice);
            DGV_Search[6, Barcod].Value = Convert.ToDecimal(service.Discount);
            DGV_Search[7, Barcod].Value = Convert.ToDecimal((service.MaximumPrice + service.MinimumPrice) / 2);
            DGV_Search[8, Barcod].Value = Convert.ToDecimal(service.Discount);
            DGV_Search[9, Barcod].Value = Convert.ToInt32((service.MaximumPrice + service.MinimumPrice) / 2);
            DGV_Search[10, Barcod].Value = Convert.ToInt32(service.ServiceCategoryId);
            DGV_Search[11, Barcod].Value = Convert.ToInt32(service.ServiceTypeId);
            DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
            DGV_Calculations();

        }
        public async override Task SizeChangedAsync()
        {
            await base.SizeChangedAsync();
            SiticonePanel1.PanelWidthExpanded = Width - 15;
            if(Spread_Panel_Btn.Location != new Point(SiticonePanel1.Width - 13, SiticonePanel1.Location.Y - 21))
            {
                Spread_Panel_Btn.Location = new Point(SiticonePanel1.Width - 13, SiticonePanel1.Location.Y - 21);
            }

        }

        private void SiticonePanel1_OnCollapsedStateChanged(object sender, EventArgs e)
        {
            //if (SiticonePanel1.Collapsed)
            //{
            //    Spread_Panel_Btn.Location = new Point(SiticonePanel1.Width-13, SiticonePanel1.Location.Y-21);
            //}
            //else
            //{
                Spread_Panel_Btn.Location = new Point(SiticonePanel1.Width - 13, SiticonePanel1.Location.Y - 21);
            //}
        }

        private void Spread_Panel_Btn_Click(object sender, EventArgs e)
        {
            if (SiticonePanel1.Size.Width== SiticonePanel1.PanelWidthExpanded)
            {
                SiticonePanel1.Size = new Size(SiticonePanel1.PanelWidthCollapsed, SiticonePanel1.Size.Height);
                SiticonePanel1.Collapsed=true;
            }
            else
            {
                SiticonePanel1.Size = new Size(SiticonePanel1.PanelWidthExpanded, SiticonePanel1.Size.Height);
                SiticonePanel1.Collapsed = false;
            }
            Spread_Panel_Btn.Location = new Point(SiticonePanel1.Width - 13, SiticonePanel1.Location.Y - 21);
        }


        private void Show_Search_Settings_Btn_Click(object sender, EventArgs e)
        {
            panel2.Dock= DockStyle.Top;
        }

        private async void ClientTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ClientTypeComboBox.SelectedIndex) != 0)
            {
                var Client = await CompanyRepo.GetAll();
                if (Client!=null|| Client.Count>0)
                {
                    ClientNameTxtBox.AutoCompleteCustomSource.Clear();
                    ClientNameTxtBox.AutoCompleteCustomSource.AddRange(Client.Select(service => service.Name).ToArray());
                }
            }
            else
            {
                var Client = await ClientRepo.GetAll();
                if (Client != null || Client.Count > 0)
                {
                    ClientNameTxtBox.AutoCompleteCustomSource.Clear();
                    ClientNameTxtBox.AutoCompleteCustomSource.AddRange(Client.Select(service => service.Name).ToArray());
                }
            }


        }

        private async void ClientNameTxtBox_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClientNameTxtBox.Text))
            {

                if (Convert.ToInt32(ClientTypeComboBox.SelectedIndex) != 0)
                {
                    var Client = await CompanyRepo.GetByName(ClientNameTxtBox.Text);
                    if (Client != null)
                    {
                        ClientLocationTxtBox.Text = Client.Address;
                        ClientIdTxtBox.Text = Client.Id.ToString();
                        ClientPhoneTxtBox.Text = Client.Phone;
                    }
                    else
                    {
                        popMessage("There's no Clients with that name or can't get its info", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        Item_Name_TxtBox.Clear();
                    }
                }
                else
                {
                    var Client = await ClientRepo.GetByName(ClientNameTxtBox.Text);
                    if (Client != null)
                    {
                        ClientLocationTxtBox.Text = Client.Address;
                        ClientIdTxtBox.Text = Client.Id.ToString();
                        ClientPhoneTxtBox.Text = Client.Phone;
                    }
                    else
                    {
                        popMessage("There's no Clients with that name or can't get its info", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        Item_Name_TxtBox.Clear();
                    }
                }
            }
        }

        private void DGV_Search_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex== 3)
            {
                var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                new WaitLoaderForm(frm, new AddNumber(DGV_Search[3, e.RowIndex],1000,0), 10);
                DGV_Calculations();
            }
        }

        private void DGV_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (DGV_Search.Rows.Count > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                    new WaitLoaderForm(frm, new AddNumber(DGV_Search[3, e.RowIndex], 1000, 0), 10);
                    DGV_Calculations();
                }
            }
        }

        private void DGV_Search_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_Search.Rows.Count>0)
            {
                if (e.ColumnIndex == 12)
                {
                    if (DGV_Search[12, DGV_Search.CurrentRow.Index].Selected == true)
                    {
                        DGV_Search.Rows.RemoveAt(DGV_Search.CurrentRow.Index);
                        if (DGV_Search.Rows.Count > 0)
                        {
                            DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
                        }
                        DGV_Calculations();
                    }
                }
            }
        }

        private void DGV_Search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Search.Rows.Count>0)
            {
                if (e.ColumnIndex == 12)
                {
                    if (DGV_Search[12, DGV_Search.CurrentRow.Index].Selected == true)
                    {
                        DGV_Search.Rows.RemoveAt(DGV_Search.CurrentRow.Index);
                        if (DGV_Search.Rows.Count > 0)
                        {
                            DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
                        }
                        DGV_Calculations();
                    }
                }
            }
        }
        private void DGV_Calculations()
        {
            decimal TotalQty=0, TotalPrice=0, TotalDiscount=0;
            if (DGV_Search.Rows.Count>0)
            {
                for (int i = 0; i <= DGV_Search.Rows.Count - 1; i++)
                {
                    if (Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value) <= 0) 
                    { 
                        DGV_Search.Rows.RemoveAt(DGV_Search.CurrentRow.Index);
                        DGV_Calculations();
                        return;
                    }
                    TotalQty += Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value);
                    TotalDiscount += Convert.ToDecimal(DGV_Search.Rows[i].Cells[6].Value);
                    DGV_Search.Rows[i].Cells[8].Value = Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value) * Convert.ToDecimal(DGV_Search.Rows[i].Cells[6].Value);
                    DGV_Search.Rows[i].Cells[9].Value = Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value)* Convert.ToDecimal(DGV_Search.Rows[i].Cells[7].Value);
                    TotalPrice = Convert.ToDecimal(DGV_Search.Rows[i].Cells[9].Value);
                }
                QtyTxtBox.Text = TotalQty.ToString();
            }
            else
            {
                QtyTxtBox.Text = "0";
            }
        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateStringD(UnitTypeComboBox, "يرجى اختيار نوع الوحده")) return;
            if (!ValidateString(UnitRoomsNoTxtbox, "يرجى ادخال عدد الغرف")) return;
            if (!ValidateString(UnitCodeTxtBox, "يرجى ادخال كود الوحده")) return;
            if (!ValidateString(PoBoxTxtBox, "يرجى ادخال صندوق البريد")) return;
            if (!ValidateStringD(ClientTypeComboBox, "يرجى اختيار نوع العميل")) return;
            if (!ValidateString(ClientNameTxtBox, "يرجى ادخال اسم العميل")) return;
            if (!ValidateString(ClientTRNTxtBox, "يرجى ادخال الرقم الضريبي")) return;
            if (DGV_Search.Rows.Count<=0)
            {
                popMessage("اضف بعض الخدمات للتوصيف", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                return;
            }
            Inspection inspection = new Inspection();
            //todo:make it dynamic
            inspection.DateTime = DateTime.Now;
            inspection.TypeofUnit = (UnitType)UnitTypeComboBox.SelectedIndex;
            inspection.RoomsNo = Convert.ToInt32(UnitRoomsNoTxtbox.Text);
            inspection.UnitCode=UnitCodeTxtBox.Text;
            inspection.POBox = PoBoxTxtBox.Text;
            inspection.ClientType=(ClientType)ClientTypeComboBox.SelectedIndex;
            inspection.ClientId = Convert.ToInt32(ClientIdTxtBox.Text);
            inspection.ClientName = ClientNameTxtBox.Text;
            inspection.ClientLocation=ClientLocationTxtBox.Text;
            inspection.ClientPhoneNo = ClientPhoneTxtBox.Text;
            inspection.ClientTRN = ClientTRNTxtBox.Text;
            inspection.AddedBy = "1";
            inspection.EditedBy = "";
            inspection.DeletedBy = "";
            inspection.IsDeleted = false;
            bool isSuccess=await InspectionRepo.Add(inspection);
            if (isSuccess)
            {
                List<InspectionDetails> details = new List<InspectionDetails>();
                foreach (DataGridViewRow row in DGV_Search.Rows)
                {
                    // Skip the last row if it's a new row for input
                    if (row.IsNewRow) continue;
                    InspectionDetails inspectionDetails = new InspectionDetails();

                    inspectionDetails.InspectionId=inspection.Id;
                    inspectionDetails.ServiceId = Convert.ToInt32(row.Cells[1].Value);
                    inspectionDetails.ServiceName = row.Cells[2].Value.ToString();
                    inspectionDetails.Qty = Convert.ToDecimal(row.Cells[3].Value);
                    inspectionDetails.MinimumPrice = Convert.ToDecimal(row.Cells[4].Value);
                    inspectionDetails.MaximumPrice = Convert.ToDecimal(row.Cells[5].Value);
                    inspectionDetails.Discount = Convert.ToDecimal(row.Cells[6].Value);
                    inspectionDetails.UnitPrice = Convert.ToDecimal(row.Cells[7].Value);
                    inspectionDetails.Price = Convert.ToDecimal(row.Cells[9].Value);
                    inspectionDetails.CategoryId = Convert.ToInt32(row.Cells[10].Value);
                    inspectionDetails.TypeId = Convert.ToInt32(row.Cells[11].Value);
                    details.Add(inspectionDetails);
                }
                bool isSuccessDetails=await InspectionDetailsRepo.Add(details);
                if (isSuccessDetails)
                {
                    popMessage($"تمت اضافه توصيف جديد بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    await base.SaveDataAsync();
                }
            }
        }
        public override async Task EditData()
        {
            if (!ValidateStringD(UnitTypeComboBox, "يرجى اختيار نوع الوحده")) return;
            if (!ValidateString(UnitRoomsNoTxtbox, "يرجى ادخال عدد الغرف")) return;
            if (!ValidateString(UnitCodeTxtBox, "يرجى ادخال كود الوحده")) return;
            if (!ValidateString(PoBoxTxtBox, "يرجى ادخال صندوق البريد")) return;
            if (!ValidateStringD(ClientTypeComboBox, "يرجى اختيار نوع العميل")) return;
            if (!ValidateString(ClientNameTxtBox, "يرجى ادخال اسم العميل")) return;
            if (!ValidateString(ClientTRNTxtBox, "يرجى ادخال الرقم الضريبي")) return;
            if (DGV_Search.Rows.Count <= 0)
            {
                popMessage("اضف بعض الخدمات للتوصيف", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                return;
            }
            Inspection inspection = new Inspection();
            //todo:make it dynamic
            inspection.Id = Convert.ToInt32(IdTextBox.Text);
            inspection.DateTime = DateTime.Now;
            inspection.TypeofUnit = (UnitType)UnitTypeComboBox.SelectedIndex;
            inspection.RoomsNo = Convert.ToInt32(UnitRoomsNoTxtbox.Text);
            inspection.UnitCode = UnitCodeTxtBox.Text;
            inspection.POBox = PoBoxTxtBox.Text;
            inspection.ClientType = (ClientType)ClientTypeComboBox.SelectedIndex;
            inspection.ClientId = Convert.ToInt32(ClientIdTxtBox.Text);
            inspection.ClientName = ClientNameTxtBox.Text;
            inspection.ClientLocation = ClientLocationTxtBox.Text;
            inspection.ClientPhoneNo = ClientPhoneTxtBox.Text;
            inspection.ClientTRN = ClientTRNTxtBox.Text;
            inspection.EditedBy = "1";
            inspection.IsDeleted = false;
            bool isSuccess = await InspectionRepo.Update(inspection);
            if (isSuccess) isSuccess=await InspectionDetailsRepo.DeleteById(inspection.Id);
            if (isSuccess)
            {
                List<InspectionDetails> details = new List<InspectionDetails>();
                foreach (DataGridViewRow row in DGV_Search.Rows)
                {
                    // Skip the last row if it's a new row for input
                    if (row.IsNewRow) continue;
                    InspectionDetails inspectionDetails = new InspectionDetails();

                    inspectionDetails.InspectionId = inspection.Id;
                    inspectionDetails.ServiceId = Convert.ToInt32(row.Cells[1].Value);
                    inspectionDetails.ServiceName = row.Cells[2].Value.ToString();
                    inspectionDetails.Qty = Convert.ToDecimal(row.Cells[3].Value);
                    inspectionDetails.MinimumPrice = Convert.ToDecimal(row.Cells[4].Value);
                    inspectionDetails.MaximumPrice = Convert.ToDecimal(row.Cells[5].Value);
                    inspectionDetails.Discount = Convert.ToDecimal(row.Cells[6].Value);
                    inspectionDetails.UnitPrice = Convert.ToDecimal(row.Cells[7].Value);
                    inspectionDetails.Price = Convert.ToDecimal(row.Cells[9].Value);
                    inspectionDetails.CategoryId = Convert.ToInt32(row.Cells[10].Value);
                    inspectionDetails.TypeId = Convert.ToInt32(row.Cells[11].Value);
                    details.Add(inspectionDetails);
                }
                bool isSuccessDetails = await InspectionDetailsRepo.Add(details);
                if (isSuccessDetails) popMessage($"تمت تعديل التوصيف بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
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
                        Inspection inspection = new Inspection();
                        //todo:make it dynamic
                        inspection.Id = Convert.ToInt32(IdTextBox.Text.Trim());
                        inspection.DateTime = DateTime.Now;
                        inspection.TypeofUnit = (UnitType)UnitTypeComboBox.SelectedIndex;
                        inspection.RoomsNo = Convert.ToInt32(UnitRoomsNoTxtbox.Text);
                        inspection.UnitCode = UnitCodeTxtBox.Text;
                        inspection.POBox = PoBoxTxtBox.Text;
                        inspection.ClientType = (ClientType)ClientTypeComboBox.SelectedIndex;
                        inspection.ClientId = Convert.ToInt32(ClientIdTxtBox.Text);
                        inspection.ClientName = ClientNameTxtBox.Text;
                        inspection.ClientLocation = ClientLocationTxtBox.Text;
                        inspection.ClientPhoneNo = ClientPhoneTxtBox.Text;
                        inspection.ClientTRN = ClientTRNTxtBox.Text;
                        inspection.EditedBy = "1";
                        inspection.IsDeleted = false;
                        bool isSuccess = await InspectionRepo.Delete(inspection);
                        if (isSuccess) isSuccess = await InspectionDetailsRepo.DeleteById(Convert.ToInt32(IdTextBox.Text.Trim()));
                        if (isSuccess) popMessage($"تمت حذف التوصيف بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        await base.DeleteData();
                    }
                }
            }
        }
        public override async Task Search_Data()
        {
            //todo:Change it for all screens
            List<string> list = new List<string>() { "#", "اسم العميل", "كود الوحده", "رقم صندوق البريد" };
            List<string> Properties = new List<string>() { "ID", "ClientName", "UnitCode", "POBox" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<Inspection>(this, await InspectionRepo.GetAll(), dataSource), 10);

            await base.Search_Data();
        }
        public override async Task LoadData(int ItemID)
        {
            Inspection inspection =await InspectionRepo.GetById(ItemID);
            IdTextBox.Text = inspection.Id.ToString();
            UnitTypeComboBox.SelectedIndex = (int)inspection.TypeofUnit;
            UnitRoomsNoTxtbox.Text =inspection.RoomsNo.ToString();
            UnitCodeTxtBox.Text =inspection.UnitCode;
            PoBoxTxtBox.Text = inspection.POBox;
            ClientTypeComboBox.SelectedIndex = (int)inspection.ClientType;
            ClientIdTxtBox.Text = inspection.ClientId.ToString();
            ClientNameTxtBox.Text = inspection.ClientName;
            ClientLocationTxtBox.Text = inspection.ClientLocation;
            ClientPhoneTxtBox.Text = inspection.ClientPhoneNo;
            ClientTRNTxtBox.Text = inspection.ClientTRN;
            DGV_Search.Rows.Clear();
            List<InspectionDetails> inspectionDetails = await InspectionDetailsRepo.GetById(ItemID);
            foreach (InspectionDetails service in inspectionDetails)
            {
                DGV_Search.Rows.Add();
                int Barcod = DGV_Search.Rows.Count - 1;
                DGV_Search[0, Barcod].Value = DGV_Search.Rows.Count; // My.Settings.Ahmed or DT.Rows[0]["ITEM_CODE"]
                DGV_Search[1, Barcod].Value = Convert.ToInt32(service.Id);
                DGV_Search[2, Barcod].Value = service.ServiceName;
                DGV_Search[3, Barcod].Value = Convert.ToDecimal(service.Qty);
                DGV_Search[4, Barcod].Value = Convert.ToDecimal(service.MinimumPrice);
                DGV_Search[5, Barcod].Value = Convert.ToDecimal(service.MaximumPrice);
                DGV_Search[6, Barcod].Value = Convert.ToDecimal(service.Discount);
                DGV_Search[7, Barcod].Value = Convert.ToDecimal(service.UnitPrice);
                DGV_Search[8, Barcod].Value = Convert.ToDecimal(service.Discount * service.Qty);
                DGV_Search[9, Barcod].Value = Convert.ToInt32(service.Price);
                DGV_Search[10, Barcod].Value = Convert.ToInt32(service.CategoryId);
                DGV_Search[11, Barcod].Value = Convert.ToInt32(service.TypeId);
                DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
            }
            DGV_Calculations();

            await base.LoadData(ItemID);   
        }
        public override Task SaveAsData()
        {
            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.quotationUC1.GetFromInspection(Convert.ToInt32(IdTextBox.Text));
            return base.SaveAsData();
        }
    }
}
