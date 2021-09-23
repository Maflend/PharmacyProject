using PharmacyForms.Models;
using PharmacyForms.Controllers;
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

namespace PharmacyForms
{
    public partial class ProductForm : Form
    {
        private Categories currentCategory;
        private Roles currentRole;
        public List<Sale> Sales = new List<Sale>();
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
                dgvProduct.Columns["PurchasingPrice"].Visible = true;
            }   
        }
      
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id=0; string name = null; string desc=null; int quant=0; double retailPrice=0; double publPrice=0;
            if(currentRole == Roles.Client)
            {
                 id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                 name = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                 desc = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                 quant = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
                 retailPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString());
                 publPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            if(currentRole == Roles.Stuff || currentRole == Roles.Director || currentRole == Roles.Admin)
            {
                id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                name = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                desc = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                quant = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
                retailPrice = Convert.ToDouble(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
                publPrice = Convert.ToDouble(dgvProduct.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            if(currentRole == Roles.Guest)
            {
                MessageBox.Show("Для покупки товара вам нужно зарегистрироваться. Смените пользователя для регистрации.");
            }
            Product currentProduct = new Product();
            currentProduct.Id = id;
            currentProduct.Name = name;
            currentProduct.Description = desc;
            currentProduct.Quantity = quant;
            currentProduct.PurchasingPrice = publPrice;
            currentProduct.RetailPrice = retailPrice;

            ProductController controller = new ProductController();
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Pay")
            {
                Product payProduct = controller.GetById(id);
                if (payProduct != null)
                {
                    PurchaseForm purchaseForm = new PurchaseForm(payProduct);
                    purchaseForm.ShowDialog();
                }
            }
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Подтвердите удаление записи","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    bool isDelete = controller.Delete(id);
                    if (isDelete)
                        MessageBox.Show("Удалено");
                }
            }
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Update")
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
