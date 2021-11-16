using PharmacyForms.Models;
using PharmacyForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace PharmacyForms.Forms
{
    public partial class MenuForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        static StartForm startForm;
        public MenuForm()
        {
            InitializeComponent();
            random = new Random();
            panelCategories.Visible = false;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Для заполнения БД начальными данными
           //AddItemsInDataBase add = new AddItemsInDataBase();
           //add.Add();
            // ...
            startForm = new StartForm(this);
            startForm.ShowDialog();
            if (CurrentUserStatic.Login!= null)
                lblUserLogin.Text = CurrentUserStatic.Login;
            VisibleElements();
        }
        private void VisibleElements()
        {
            if (CurrentUserStatic.Role == Roles.Guest || CurrentUserStatic.Role == Roles.Employee)
            {
                btnOrderHistory.Visible = false;
                btnShoppingCart.Visible = false;
                btnShowAdminMenu.Visible = false;
                btnMonthReport.Visible = false;
            }
            if (CurrentUserStatic.Role == Roles.Admin)
            {
                btnCategories.Visible = false;
                btnOrderHistory.Visible = false;
                btnShoppingCart.Visible = false;
                btnMonthReport.Visible = false;
                btnShowTutorial.Visible = false;
                btnChangeUser.Dock = DockStyle.Bottom;
            }
            if (CurrentUserStatic.Role == Roles.Director)
            {
                btnOrderHistory.Visible = false;
                btnShoppingCart.Visible = false;
                btnShowAdminMenu.Visible = false;
            }
            if (CurrentUserStatic.Role == Roles.Client)
            {
                btnShowAdminMenu.Visible = false;
                btnMonthReport.Visible = false;
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count());
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count());
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    btnChangeUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    btnShowTutorial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void btnOpenProductForm_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var buttonCategoryName = button.Text;
            Categories category = (Categories)Enum.Parse(typeof(Categories), buttonCategoryName);
            OpenChildForm( new ProductForm(CurrentUserStatic.Role, category), sender);
        }
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
        public void HideSubMenu()
        {
            if (panelCategories.Visible == true)
                panelCategories.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

       
        private void OpenChildForm_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (((Button)sender).Name == "btnCategories")
            {
                ShowSubMenu(panelCategories);
                if (activeForm != null)
                    activeForm.Close();
                panelDesktop.Controls.Add(panelCenterLogo);
            }
            if(((Button)sender).Name == "btnShoppingCart")
            {  
                OpenChildForm(new CartForm(), sender);
            }
            if(((Button)sender).Name == "btnShowAdminMenu")
            {
                OpenChildForm(new UserControlForm(), sender);
            }
            if(((Button)sender).Name == "btnMonthReport")
            {        
                OpenChildForm(new MonthReportForm(), sender);      
            }
            if(((Button)sender).Name == "btnOrderHistory")
            {     
                OpenChildForm(new OrderHistoryForm(), sender);
            }
            ActivateButton(sender);

        }

        private void btnShowTutorial_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tutorials = new Dictionary<string, string>();
            string path = "Resources\\TutorialForApplication.json";
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string jsonString = File.ReadAllText(path, Encoding.GetEncoding(1251));
            
            tutorials = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
            var tutorial = tutorials.Where(t => t.Key == CurrentUserStatic.Role.ToString()).FirstOrDefault();
            MessageBox.Show(tutorial.Value, "Справка по пользованию.");


            //foreach (var tutorial in tutorials)
            //{
            //    if(tutorial.Key == CurrentUserStatic.Role.ToString())
            //        MessageBox.Show(tutorial.Value, "Справка по пользованию.");
            //}
            
        }
    }
}
