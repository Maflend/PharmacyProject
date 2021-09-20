using PhamacyLibrary.Models;
using PharmacyForms.Controllers;
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

namespace PharmacyForms.Forms
{
    public partial class SignUpForm : Form
    {
        private  Form parentForm;
        private bool validLog;
        private bool validPass;
        public SignUpForm()
        {
            InitializeComponent();
        }
        public SignUpForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }
        private void tbTextChanged(object sender, EventArgs e) //Можно подумать как избавиться от дуближа
        {
            var tb = sender as TextBox;
            if (tb.Name == "tbLogin")
            {
                lblValidLogin.Text = "";
                if (!isValid(tbLogin.Text, FieldsError.Логин, out string ErrorMessageLogin1))
                {
                    lblValidLogin.Text = ErrorMessageLogin1;
                    validLog = false;
                }
                validLog = true;
            }
            if (tb.Name == "tbPassword")
            {
                lblValidPassword.Text = "";
                if (!isValid(tbPassword.Text, FieldsError.Пароль, out string ErrorMessagePassword1))
                {
                    lblValidPassword.Text = ErrorMessagePassword1;
                    validPass = false;
                }
                validPass = true;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User newUser = new User();
           
            if(validLog && validPass)
            {
                if (userController.isRegistered(tbLogin.Text))
                {
                    newUser.Login = tbLogin.Text;
                    newUser.Password = tbPassword.Text;
                    newUser.Role = Roles.Client;
                    userController.Post(newUser);
                    MessageBox.Show("Вы зарегистрированы!");
                    this.Close();
                }
                else
                {
                    lblValidLogin.Text = "Логин занят. Придумайте другой";
                }
            }
        }
       
        private bool isValid(string text, FieldsError field, out string ErrorMessage)
        {
            var input = text;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = field +" не должен быть пустым";
            }
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = field + " должен содержать хотябы одну прописную букву.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = field + " должен содержать хотябы одну заглавную букву.";
                return false;
            }
            else if (hasSymbols.IsMatch(input))
            {
                ErrorMessage = field + " не должен содержать спец. символы.";
                return false;
            }
            else
            {
                if (field == FieldsError.Пароль)
                {
                    var hasMiniMaxChars = new Regex(@".{8,20}");
                    if (!hasMiniMaxChars.IsMatch(input))
                    {
                        ErrorMessage = field + " должен содержать от 8 до 20 символов";
                        return false;
                    }
                    else if (!hasNumber.IsMatch(input))
                    {
                        ErrorMessage = field + " должен содержать хотябы одну цифру";
                        return false;
                    }
                }
                if (field == FieldsError.Логин)
                {
                    var hasMiniMaxChars = new Regex(@".{8,25}");
                    if (!hasMiniMaxChars.IsMatch(input))
                    {
                        ErrorMessage = field + " должен содержать от 8 до 25 символов";
                        return false;
                    }
                }
                return true;
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            parentForm.Hide();
            lblValidLogin.Text = "";
            lblValidPassword.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
