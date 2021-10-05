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
    public partial class UpdateUserForm : Form
    {
        private User currentUser;
        public UpdateUserForm()
        {
            InitializeComponent();
        }
        public UpdateUserForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cbRoles.DataSource = Enum.GetValues(typeof(Roles));
                cbRoles.SelectedItem = currentUser.Role;
                tbLogin.Text = currentUser.Login;
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserController controller = new UserController();
            string ErrorMessage;
            if (isValid(tbLogin.Text, out ErrorMessage))
            {
                if ((Roles)cbRoles.SelectedItem == Roles.Guest)
                    MessageBox.Show("Пользователю нельзя назначить роль Guest");
                else
                {
                    user.Id = currentUser.Id;
                    user.Login = tbLogin.Text;
                    user.Password = currentUser.Password;
                    user.Role = (Roles)cbRoles.SelectedItem;
                    bool isUpdate = controller.Update(user);
                    if (isUpdate)
                    {
                        MessageBox.Show("Изменения приняты.");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Изменения не приняты.");
                }
            }
            else
                MessageBox.Show($"{ErrorMessage}");
           

        }
        private bool isValid(string login, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (!hasLowerChar.IsMatch(login))
            {
                ErrorMessage =  "Логин должен содержать хотябы одну прописную букву.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(login))
            {
                ErrorMessage = "Логин должен содержать хотябы одну заглавную букву.";
                return false;
            }
            else if (hasSymbols.IsMatch(login))
            {
                ErrorMessage = "Логин не должен содержать спец. символы.";
                return false;
            }
            else if (!(login.Length >= 4 && login.Length <= 15))
            {
                ErrorMessage = "Длина логина должна быть от 4 до 15 символов.";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(login))
            {
                ErrorMessage = "Логин не должен быть пустым.";
                return false;
            }
            return true;
            
        }

       
    }
}
