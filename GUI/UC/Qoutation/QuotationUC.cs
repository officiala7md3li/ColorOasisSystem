using ColorOasisSystem.Entities;
using ColorOasisSystem.Enums;
using ColorOasisSystem.GUI.Helping_Program;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Reports;
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
    public partial class QuotationUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        bool IsLoaded=false;
        int SourceId = 0;
        InspectionRepo InspectionRepo;
        InspectionDetailsRepo InspectionDetailsRepo;
        QuotationRepo QuotationRepo;
        QuotationDetailsRepo QuotationDetailsRepo;
        public QuotationUC()
        {
            InitializeComponent();
            InspectionRepo=new InspectionRepo();
            InspectionDetailsRepo=new InspectionDetailsRepo();
            QuotationRepo = new QuotationRepo();
            QuotationDetailsRepo=new QuotationDetailsRepo();
            DGV_Search.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(216, 179, 103);
        }
        public async void GetFromInspection(int ItemID)
        {
            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.quotationUC1);
            int quoteId = await QuotationRepo.GetbySourceId(ItemID);
            if (quoteId != 0) 
            {
                await LoadData(quoteId);
                return;
            }
            Inspection inspection = await InspectionRepo.GetById(ItemID);
            IdTextBox.Text = inspection.Id.ToString();
            UnitTypeComboBox.SelectedIndex = (int)inspection.TypeofUnit;
            UnitRoomsNoTxtbox.Text = inspection.RoomsNo.ToString();
            UnitCodeTxtBox.Text = inspection.UnitCode;
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
                DGV_Search[8, Barcod].Value = Convert.ToDecimal(service.Discount* service.Qty);
                DGV_Search[9, Barcod].Value = Convert.ToInt32(service.Price);
                DGV_Search[10, Barcod].Value = Convert.ToInt32(service.CategoryId);
                DGV_Search[11, Barcod].Value = Convert.ToInt32(service.TypeId);
                DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
            }
            DGV_Calculations();
            IsLoaded=true;
            SourceId = ItemID;
            Modified = false;
        }
        private void DGV_Calculations()
        {
            decimal TotalQty = 0, TotalPrice = 0, TotalDiscount = 0;
            if (DGV_Search.Rows.Count > 0)
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
                    DGV_Search.Rows[i].Cells[8].Value = Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value) * Convert.ToDecimal(DGV_Search.Rows[i].Cells[6].Value);
                    DGV_Search.Rows[i].Cells[9].Value = Convert.ToDecimal(DGV_Search.Rows[i].Cells[3].Value) * Convert.ToDecimal(DGV_Search.Rows[i].Cells[7].Value);
                    TotalPrice += Convert.ToDecimal(DGV_Search.Rows[i].Cells[9].Value);
                    TotalDiscount += Convert.ToDecimal(DGV_Search.Rows[i].Cells[8].Value);
                }

                var VATValue = Properties.Settings.Default.VATValue <= 0 ? TotalPrice * 0 : (TotalPrice * Properties.Settings.Default.VATValue)/100;
                VATTxtBox.Text = VATValue.ToString();
                QtyTxtBox.Text = TotalQty.ToString();
                DiscountTxtBox.Text = TotalDiscount.ToString();
                SubTotalPriceTxtBox.Text= (TotalPrice).ToString();
                TotalPriceTxtBox.Text = ((TotalPrice - TotalDiscount) + VATValue).ToString();
                PaidTxtBox.Text = "0";
                RemainTxtBox.Text = ((TotalPrice - TotalDiscount) + VATValue).ToString();
            }
            else
            {
                QtyTxtBox.Text = "0";
                VATTxtBox.Text = "0";
                QtyTxtBox.Text = "0";
                DiscountTxtBox.Text = "0";
                SubTotalPriceTxtBox.Text = "0";
                TotalPriceTxtBox.Text = "0";
                PaidTxtBox.Text = "0";
                RemainTxtBox.Text = "0";
            }
        }
        public override async void NewDataAsync()
        {
            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            //frm.inspectionUC1.NewDataAsync();
            frm.SelectedUC(frm.inspectionUC1);
            SetPropertyNull();
            base.NewDataAsync();
            IsLoaded = false;
            SourceId = 0;
            Modified = false;
        }
        public override async Task SaveDataAsync()
        {
            if (!IsLoaded)
            {
                popMessage("يرجي تحويل التوصيف اولا او تحميل من التسعيرات المحفوظه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                return;
            }
            if (DGV_Search.Rows.Count <= 0)
            {
                popMessage("اضف بعض الخدمات للتوصيف", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                return;
            }
            Quotation quotation = new Quotation();
            quotation.DateTime = DateTime.Now;
            quotation.TypeofUnit = (UnitType)UnitTypeComboBox.SelectedIndex;
            quotation.RoomsNo = Convert.ToInt32(UnitRoomsNoTxtbox.Text);
            quotation.UnitCode = UnitCodeTxtBox.Text;
            quotation.POBox = PoBoxTxtBox.Text;
            quotation.ClientType = (ClientType)ClientTypeComboBox.SelectedIndex;
            quotation.ClientId = Convert.ToInt32(ClientIdTxtBox.Text);
            quotation.ClientName = ClientNameTxtBox.Text;
            quotation.ClientLocation = ClientLocationTxtBox.Text;
            quotation.ClientPhoneNo = ClientPhoneTxtBox.Text;
            quotation.ClientTRN = ClientTRNTxtBox.Text;
            quotation.VAT = Convert.ToDecimal(VATTxtBox.Text);
            quotation.SubTotal = Convert.ToDecimal(SubTotalPriceTxtBox.Text);
            quotation.Discount = Convert.ToDecimal(DiscountTxtBox.Text);
            quotation.Total = Convert.ToDecimal(TotalPriceTxtBox.Text);
            quotation.Paid = Convert.ToDecimal(PaidTxtBox.Text);
            quotation.Remain = Convert.ToDecimal(RemainTxtBox.Text);
            quotation.InspectionId = SourceId;
            quotation.AddedBy = "1";
            quotation.EditedBy = "";
            quotation.DeletedBy = "";
            quotation.IsDeleted = false;
            quotation.IsValid= true;
            bool isSuccess = await QuotationRepo.Add(quotation);
            if (isSuccess)
            {
                List<QuotationDetails> details = new List<QuotationDetails>();
                foreach (DataGridViewRow row in DGV_Search.Rows)
                {
                    // Skip the last row if it's a new row for input
                    if (row.IsNewRow) continue;
                    QuotationDetails quotationDetails = new QuotationDetails();

                    quotationDetails.QuoteId = quotation.Id;
                    quotationDetails.ServiceId = Convert.ToInt32(row.Cells[1].Value);
                    quotationDetails.ServiceName = row.Cells[2].Value.ToString();
                    quotationDetails.Qty = Convert.ToDecimal(row.Cells[3].Value);
                    quotationDetails.MinimumPrice = Convert.ToDecimal(row.Cells[4].Value);
                    quotationDetails.MaximumPrice = Convert.ToDecimal(row.Cells[5].Value);
                    quotationDetails.Discount = Convert.ToDecimal(row.Cells[6].Value);
                    quotationDetails.UnitPrice = Convert.ToDecimal(row.Cells[7].Value);
                    quotationDetails.TotalDiscount=Convert.ToDecimal(row.Cells[8].Value);
                    quotationDetails.Price = Convert.ToDecimal(row.Cells[9].Value);
                    quotationDetails.CategoryId = Convert.ToInt32(row.Cells[10].Value);
                    quotationDetails.TypeId = Convert.ToInt32(row.Cells[11].Value);
                    details.Add(quotationDetails);
                }
                bool isSuccessDetails = await QuotationDetailsRepo.Add(details);
                if (isSuccessDetails) popMessage($"تمت اضافه تسعير جديد بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                IsLoaded = false;
                base.NewDataAsync();
            }
        }
        public async override Task EditData()
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
            Quotation quotation = new Quotation();
            quotation.Id=Convert.ToInt32(IdTextBox.Text);
            quotation.DateTime = DateTime.Now;
            quotation.TypeofUnit = (UnitType)UnitTypeComboBox.SelectedIndex;
            quotation.RoomsNo = Convert.ToInt32(UnitRoomsNoTxtbox.Text);
            quotation.UnitCode = UnitCodeTxtBox.Text;
            quotation.POBox = PoBoxTxtBox.Text;
            quotation.ClientType = (ClientType)ClientTypeComboBox.SelectedIndex;
            quotation.ClientId = Convert.ToInt32(ClientIdTxtBox.Text);
            quotation.ClientName = ClientNameTxtBox.Text;
            quotation.ClientLocation = ClientLocationTxtBox.Text;
            quotation.ClientPhoneNo = ClientPhoneTxtBox.Text;
            quotation.ClientTRN = ClientTRNTxtBox.Text;
            quotation.VAT = Convert.ToDecimal(VATTxtBox.Text);
            quotation.SubTotal = Convert.ToDecimal(SubTotalPriceTxtBox.Text);
            quotation.Discount = Convert.ToDecimal(DiscountTxtBox.Text);
            quotation.Total = Convert.ToDecimal(TotalPriceTxtBox.Text);
            quotation.Paid = Convert.ToDecimal(PaidTxtBox.Text);
            quotation.Remain = Convert.ToDecimal(RemainTxtBox.Text);
            quotation.Note = NoteTxtBox.Text;
            quotation.InspectionId = SourceId;
            quotation.AddedBy = "1";
            quotation.EditedBy = "";
            quotation.DeletedBy = "";
            quotation.IsDeleted = false;
            quotation.IsValid = true;
            bool isSuccess = await QuotationRepo.Update(quotation);
            if (isSuccess) isSuccess = await QuotationDetailsRepo.DeleteById(quotation.Id);
            if (isSuccess)
            {
                List<QuotationDetails> details = new List<QuotationDetails>();
                foreach (DataGridViewRow row in DGV_Search.Rows)
                {
                    // Skip the last row if it's a new row for input
                    if (row.IsNewRow) continue;
                    QuotationDetails quotationDetails = new QuotationDetails();

                    quotationDetails.QuoteId = quotation.Id;
                    quotationDetails.ServiceId = Convert.ToInt32(row.Cells[1].Value);
                    quotationDetails.ServiceName = row.Cells[2].Value.ToString();
                    quotationDetails.Qty = Convert.ToDecimal(row.Cells[3].Value);
                    quotationDetails.MinimumPrice = Convert.ToDecimal(row.Cells[4].Value);
                    quotationDetails.MaximumPrice = Convert.ToDecimal(row.Cells[5].Value);
                    quotationDetails.Discount = Convert.ToDecimal(row.Cells[6].Value);
                    quotationDetails.UnitPrice = Convert.ToDecimal(row.Cells[7].Value);
                    quotationDetails.TotalDiscount = Convert.ToDecimal(row.Cells[8].Value);
                    quotationDetails.Price = Convert.ToDecimal(row.Cells[9].Value);
                    quotationDetails.CategoryId = Convert.ToInt32(row.Cells[10].Value);
                    quotationDetails.TypeId = Convert.ToInt32(row.Cells[11].Value);
                    details.Add(quotationDetails);
                }
                bool isSuccessDetails = await QuotationDetailsRepo.Add(details);
                if (isSuccessDetails) popMessage($"تمت تعديل التسعير بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                IsLoaded = false;
                await base.EditData();
            }

        }
        public override Task DeleteData()
        {
            IsLoaded = false;
            return base.DeleteData();   
        }
        public async override Task Search_Data()
        {
            //todo:Change it for all screens
            List<string> list = new List<string>() { "#", "اسم العميل", "كود الوحده", "رقم صندوق البريد","الاجمالي" };
            List<string> Properties = new List<string>() { "ID", "ClientName", "UnitCode", "POBox", "Total" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<Quotation>(this, await QuotationRepo.GetAll(), dataSource), 10);

            await base.Search_Data();
        }
        public override async Task LoadData(int ItemID)
        {
            Quotation quotation =await QuotationRepo.GetById(ItemID);
            IdTextBox.Text = quotation.Id.ToString();
            UnitTypeComboBox.SelectedIndex = (int)quotation.TypeofUnit;
            UnitRoomsNoTxtbox.Text = quotation.RoomsNo.ToString();
            UnitCodeTxtBox.Text = quotation.UnitCode;
            PoBoxTxtBox.Text = quotation.POBox;
            ClientTypeComboBox.SelectedIndex = (int)quotation.ClientType;
            ClientIdTxtBox.Text = quotation.ClientId.ToString();
            ClientNameTxtBox.Text = quotation.ClientName;
            ClientLocationTxtBox.Text = quotation.ClientLocation;
            ClientPhoneTxtBox.Text = quotation.ClientPhoneNo;
            ClientTRNTxtBox.Text = quotation.ClientTRN;
            VATTxtBox.Text = quotation.VAT.ToString();
            SubTotalPriceTxtBox.Text = quotation.SubTotal.ToString();
            DiscountTxtBox.Text=quotation.Discount.ToString();
            TotalPriceTxtBox.Text=quotation.Total.ToString();
            PaidTxtBox.Text = quotation.Total.ToString();
            RemainTxtBox.Text = quotation.Remain.ToString();
            SourceId=quotation.InspectionId;
            NoteTxtBox.Text = quotation.Note;
            ChangeButtonsVisiblity(quotation.IsValid, quotation.IsValid, quotation.IsValid && quotation.IsPaid && quotation.IsConverted);
            DGV_Search.Rows.Clear();
            List<QuotationDetails> quotationDetails = await QuotationDetailsRepo.GetById(ItemID);
            foreach (QuotationDetails service in quotationDetails)
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
                DGV_Search[8, Barcod].Value = Convert.ToDecimal(service.TotalDiscount);
                DGV_Search[9, Barcod].Value = Convert.ToInt32(service.Price);
                DGV_Search[10, Barcod].Value = Convert.ToInt32(service.CategoryId);
                DGV_Search[11, Barcod].Value = Convert.ToInt32(service.TypeId);
                DGV_Search[12, DGV_Search.CurrentRow.Index].Selected = false;
                DGV_Search[9, Barcod].Value = Convert.ToDecimal(service.Discount)* Convert.ToDecimal(service.Qty);
            }
            DGV_Calculations();
            IsLoaded = true;
            await base.LoadData(ItemID);
            Modified = false;
        }
        private void ChangeButtonsVisiblity(bool CloseQuotation,bool Convert2Invoice,bool Convert2Recipt)
        {
            CloseQuotationBtn.Visible = CloseQuotation;

            ConvertToInvoiceBtn.Visible = CloseQuotation&&Convert2Invoice;
            PrintQuotationBtn.Visible = CloseQuotation&&Convert2Invoice;
            NoteTxtBox.Visible=CloseQuotation&&Convert2Invoice;
            if (NoteTxtBox.Visible) 
            { 
                DGV_Search.Height = DGV_Search.Height - (NoteTxtBox.Height + 5);
            }
            else
            {
                DGV_Search.Height = DGV_Search.Height + (NoteTxtBox.Height+5);
            }
            ConvertToRecpietBtn.Visible = CloseQuotation && Convert2Recipt;
        }

        private async void CloseQuotationBtn_Click(object sender, EventArgs e)
        {
            bool IsSuccess= await QuotationRepo.CloseById(Convert.ToInt32(IdTextBox.Text));
            if (IsSuccess) popMessage($"تمت إغلاق التسعير بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            base.NewDataAsync();
        }

        private async void ConvertToInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (Modified)
            {
                popMessage($"يجب حفظ التغييرات اولا", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                return;
            }
            bool IsSuccess = await QuotationRepo.Convert2InvoiceById(Convert.ToInt32(IdTextBox.Text));
            if (IsSuccess) popMessage($"تمت تحويل التسعير لفاتوره بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            Quotation quotation =await QuotationRepo.GetById(Convert.ToInt32(IdTextBox.Text));
            List<QuotationDetails> details = await QuotationDetailsRepo.GetById(Convert.ToInt32(IdTextBox.Text));
            List<QuotationVM> quotations = new List<QuotationVM>();
            int i = 1;
            foreach (QuotationDetails quoteDeatails in details)
            {
                QuotationVM quotationVM = new QuotationVM();

                // Skip the last row if it's a new row for input
                if (quoteDeatails==null) continue;
                quotationVM.Code = "";
                quotationVM.User = "Ahmed Ali";
                quotationVM.DateTime=DateTime.Now.ToShortDateString();
                quotationVM.TypeofUnit=((Enums.UnitType)quotation.TypeofUnit).ToString();
                quotationVM.RoomsNo=quotation.RoomsNo;
                quotationVM.UnitCode=quotation.UnitCode;
                quotationVM.POBox=quotation.POBox;
                quotationVM.ClientName=quotation.ClientName;
                quotationVM.ClientLocation=quotation.ClientLocation;
                quotationVM.ClientPhoneNo=quotation.ClientPhoneNo;
                quotationVM.ClientTRN=quotation.ClientTRN;
                quotationVM.ClientCompany = "";
                quotationVM.Note = quotation.Note;
                quotationVM.CompanyLogo = null;
                quotationVM.VAT = quotation.VAT;
                quotationVM.SubTotal = quotation.SubTotal;
                quotationVM.InvoiceDiscount = quotation.Discount;
                quotationVM.Total= quotation.Total;
                quotationVM.Paid= quotation.Paid;
                quotationVM.Remain= quotation.Remain;
                //Details
                quotationVM.ServiceIndex = i;
                quotationVM.ServiceName = quoteDeatails.ServiceName;
                quotationVM.Qty = quoteDeatails.Qty;
                quotationVM.MinimumPrice = quoteDeatails.MinimumPrice;
                quotationVM.MaximumPrice = quoteDeatails.MaximumPrice;
                quotationVM.Discount = quoteDeatails.TotalDiscount;
                quotationVM.UnitPrice = quoteDeatails.UnitPrice;
                quotationVM.Price = quoteDeatails.Price;
                quotations.Add(quotationVM);
                i++;
            }
            var reportViewer = new ReportViewer<QuotationVM>(quotations, "ColorOasisSystem.Reports.QuotationReport.rdlc");
            
            reportViewer.Show();

            await SetPropertyNull();
        } 
        private async Task SetPropertyNull()
        {
            EditDataCheck = false;
            foreach (ControlCollection ctrls in new[] { Controls, tableLayoutPanel1.Controls, tableLayoutPanel2.Controls,tableLayoutPanel3.Controls,tableLayoutPanel4.Controls })
            {
                foreach (Control ctrl in ctrls)
                {
                    if (ctrl is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox txtbx = (Guna.UI2.WinForms.Guna2TextBox)ctrl;
                        txtbx.Clear();
                        txtbx.Refresh();
                    }
                    if (ctrl is Guna.UI2.WinForms.Guna2ComboBox)
                    {
                        Guna.UI2.WinForms.Guna2ComboBox Cmbbx = (Guna.UI2.WinForms.Guna2ComboBox)ctrl;
                        Cmbbx.SelectedIndex = -1;
                        Cmbbx.Refresh();
                    }
                    if (ctrl is Guna.UI2.WinForms.Guna2DateTimePicker)
                    {
                        Guna.UI2.WinForms.Guna2DateTimePicker txtbx = (Guna.UI2.WinForms.Guna2DateTimePicker)ctrl;
                        txtbx.Value = DateTime.Now.AddDays(1);
                        txtbx.MinDate = DateTime.Now;
                        txtbx.Refresh();
                    }
                }
            }
            DGV_Search.Rows.Clear();
            ChangeButtonsVisiblity(false,false,false);
        }

        private void ConvertToRecpietBtn_Click(object sender, EventArgs e)
        {
           // new ReportViewer().Show();
        }

        private void DGV_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (DGV_Search.Rows.Count > 0)
            {
                if (e.ColumnIndex == 6)
                {
                    var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                    new WaitLoaderForm(frm, new AddNumber(DGV_Search[6, e.RowIndex], Convert.ToInt32(DGV_Search[4, e.RowIndex].Value), 0), 10);
                    DGV_Calculations();
                    Modified = true;
                }
                if (e.ColumnIndex == 7)
                {
                    var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                    new WaitLoaderForm(frm, new AddNumber(DGV_Search[7, e.RowIndex], Convert.ToInt32(DGV_Search[5, e.RowIndex].Value), Convert.ToInt32(DGV_Search[4, e.RowIndex].Value)), 10);
                    DGV_Calculations();
                    Modified = true;
                }
            }
        }

        private void NoteTxtBox_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }
    }
}
