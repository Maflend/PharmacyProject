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
            btnShowAdminMenu.Visible = false;
            btnProfile.Visible = false;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Для заполнения БД начальными данными
          // AddItemsInDataBase add = new AddItemsInDataBase();
          // add.Add();
            // ...
            startForm = new StartForm(this);
            startForm.ShowDialog();
            if (CurrentUserStatic.Login!= null)
                lblUserLogin.Text = CurrentUserStatic.Login;
            if(CurrentUserStatic.Role == Roles.Admin)
            {
                btnShowAdminMenu.Visible = true;
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
                }
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCategories);
            ActivateButton(sender);
            if(activeForm!= null)
                activeForm.Close();
            panelDesktop.Controls.Add(panelCenterLogo);
        }
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            CartForm cartForm = new CartForm();
            OpenChildForm(cartForm, sender);
            ActivateButton(sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ProfileForm profileForm = new ProfileForm();
            OpenChildForm(profileForm, sender);
            ActivateButton(sender);       
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
        public void hideSubMenu()
        {
            if (panelCategories.Visible == true)
                panelCategories.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnShowAdminMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new UserControlForm(),sender);
            ActivateButton(sender);
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new OrderHistoryForm(), sender);
            ActivateButton(sender);
        }
    }
}
