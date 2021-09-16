
using PharmacyForms.Controllers;
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

namespace PharmacyForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }
       
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            var u = userController.Login(tbLogin.Text, tbPassword.Text);
            if(u != null) // Переход на соответствующие формы
            {
                if(u.Role == Roles.Admin)
                {
                    MessageBox.Show("Admin");
                }
                if (u.Role == Roles.Client)
                {
                    MessageBox.Show("Client");
                }
                if (u.Role == Roles.Stuff)
                {
                    MessageBox.Show("Stuff");
                }
                if (u.Role == Roles.Director)
                {
                    MessageBox.Show("Director");
                }
            }       
            else
                MessageBox.Show("Аккаунт не найден.\n Зарегистрируйтесь!");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        { 
            
        }
    }
}
