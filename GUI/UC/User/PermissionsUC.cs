using ColorOasisSystem.DAL.Enums;
using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class PermissionsUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        PermissionRepo repo;
        UserPermissions UserPermissions;
        bool PermissionSelection;
        public PermissionsUC()
        {
            InitializeComponent();
            repo = new PermissionRepo();
            ScreenTypecmbx.DataSource = Screens.GetScreenNames();
            ScreenTypecmbx.DisplayMember = "Name";
            ScreenTypecmbx.ValueMember = "Id";
            SelectionCmbx.SelectedIndex = 0;
            ScreenTypecmbx.SelectedIndex = -1;
            PermissionSelection = false;
        }
        public override void NewDataAsync()
        {
            UserPermissions = new UserPermissions();
            PermissionSelection = false;
            base.NewDataAsync();
        }

        private void Select_All_Btn_Click(object sender, EventArgs e)
        {
            PermissionToCheckBox(new Permission(true));
            PermissionSelection = true;
        }

        private void UnSelect_All_Btn_Click(object sender, EventArgs e)
        {
            PermissionToCheckBox(new Permission(false));
            PermissionSelection = true;
        }

        private void SelectionCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectionCmbx.SelectedIndex)
            {
                case 0:
                    SettingsContainerPnl.Enabled = false;
                    ScreenTypecmbx.Enabled = false;
                    ScreenTypecmbx.Enabled = false;
                    UserPermissions = new UserPermissions(Authority_Name_TxtBox.Text);
                    Select_All_Btn.Enabled = false;
                    UnSelect_All_Btn.Enabled = false;
                    break;
                case 1:
                    SettingsContainerPnl.Enabled = true;
                    ScreenTypecmbx.Enabled = true;
                    ScreenTypecmbx.Enabled = true;
                    UserPermissions = new UserPermissions();
                    Select_All_Btn.Enabled = true;
                    UnSelect_All_Btn.Enabled = true;
                    break;
                default:
                    SettingsContainerPnl.Enabled = false;
                    ScreenTypecmbx.Enabled = false;
                    ScreenTypecmbx.Enabled = false;
                    UserPermissions = new UserPermissions(Authority_Name_TxtBox.Text);
                    break;
            }
        }

        private void SaveSettings_Btn_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(User_Master_Lock_Authority.Checked, User_Add_Authority.Checked, User_Edit_Authority.Checked, User_Delete_Authority.Checked, User_Restore_Search_Authority.Checked, AdditionalChbx.Checked);
            switch (ScreenTypecmbx.SelectedValue)
            {
                case 1:
                    UserPermissions.UserUCPermission = permission;
                    break;
                case 2:
                    UserPermissions.PermissionUCPermission = permission;
                    break;
                case 3:
                    UserPermissions.SettingsUCPermission = permission;
                    break;
                case 4:
                    UserPermissions.CompanyInfoUCPermission = permission;
                    break;
                case 5:
                    UserPermissions.ClientSecondUCPermission = permission;
                    break;
                case 6:
                    UserPermissions.ClientWorkUCPermission = permission;
                    break;
                case 7:
                    UserPermissions.ServiceSecondUCPermission = permission;
                    break;
                case 8:
                    UserPermissions.SettingsSecondUCPermission = permission;
                    break;
                case 9:
                    UserPermissions.WelcomeUCPermission = permission;
                    break;
                case 10:
                    UserPermissions.ServiceTypeUCPermission = permission;
                    break;
                case 11:
                    UserPermissions.ServiceCategoryUCPermission = permission;
                    break;
                case 12:
                    UserPermissions.ServiceUCPermission = permission;
                    break;
                case 13:
                    UserPermissions.ClientUCPermission = permission;
                    break;
                case 14:
                    UserPermissions.CompanyUCPermission = permission;
                    break;
                case 15:
                    UserPermissions.InspectionUCPermission = permission;
                    break;
                case 16:
                    UserPermissions.QuotationUCPermission = permission;
                    break;
                case 17:
                    UserPermissions.ClientPaymentUCPermission = permission;
                    break;
                case 18:
                    UserPermissions.CompanyPaymentUCPermission = permission;
                    break;
                case 19:
                    UserPermissions.ClientTransUCPermission = permission;
                    break;
                case 20:
                    UserPermissions.CompanyTransUCPermission = permission;
                    break;

            }
            PermissionSelection = false;
        }

        private void ScreenTypecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScreenTypecmbx.SelectedValue != null)
            {
                if(ScreenTypecmbx.SelectedValue is ScreenName)
                {
                    ScreenType screenType = Screens.GetScreenType(((ScreenName)ScreenTypecmbx.SelectedValue).ScreenId);
                    PermissionsVisibility(screenType);
                }
                else
                {
                    ScreenType screenType = Screens.GetScreenType((DAL.Enums.Screen)ScreenTypecmbx.SelectedValue);
                    PermissionsVisibility(screenType);
                }
            }
            switch (ScreenTypecmbx.SelectedValue)
            {
                case 1:
                    PermissionToCheckBox(UserPermissions.UserUCPermission);
                    
                    break;
                case 2:
                    PermissionToCheckBox(UserPermissions.PermissionUCPermission);
                    break;
                case 3:
                    PermissionToCheckBox(UserPermissions.SettingsUCPermission);
                    break;
                case 4:
                    PermissionToCheckBox(UserPermissions.CompanyInfoUCPermission);
                    break;
                case 5:
                    PermissionToCheckBox(UserPermissions.ClientSecondUCPermission);
                    break;
                case 6:
                    PermissionToCheckBox(UserPermissions.ClientWorkUCPermission);
                    break;
                case 7:
                    PermissionToCheckBox(UserPermissions.ServiceSecondUCPermission);
                    break;
                case 8:
                    PermissionToCheckBox(UserPermissions.SettingsSecondUCPermission);
                    break;
                case 9:
                    PermissionToCheckBox(UserPermissions.WelcomeUCPermission);
                    break;
                case 10:
                    PermissionToCheckBox(UserPermissions.ServiceTypeUCPermission);
                    break;
                case 11:
                    PermissionToCheckBox(UserPermissions.ServiceCategoryUCPermission);
                    break;
                case 12:
                    PermissionToCheckBox(UserPermissions.ServiceUCPermission);
                    break;
                case 13:
                    PermissionToCheckBox(UserPermissions.ClientUCPermission);
                    break;
                case 14:
                    PermissionToCheckBox(UserPermissions.CompanyUCPermission);
                    break;
                case 15:
                    PermissionToCheckBox(UserPermissions.InspectionUCPermission);
                    break;
                case 16:
                    PermissionToCheckBox(UserPermissions.QuotationUCPermission);
                    break;
                case 17:
                    PermissionToCheckBox(UserPermissions.ClientPaymentUCPermission);
                    break;
                case 18:
                    PermissionToCheckBox(UserPermissions.CompanyPaymentUCPermission);
                    break;
                case 19:
                    PermissionToCheckBox(UserPermissions.ClientTransUCPermission);
                    break;
                case 20:
                    PermissionToCheckBox(UserPermissions.CompanyTransUCPermission);
                    break;

                default:
                    break;
            }

        }

        private void User_Master_Lock_Authority_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            PermissionSelection = true;
        }
        private void PermissionsVisibility(ScreenType screenType)
        {
            switch (screenType)
            {
                case ScreenType.ScreenwithAdditional:
                    ChangePermissionVisiblity(true);
                    break;
                case ScreenType.ScreenwithoutAdditional:
                    ChangePermissionVisiblity(false, true, true, true, true, true);
                    break;
                case ScreenType.SecondScreen:
                    ChangePermissionVisiblity(false, true);
                    break;
                default:
                    break;
            }
        }
        private void ChangePermissionVisiblity(bool isAll,bool isLock=false, bool isAddNew = false, bool isEdit = false, bool isDelete = false, bool isRetreive = false, bool isAdditional = false)
        {
            User_Master_Lock_Authority.Visible = isAll? isAll: isLock;
            lblUser_Master_Lock_Authority.Visible = User_Master_Lock_Authority.Visible;
            User_Add_Authority.Visible = isAll ? isAll : isAddNew;
            lblUser_Add_Authority.Visible = User_Add_Authority.Visible;
            User_Edit_Authority.Visible = isAll ? isAll : isEdit;
            lblUser_Edit_Authority.Visible = User_Edit_Authority.Visible;
            User_Delete_Authority.Visible = isAll ? isAll : isDelete;
            lblUser_Delete_Authority.Visible = User_Delete_Authority.Visible;
            User_Restore_Search_Authority.Visible = isAll ? isAll : isRetreive;
            lblUser_Restore_Search_Authority.Visible = User_Restore_Search_Authority.Visible;
            AdditionalChbx.Visible = isAll ? isAll : isAdditional;
            lblAdditionalChbx.Visible = AdditionalChbx.Visible;
        }
        private void PermissionToCheckBox(Permission permission)
        {
            User_Master_Lock_Authority.Checked = permission.Lock;
            User_Add_Authority.Checked = permission.AddNew;
            User_Edit_Authority.Checked = permission.Edit;
            User_Delete_Authority.Checked = permission.Delete;
            User_Restore_Search_Authority.Checked = permission.Retrive;
            AdditionalChbx.Checked = permission.Additional;
            PermissionSelection = false;
        }

        private void ScreenTypecmbx_DropDown(object sender, EventArgs e)
        {
            if (PermissionSelection) 
            {
                MainMenuForm existingForm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                if (existingForm != null)
                {
                    if (existingForm.CustomMessage("يوجد صلاحيات لم يتم حفظها، هل تريد حفظها؟", "نعم", "لا") == DialogResult.Yes)
                    {
                        SaveSettings_Btn.PerformClick();
                    }
                }
            }
        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateString(Authority_Name_TxtBox, "يرجى إدخال اسم الصلاحيه")) return;
            if (!ValidateString(Authority_NameEn_TxtBox, "يرجى إدخال اسم الصلاحيه بالانجليزيه")) return;
            if (!ValidateStringD(SelectionCmbx, "يرجى أختيار نوع الصلاحيه")) return;
            try
            {
                UserPermissions.Name = Authority_Name_TxtBox.Text;
                UserPermissions.NameEn = Authority_NameEn_TxtBox.Text;
                UserPermissions.Selection=SelectionCmbx.SelectedIndex;
                bool isSuccess = await repo.Add(UserPermissions);
                if (isSuccess)
                {
                    popMessage($"تمت اضافه صلاحيه {UserPermissions.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    await base.SaveDataAsync();
                }            
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                throw;
            }
        }
        public async override Task EditData()
        {
            if (!ValidateString(Authority_Name_TxtBox, "يرجى إدخال اسم الصلاحيه")) return;
            if (!ValidateString(Authority_NameEn_TxtBox, "يرجى إدخال اسم الصلاحيه بالانجليزيه")) return;
            if (!ValidateStringD(SelectionCmbx, "يرجى أختيار نوع الصلاحيه")) return;
            try
            {
                UserPermissions.Id=Convert.ToInt32(ID_TxtBox.Text);
                UserPermissions.Name = Authority_Name_TxtBox.Text;
                UserPermissions.NameEn = Authority_NameEn_TxtBox.Text;
                UserPermissions.Selection = SelectionCmbx.SelectedIndex;
                bool isSuccess = await repo.Update(UserPermissions);
                if (isSuccess)
                {
                    popMessage($"تمت تعديل الصلاحيه {UserPermissions.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    await base.EditData();
                }
            }
            catch (Exception ex)
            {
                popMessage(ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                throw;
            }
        }
        public async override Task DeleteData()
        {
            if (MyHelper.IsFormOpen(typeof(MainMenuForm)))
            {
                MainMenuForm existingForm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                if (existingForm != null)
                {
                    if (existingForm.CustomMessage("هل تريد حذف البيانات؟", "نعم", "لا") == DialogResult.Yes)
                    {
                        bool isSuccess = await repo.Delete(UserPermissions);
                        if (isSuccess)
                        {
                            popMessage($"تم حذف الصلاحيه {UserPermissions.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            await base.DeleteData();
                        }
                    }
                }
            }

        }
        public async override Task LoadData(int ItemID)
        {
            UserPermissions userPermissions = await repo.GetById(ItemID);
            if (userPermissions != null)
            {
                ID_TxtBox.Text = userPermissions.Id.ToString();
                Authority_Name_TxtBox.Text = userPermissions.Name.ToString();
                Authority_NameEn_TxtBox.Text = userPermissions.NameEn.ToString()??"";
                UserPermissions = userPermissions;
                SelectionCmbx.SelectedIndex = userPermissions.Selection;
            }
            await base.LoadData(ItemID);
        }
        public override async Task Search_Data()
        {
            List<string> list = new List<string>() { "#", "الاسم", "الاسم ج"};
            List<string> Properties = new List<string>() { "ID", "Name", "NameEn"};

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<UserPermissions>(this, await repo.GetAll(), dataSource), 10);
            await base.Search_Data();
        }
    }
}
