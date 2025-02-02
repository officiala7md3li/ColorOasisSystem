using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using static System.Net.WebRequestMethods;
using ColorOasisSystem.Entities;

namespace ColorOasisSystem.GUI.UC
{
    public partial class MasterUC : UserControl
    {

        public MasterUC()
        { 
            InitializeComponent();
        }
        public void SetPermissions(Permission permission)
        {
            MasterUCLock=!permission.Lock;
            NewBtnVisible = permission.AddNew;
            SaveBtnVisible= permission.AddNew;
            EditBtnVisible=permission.Edit;
            DeleteBtnVisible=permission.Delete;
            SearchBtnVisible=permission.Retrive;
            SaveAsBtnVisible = permission.Additional;
            Refresh();
            Invalidate();
        }
        public bool Modified { get; set; } = false;
        private bool masterUCLockValue = true;
        public bool MasterUCLock
        {
            get { return masterUCLockValue; }
            set
            {
                masterUCLockValue = value;
                DisableLockBtn.Visible = value;
                if (value)
                    DisableLockBtn.BringToFront();
                Invalidate();
            }
        }
        public Image Logoimage
        {
            get
            { return LogoPic.Image; }
            set
            {
                LogoPic.Image = value;
                Invalidate();
                MyHelper.CenterControlsOnScreen(this.Width,LogoLbl ,LogoPic );
                LogoPic.Refresh();
            }
        }
        public string LogoLabel
        {
            get { return LogoLbl.Text; }
            set
            {
                //logoLabel = value;
                LogoLbl.Text = value;
                MyHelper.CenterControlsOnScreen(this.Width,LogoLbl, LogoPic );
                Invalidate();
            }
        }
        public string SaveAsLabel
        {
            get { return Save_As_Btn.Text; }
            set
            {
                //logoLabel = value;
                Save_As_Btn.Text = value;
                Invalidate();
            }
        }
        private bool edit_ = false;
        public bool EditDataCheck
        {
            get { return edit_; }
            set
            {
                edit_ = value;
                Invalidate();
            }
        }

