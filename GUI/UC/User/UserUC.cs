using ColorOasisSystem.Entities;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ColorOasisSystem.GUI.UC
{
    public partial class UserUC : MasterUC
    {
        UserRepo repo;
        public UserUC()
        {
            InitializeComponent();
            User_Phone_TxtBox.AllowOnlyNumbers();
            InitializeDataAsync(); // Call the async method
        }

        private async void InitializeDataAsync()
        {
            PermissionRepo permissionRepo = new PermissionRepo();
            repo = new UserRepo();

            var permissions = await permissionRepo.GetAll();
            Userpermissioncmbx.DataSource = permissions;
            Userpermissioncmbx.DisplayMember = "Name";
            Userpermissioncmbx.ValueMember = "Id";
            Userpermissioncmbx.SelectedIndex = -1;
        }
        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Image_Capture = this.Username_Pic;
            var mainMenuForm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            mainMenuForm.Showing_Page_On_Screen(false, true, "Camera_Shot");
            mainMenuForm.Refresh();

        }
        public override void NewDataAsync()
        {            
            base.NewDataAsync();
        }
        public override async Task SaveDataAsync()
        {
            User user=new User();
            user.Name= User_NametxtBox.Text;
            user.NameEn= User_NametxtBox.Text;
            user.UserName= UserNameTxtBox.Text;
            user.RecoverWord = Hasher.Hash(Restore_Word_TxtBox.Text);
            user.Password = Hasher.Hash(Password_Txtbox.Text);
            user.UserPermissionId = (int)Userpermissioncmbx.SelectedValue;
            user.Phone = User_Phone_TxtBox.Text.Trim();
            user.Photo = ImageToByteArray(Username_Pic.Image, System.Drawing.Imaging.ImageFormat.Png);
            user.IsActive = true;
            user.IsDeleted = false;
            bool IsSuccess = await repo.Add(user);
            if (IsSuccess)
            {
                popMessage($"تمت اضافه مستخدم {user.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                await base.SaveDataAsync();
            }
        }
        public override Task EditData()
        {
            return base.EditData();
        }
        public override Task DeleteData()
        {
            return base.DeleteData();
        }
        public override Task Search_Data()
        {
            return base.Search_Data();
        }
        public override Task LoadData(int ItemID)
        {
            return base.LoadData(ItemID);
        }

        private void User_Phone_TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar)? true:false;
        }
    }
}
