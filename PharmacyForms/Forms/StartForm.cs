
using Microsoft.Data.SqlClient;
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
        public StartForm()
        {
            InitializeComponent();
        }
        public StartForm(Form form)
        {
            InitializeComponent();
            parentsForm = form;
        }
        private int? emergencyStart = null;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            emergencyStart = EmergencyStart();
            if (tbLogin.Text == "Admin" && tbPassword.Text == "Admin" && emergencyStart == 1)
            {
                CurrentUserStatic.Id = 0;
                CurrentUserStatic.Login = "Admin";
                CurrentUserStatic.Password = "Admin";
                CurrentUserStatic.Role = Roles.Admin;
                CurrentUserStatic.EmergencyStart = true;
                this.Close();
            }
            else if(emergencyStart == 1)
            {
                MessageBox.Show("База данных недоступна. Обратитесь к своему администратору");
            }
            else if(emergencyStart == 0)
            {
                UserController userController = new UserController();
                var u = userController.Login(tbLogin.Text, tbPassword.Text);
                if (u != null && u.Login == tbLogin.Text && u.Password == tbPassword.Text)
                {
                    CurrentUserStatic.Id = u.Id;
                    CurrentUserStatic.Login = u.Login;
                    CurrentUserStatic.Password = u.Password;
                    CurrentUserStatic.Role = u.Role;
                    CurrentUserStatic.EmergencyStart = false;
                    this.Close();
                }
                else
                    MessageBox.Show("Аккаунт не найден.\n Зарегистрируйтесь!");
            }
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(emergencyStart == null)
            {
                emergencyStart = EmergencyStart();
            }
            if (emergencyStart == 1)
            {
                MessageBox.Show("База данных недоступна. Обратитесь к своему администратору");
            }
            else
            {
                tbLogin.Text = "";
                tbPassword.Text = "";
                SignUpForm form = new SignUpForm(this);
                form.ShowDialog();
            }
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
            if (emergencyStart == null)
            {
                emergencyStart = EmergencyStart();
            }
            if (emergencyStart == 1)
            {
                MessageBox.Show("База данных недоступна. Обратитесь к своему администратору");
            }
            else
            {
                CurrentUserStatic.Login = "Гость";
                CurrentUserStatic.Role = Roles.Guest;
                this.Close();
            }
               
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


        private int EmergencyStart()
        {
            int res = 0;
            SqlConnection conWithMaster = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");

            try
            {
                conWithMaster.Open();
                string sqlquery = "USE MASTER IF db_id('PharmacyProject') IS  NULL CREATE DATABASE PharmacyProject";
                SqlCommand cmd = new SqlCommand(sqlquery, conWithMaster);
                cmd.ExecuteNonQuery();

                string sqlquery1 = "USE PharmacyProject IF object_id('Users') IS NULL SELECT 1 ELSE SELECT 0";
                SqlCommand cmd1 = new SqlCommand(sqlquery1, conWithMaster);
                res = int.Parse(cmd1.ExecuteScalar().ToString());
                return res;
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                conWithMaster.Close();
            }
            
        }
    }
}