        #region Main Buttons Visible
        private bool newBtnVisible_ = true;
        public bool NewBtnVisible
        {
            get { return newBtnVisible_; }
            set
            {
                newBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool saveBtnVisible_ = false;
        public bool SaveBtnVisible
        {
            get { return saveBtnVisible_; }
            set
            {
                saveBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool editBtnVisible_ = false;
        public bool EditBtnVisible
        {
            get { return editBtnVisible_; }
            set
            {
                editBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool deleteBtnVisible_ = false;
        public bool DeleteBtnVisible
        {
            get { return deleteBtnVisible_; }
            set
            {
                deleteBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool searchBtnVisible_ = false;
        public bool SearchBtnVisible
        {
            get { return searchBtnVisible_; }
            set
            {
                searchBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool saveAsVisible_ = false;
        public bool SaveAsBtnVisible
        {
            get { return saveAsVisible_; }
            set
            {
                saveAsVisible_ = value;
                Invalidate();
            }
        }
        #endregion

        public virtual async Task BackAction() 
        {
            if (Properties.Settings.Default.AfterClose) NewDataAsync();
        }

        public virtual void NewDataAsync()
        {
            EditDataCheck = false;
            foreach (Control ctrl in Controls)
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

        public virtual async Task LoadData(int ItemID) 
        { 
            EditDataCheck = true;
        }

        public virtual async Task ZoomData() { }

        public virtual async Task SetData() { }

        public virtual async Task SaveDataAsync()
        {
            //popMessage("تمت عملية حفظ البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            NewDataAsync();
        }

        public virtual async Task EditData()
        {
            //popMessage("تمت عملية التعديل على البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            EditDataCheck = false;
            NewDataAsync();
        }

        public virtual async Task DeleteData()
        {
            //popMessage("تمت عملية حذف البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            NewDataAsync();
        }

        public virtual async Task SaveAsData()
        {
            //popMessage(  "تمت عملية حفظ البيانات خارجياً بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
        }
        public virtual async Task Search_Data()
        {
           // Wait_Loader_Form.TransparentBG(Main_Menu, Search_Form, Main_Menu.Form_Dock.BorderRadius);
        }

        public virtual async Task EnableChanged() { }

        public virtual async Task DisableChanged()
        {

        }
        public virtual async Task SizeChangedAsync()
        {

        }
        private void DisableLockBtn_Click(object sender, EventArgs e)
        {


            popMessage("لا تمتلك الصلاحيه الكافيه لمعاينه الشاشه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
        }

        #region "Change Enable and visible Properties"
        void ChangeEnableOptions(bool newEnable = true, bool saveEnable = true, bool editEnable = true, bool deleteEnable = true, bool searchEnable = true)
        {
            New_Btn.Enabled = NewBtnVisible;
            Save_Btn.Enabled = SaveBtnVisible;
            if (edit_)
            {
                Save_Btn.Enabled = EditBtnVisible;
            }
            Save_As_Btn.Enabled = saveAsVisible_;
            if (edit_)
            {
                Delete_Btn.Enabled = DeleteBtnVisible;
            }
            Search_Btn.Enabled = SearchBtnVisible;
        }

        void ChangeVisibilityOptions(bool visibility = true)
        {
            New_Btn.Visible = NewBtnVisible;
            Save_Btn.Visible = SaveBtnVisible;
            if (edit_) Save_Btn.Visible = EditBtnVisible;
            if (edit_) Delete_Btn.Visible = DeleteBtnVisible;
            Delete_Btn.Location = Guna2Button3.Location;
            Save_As_Btn.Location = Guna2Button2.Location;
            Search_Btn.Location = Guna2Button1.Location;
            if (!edit_)
            {
                Save_As_Btn.Location = Search_Btn.Location;
                Search_Btn.Location = Delete_Btn.Location;
                if (!deleteBtnVisible_)
                {
                    Save_As_Btn.Location = Search_Btn.Location;
                    Search_Btn.Location = Delete_Btn.Location;
                }
            }
            else if (edit_ && !editBtnVisible_)
            {
                Save_As_Btn.Location = Guna2Button1.Location;
                Search_Btn.Location = Guna2Button3.Location;
                Delete_Btn.Location = Save_Btn.Location;
            }
            Search_Btn.Visible = SearchBtnVisible;
            if (edit_) Save_As_Btn.Visible = saveAsVisible_;
        }
        #endregion
        #region Showing Action Buttons
        private void Option_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                BringFront();
                ChangeVisibilityOptions();
                A2SAnimator1.StandardAnimate(New_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Save_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Delete_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Search_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Save_As_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Options_Tmr.Start();
                Refresh();
                //Cursor.Position = new Point((Main_Menu.DesktopLocation.X) + (Location.X) + (New_Btn.Location.X) + (New_Btn.Size.Width / 2), (Main_Menu.DesktopLocation.Y) + (Location.Y) + (New_Btn.Location.Y) + (New_Btn.Size.Height / 2));
                Cursor.Position = new Point(New_Btn.Parent.PointToScreen(New_Btn.Location).X + (New_Btn.Size.Width / 2), New_Btn.Parent.PointToScreen(New_Btn.Location).Y + (New_Btn.Size.Height / 2));
            }
            catch (Exception ex)
            {
            }
        }
        private void BringFront()
        {
            New_Btn.BringToFront();
            Save_Btn.BringToFront();
            Save_As_Btn.BringToFront();
            Delete_Btn.BringToFront();
            Search_Btn.BringToFront();
        }
        private void Options_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                Options_Tmr.Stop();
                A2SAnimator1.StandardAnimate(New_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                New_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Save_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Save_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Save_As_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Save_As_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Delete_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Delete_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Search_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Search_Btn.Visible = false;
            }
            catch (Exception ex)
            {
                New_Btn.Visible = false;
                Save_Btn.Visible = false;
                Save_As_Btn.Visible = false;
                Delete_Btn.Visible = false;
                Search_Btn.Visible = false;
            }
        }

        private void Action_Buttons_MouseLeave(object sender, EventArgs e)
        {
            Options_Tmr.Start();
        }

        private void Action_Buttons_MouseHover(object sender, EventArgs e)
        {
            Options_Tmr.Stop();
        }
        #endregion

        #region "Actions Buttons Click Properties"
        private void New_Btn_Click(object sender, EventArgs e)
        {
            NewDataAsync();
        }

        private async void Save_Btn_Click(object sender, EventArgs e)
        {
            if (!edit_)
            {
                await SaveDataAsync();
            }
            else
            {
                await EditData();
                EditDataCheck = false;
            }
        }

        private async void Delete_Btn_Click(object sender, EventArgs e)
        {
            await DeleteData();
        }

        private async void Search_Btn_Click(object sender, EventArgs e)
        {
            await Search_Data();
        }
        private async void Save_As_Btn_Click(object sender, EventArgs e)
        {
            await SaveAsData();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Enabled = false;
            //My.Settings.Previous_UC = this;
            //My.MySettings.Default.Previous_UC = this;
            //My.Settings.Save();
            BackAction();
        }

        private void Master_UC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (Save_Btn.Enabled)
                {
                    Save_Btn.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                New_Btn.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (Delete_Btn.Enabled)
                {
                    Delete_Btn.PerformClick();
                }
            }

            else if (e.KeyCode == Keys.F4)
            {
                if (Search_Btn.Enabled)
                {
                    Search_Btn.PerformClick();
                }
            }
            else if (e.KeyCode==Keys.F5)
            {
                if (Save_As_Btn.Enabled) Save_As_Btn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Back_Button.PerformClick();
            }
        }

        private void Master_UC_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                EnableChanged();
            }
            else
            {
                if (Properties.Settings.Default.EnableUC)
                {
                    DisableChanged();
                }
            }
        }

        private void Disable_Lock_Btn_Click(object sender, EventArgs e)
        {


            popMessage( "لا تمتلك الصلاحيه الكافيه لمعاينه الشاشه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
        }

        #endregion

        private async void MasterUC_SizeChanged(object sender, EventArgs e)
        {
            if (masterUCLockValue)
            {
                DisableLockBtn.Dock = DockStyle.Fill;
                DisableLockBtn.BringToFront();
                Back_Button.BringToFront();
            }
            await SizeChangedAsync();
            Option_Btn.Location = new Point(this.Size.Width-52,this.Size.Height-39);
            if (!(this.Size.Height> 550))
            {
                New_Btn.Location = new Point(New_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Save_Btn.Location = new Point(Save_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Delete_Btn.Location = new Point(Delete_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Search_Btn.Location = new Point(Search_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Guna2Button1.Location = new Point(Guna2Button1.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Guna2Button3.Location = new Point(Guna2Button3.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Guna2Button2.Location = new Point(Guna2Button2.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Save_As_Btn.Location = new Point(Save_As_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
            }
        }
        public List<T> SearchByProperty<T>(List<T> sourceList, string searchProperty, string searchValue)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(searchProperty, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
            {
                popMessage($"Property '{searchProperty}' not found.",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return new List<T>();
            }

            return sourceList.Where(x => propertyInfo.GetValue(x)?.ToString()?.Contains(searchValue) == true).ToList();
        }
        public List<string> DisplayAvailableProperties<T>()
        {
            List<string> result = new List<string>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                result.Add(property.Name);
            }
            return result;
        }
        public bool ValidateString(Guna.UI2.WinForms.Guna2TextBox textBox,string ErrorCaption)
        {
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                
                popMessage(  ErrorCaption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                textBox.Focus();
                textBox.Select();
                return false;
            }
            return true;
        }
        public bool ValidateString(Guna.UI2.WinForms.Guna2ComboBox comboBox, string ErrorCaption)
        {
            if (string.IsNullOrEmpty(comboBox.Text) || string.IsNullOrWhiteSpace(comboBox.Text)|| comboBox.SelectedValue==null || comboBox.SelectedIndex<0)
            {

                popMessage(ErrorCaption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                comboBox.Focus();
                comboBox.Select();
                comboBox.DroppedDown = true;
                return false;
            }
            return true;
        }
        public bool ValidateStringD(Guna.UI2.WinForms.Guna2ComboBox comboBox, string ErrorCaption)
        {
            if (string.IsNullOrEmpty(comboBox.Text) || string.IsNullOrWhiteSpace(comboBox.Text) || comboBox.SelectedIndex < 0)
            {

                popMessage(ErrorCaption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                comboBox.Focus();
                comboBox.Select();
                comboBox.DroppedDown = true;
                return false;
            }
            return true;
        }
        public virtual void popMessage(string Caption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes, int timerDelay=5)
        {
            MainMenuForm MainForm_Var= Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            MyHelper.SnackbarShow(MainForm_Var, MainForm_Var.Snackbar, Caption, messageTypes, timerDelay);
        }
        #region Picture Add to SQL

        public static byte[] ImageToByteArray(Image image, ImageFormat format)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            using (var ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                throw new ArgumentNullException(nameof(byteArray));

            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        #endregion

        private void MasterUC_Load(object sender, EventArgs e)
        {

        }

    }
}
