
using PhamacyLibrary.Models;
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
    
        private Form parentsForm;
        private User LogInUser;
        public StartForm()
        {
            InitializeComponent();
        }
        public StartForm(Form form)
        {
            InitializeComponent();
            parentsForm = form;
        }
        public User GetUser()
        {
            return LogInUser;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            var u = userController.Login(tbLogin.Text, tbPassword.Text);
            if (u != null && u.Login == tbLogin.Text && u.Password == tbPassword.Text) 
            {
                LogInUser = u;
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
            var u = new User() { Login = "Гость", Password = null, Role = Roles.Guest };
            LogInUser = u;
            this.Close();
        }
    }
}
