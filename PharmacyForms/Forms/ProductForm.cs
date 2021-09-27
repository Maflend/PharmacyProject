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
        public ProductForm(Roles role, Categories category)
        {
            InitializeComponent();
            currentCategory = category;
            currentRole = role;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProduct.AllowUserToAddRows = false;
            SetDataGrid();
            AddButtonsInDataGridView();
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if(currentRole == Roles.Client || currentRole == Roles.Guest)
            {
                btnAddproduct.Visible = false;
            }
        }
        private void AddButtonsInDataGridView()
        {
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

            Product p = CreateProductFromRowInDataGridView(sender,e);
            Product currentProduct = new Product();
            if (p!=null)
            {
                currentProduct.Id = p.Id;
                currentProduct.Name = p.Name;
                currentProduct.Description = p.Description;
                currentProduct.Quantity = p.Quantity;
                currentProduct.PurchasingPrice = p.PurchasingPrice;
                currentProduct.RetailPrice = p.RetailPrice;
            }
            ProductController controller = new ProductController();
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Pay")
            {
                Product payProduct = controller.GetById(currentProduct.Id);
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
                    bool isDelete = controller.Delete(currentProduct.Id);
                    if (isDelete)
                    {
                        SetDataGrid();
                        MessageBox.Show("Удалено");
                    } 
                }
            }
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Update" && e.RowIndex < dgvProduct.RowCount)
            {
                UpdateProductForm upProductForm = new UpdateProductForm(currentProduct);
                if (upProductForm.ShowDialog() == DialogResult.OK)
                {
                    SetDataGrid();
                }
            }
        }
        private Product CreateProductFromRowInDataGridView(object sender,DataGridViewCellEventArgs e)
        {
            Product product = new Product();
            if (currentRole == Roles.Client)
            {
                if (dgvProduct.Rows[e.RowIndex].Cells != null)
                {
                    product.Id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    product.Name = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    product.Description = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                    product.Quantity = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
                    product.RetailPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString());
                    product.PurchasingPrice = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
                    return product;
                }
               
            }
            if (currentRole == Roles.Stuff || currentRole == Roles.Director || currentRole == Roles.Admin)
            {

                if (e.ColumnIndex >= 0 && e.ColumnIndex <= 2 && e.RowIndex >= 0)
                {
                    product.Id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                    product.Name = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                    product.Description = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                    product.Quantity = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
                    product.RetailPrice = Convert.ToDouble(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
                    product.PurchasingPrice = Convert.ToDouble(dgvProduct.Rows[e.RowIndex].Cells[8].Value.ToString());
                    return product;
                }
            }
            if (currentRole == Roles.Guest)
            {
                MessageBox.Show("Для покупки товара вам нужно зарегистрироваться. Смените пользователя для регистрации.");
                return new Product();
            }
            return new Product();
        }
        private void btnResetFindProduct_Click(object sender, EventArgs e)
        {
            tbFindName.Text = "";
            SetDataGrid();
        }

        private void tbFindName_TextChanged(object sender, EventArgs e)
        {
            var productName = tbFindName.Text;
            ProductController controller = new ProductController();
            List<Product> products = controller.FindByName(productName, currentCategory);
            if (products != null)
                dgvProduct.DataSource = products;
        }
    }
}
