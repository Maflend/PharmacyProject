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

namespace PharmacyForms.Forms
{
    public partial class UserControlForm : Form
    {
        public UserControlForm()
        {
            InitializeComponent();
        }
        private void UserControlForm_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnUpdate.UseColumnTextForButtonValue = true;
            btnDelete.UseColumnTextForButtonValue = true;
            btnUpdate.Text = "Изменить";
            btnUpdate.Name = "Update";
            btnDelete.Text = "Удалить";
            btnDelete.Name = "Delete";
            dgvUsers.Columns.AddRange(btnUpdate, btnDelete);

        }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = CreateUserFromRowInDataGridView(sender,e);
            if(dgvUsers.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateUserForm updateUserForm = new UpdateUserForm(user);
                updateUserForm.ShowDialog();
                SetDataGrid();
            }
        }
        private void SetDataGrid()
        {
            UserController controller = new UserController();
            var users = controller.GetAll();
            dgvUsers.DataSource = users;
            dgvUsers.Columns["Login"].HeaderText = "Логин";
            dgvUsers.Columns["Role"].HeaderText = "Роль";
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["Id"].Visible = false;

        }
        private User CreateUserFromRowInDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString());
            user.Login = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            user.Password = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
            user.Role = (Roles)dgvUsers.Rows[e.RowIndex].Cells[5].Value;
            return user;
        }
       
    }
}
