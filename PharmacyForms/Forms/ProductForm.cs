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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyForms
{
    public partial class ProductForm : Form
    {
        private Categories currentCategory;
        private Roles currentRole;
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Roles role,Categories category)
        {
            InitializeComponent();
            currentCategory = category;
            currentRole = role;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProduct.AllowUserToAddRows = false;
            SetDataGrid();
           
            DataGridViewButtonColumn buttonPay = new DataGridViewButtonColumn();
            DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn buttonUpdate = new DataGridViewButtonColumn();
            buttonPay.UseColumnTextForButtonValue = true;
            buttonDelete.UseColumnTextForButtonValue = true;
            buttonUpdate.UseColumnTextForButtonValue = true;
            buttonPay.Name = "Pay";
            buttonPay.Text = "Купить";
            dgvProduct.Columns.Add(buttonPay);
            if (currentRole == Roles.Stuff || currentRole == Roles.Director || currentRole == Roles.Admin)
            {
                buttonDelete.Name = "Delete";
                buttonDelete.Text = "Удалить";
                buttonUpdate.Name = "Update";
                buttonUpdate.Text = "Изменить";
                dgvProduct.Columns.AddRange(buttonDelete, buttonUpdate);
            }
        }
        private void SetDataGrid()
        {
            ProductController prod = new ProductController();
            var products = prod.GetByCategory(currentCategory);
            dgvProduct.DataSource = products;
            BindingSource source = new BindingSource();
            source.DataSource = products;
           
            dgvProduct.Columns["Name"].HeaderText = "Наименование";
            dgvProduct.Columns["Description"].HeaderText = "Описание";
            dgvProduct.Columns["Quantity"].HeaderText = "Количество";
            dgvProduct.Columns["RetailPrice"].HeaderText = "Цена";
            dgvProduct.Columns["PurchasingPrice"].HeaderText = "Закупочная цена";
            dgvProduct.Columns["Category"].Visible = false;
            dgvProduct.Columns["Id"].Visible = false;
            dgvProduct.Columns["PurchasingPrice"].Visible = false;
            if (currentRole == Roles.Director)
            {
                dgvProduct.Columns["PurchasingPrice"].Visible = false;
            }   
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)  // ОЧЕНЬ КРИВО НО РАБОТАЕТ
        {
            Product currentProduct = new Product();
            currentProduct.Id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
            currentProduct.Name = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            currentProduct.Description = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            currentProduct.Quantity = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
            currentProduct.PurchasingPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
            currentProduct.RetailPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[8].Value.ToString());

            ProductController controller = new ProductController();
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Pay") // Cells[0]
            {
                MessageBox.Show("Вы купили этот товар: " + dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Delete") // Cells[1]
            {
                if (MessageBox.Show("Подтвердите удаление записи","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    bool isDelete = controller.Delete(Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    if (isDelete)
                        MessageBox.Show("Удалено");
                }
               
            }
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Update") // Cells[2]
            {
                UpdateProductForm upProductForm = new UpdateProductForm(currentProduct);
                if (upProductForm.ShowDialog() == DialogResult.OK)
                {
                    SetDataGrid();
                }
            }
        }
    }
}
