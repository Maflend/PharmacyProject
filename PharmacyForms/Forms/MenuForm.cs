﻿using PhamacyLibrary.Models;
using PharmacyForms.Forms;
using PharmacyForms.Models;
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
        private static User currentUser;

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
            SetName();
            if (currentUser != null)
                lblUserLogin.Text = currentUser.Login;
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
           // ActivateButton(btnSender);
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

        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new ProfileForm(), sender);
            ActivateButton(sender);
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
 
       
        private static void SetName()
        {
            //StartForm startForm = 
            startForm.ShowDialog();
            User user = new User();
            currentUser = startForm.GetUser();
            
        }

        private void btnOpenProductForm_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var buttonCategory = button.Text;
            Categories category = (Categories)Enum.Parse(typeof(Categories), buttonCategory);
            OpenChildForm(new ProductForm(currentUser.Role, category), sender);
        }
    }
}