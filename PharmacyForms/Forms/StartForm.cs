
using PharmacyForms.Controllers;
using PharmacyForms.Forms;
using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyForms
{
    public partial class StartForm : Form
    {
        private bool isShowPassword = false;
        private Form parentsForm;
        public StartForm()
        {
            InitializeComponent();
        }
        public StartForm(Form form)
        {
            InitializeComponent();
            parentsForm = form;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            var u = userController.Login(tbLogin.Text, tbPassword.Text);
            if (u != null && u.Login == tbLogin.Text && u.Password == tbPassword.Text) 
            {
                CurrentUserStatic.Id = u.Id;
                CurrentUserStatic.Login = u.Login;
                CurrentUserStatic.Password = u.Password;
                CurrentUserStatic.Role = u.Role;
                this.Close();
            }
            else
                MessageBox.Show("Аккаунт не найден.\n Зарегистрируйтесь!");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            tbPassword.Text = "";
            SignUpForm form = new SignUpForm(this);
            form.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            if (SaleStatic.Sales != null)
                SaleStatic.Sales.Clear();
            lblValidLogin.Text = "";
            lblValidPassword.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            parentsForm.Close();
        }

        private void btnLoginAsGuest_Click(object sender, EventArgs e)
        {
            CurrentUserStatic.Login = "Гость";
            CurrentUserStatic.Role = Roles.Guest;
            this.Close();
        }

        private void rbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPasswordShow.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        


    }
}
}
