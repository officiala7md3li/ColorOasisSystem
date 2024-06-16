using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI.HelpingProgram;
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
    public partial class ClientUC : ColorOasisSystem.GUI.UC.MasterUC
    {
        ClientRepo ClassRepo;
        public ClientUC()
        {
            InitializeComponent();
            ClassRepo = new ClientRepo();
        }
        public override async void NewDataAsync()
        {
            base.NewDataAsync();
            List<Client> Clients = await ClassRepo.GetAll();
            guna2ComboBox1.DataSource=Clients;
            guna2ComboBox1.DisplayMember = "Name";
            guna2ComboBox1.ValueMember = "ID";
        }
        public override async Task SaveDataAsync()
        {
            if (!ValidateString(Customer_Name_TxtBox, "يرجى إدخال اسم العميل")) return;
            if (!ValidateString(Customer_Phone_TxtBox, "يرجى إدخال رقم هاتف العميل")) return;
            if (!ValidateString(Customer_Address_TxtBox, "يرجى إدخال عنوان العميل")) return;
            try
            {
                Client client = new Client();
                client.Name = Customer_Name_TxtBox.Text;
                client.Phone = Customer_Phone_TxtBox.Text;
                client.Address = Customer_Address_TxtBox.Text;
                bool isSuccess=await ClassRepo.Add(client);
                if (isSuccess)
                {
                    popMessage($"تمت اضافه العميل {client.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
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
            await base.SaveDataAsync();
        }
        public override async Task EditData()
        {
            if (!ValidateString(Customer_Name_TxtBox, "يرجى إدخال اسم العميل")) return;
            if (!ValidateString(Customer_Phone_TxtBox, "يرجى إدخال رقم هاتف العميل")) return;
            if (!ValidateString(Customer_Address_TxtBox, "يرجى إدخال عنوان العميل")) return;
            try
            {
                Client client = new Client();
                client.Id = Convert.ToInt32(ID_TxtBox.Text);
                client.Name = Customer_Name_TxtBox.Text;
                client.Phone = Customer_Phone_TxtBox.Text;
                client.Address = Customer_Address_TxtBox.Text;
                client.Id = Convert.ToInt32(ID_TxtBox.Text);
                bool isSuccess = await ClassRepo.Update(client);
                if (isSuccess)
                {
                    popMessage($"تمت اضافه العميل {client.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
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
                        Client client = new Client();
                        client.Id = Convert.ToInt32(ID_TxtBox.Text);
                        client.Name = Customer_Name_TxtBox.Text;
                        client.Phone = Customer_Phone_TxtBox.Text;
                        client.Address = Customer_Address_TxtBox.Text;
                        bool isSuccess = await ClassRepo.Delete(client);
                        if (isSuccess)
                        {
                            popMessage($"تم حذف العميل {client.Name}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        }

                        await base.DeleteData();
                    }

                }
            }

        }
        public override async Task Search_Data()
        {
            //todo:Change it for all screens
            List<string> list = new List<string>() { "#", "الاسم", "العنوان", "رقم الهاتف" };
            List<string> Properties = new List<string>() { "ID", "Name", "Address", "Phone" };

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < Properties.Count; i++)//DisplayAvailableProperties<Model.Branch>()
            {
                //dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = Properties[i] });
            }

            var frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();

            new WaitLoaderForm(frm, new SreachForm<Client>(this,await ClassRepo.GetAll(), dataSource), 10);

            await base.Search_Data();
        }

        public override async Task LoadData(int ItemID)
        {
            Client ChosenClient = new Client();
            ChosenClient =await ClassRepo.GetById(ItemID);
            ID_TxtBox.Text = ChosenClient.Id.ToString();
            Customer_Name_TxtBox.Text = ChosenClient.Name.ToString();
            Customer_Phone_TxtBox.Text = ChosenClient.Phone.ToString();
            Customer_Address_TxtBox.Text = ChosenClient.Address.ToString();
            await base.LoadData(ItemID);
        }

    }
}
