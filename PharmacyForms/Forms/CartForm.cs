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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }    
        private void CartForm_Load(object sender, EventArgs e)
        {
            SetData();
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (SaleStatic.Sales != null && lblTotalCost.Text != "0")
            {
                if (MessageBox.Show("Подтвердите покупку", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Order order = new Order() { DateSale = DateTime.Now };
                    OrderController controller = new OrderController();
                    if (controller.Post(order))
                    {
                        UpdateQuantityInProductsAfterSale();
                        SaleStatic.Sales = new List<Sale>();
                        MessageBox.Show("Продукт куплен");
                        SetData();
                    }
                }
            }
        }
        private void UpdateQuantityInProductsAfterSale()
        {
            ProductController controller = new ProductController();
            var products = SaleStatic.Sales.Select(s => s.Product).ToList();
            var sales = SaleStatic.Sales.Select(s => s).ToList();
            foreach(var sale in sales)
            {
                sale.Product.Quantity = sale.Product.Quantity - sale.Quantity;
                controller.Update(sale.Product);
            }
           
        }
        private void SetData()
        {
            if(SaleStatic.Sales != null)
            {
                var sale = SaleStatic.Sales.Select(s => new
                { Name = s.Product.Name, Description = s.Product.Description, Quantity = s.Quantity, Price = s.Product.RetailPrice }).ToList();
                dgvCart.DataSource = sale;
                dgvCart.Columns["Name"].HeaderText = "Наименование";
                dgvCart.Columns["Description"].HeaderText = "Описание";
                dgvCart.Columns["Quantity"].HeaderText = "Количество";
                dgvCart.Columns["Price"].HeaderText = "Цена";
                double total = 0;
                foreach (var tmp in sale)
                {
                    total += tmp.Price * tmp.Quantity;
                }
                lblTotalCost.Text = total.ToString();    
            }
            else
            {
                var sale = new { Name = "", Descriotion = "", Quantit = 0, Price = 0 };
                dgvCart.DataSource = sale;
                lblTotalCost.Text = "0";
            }
        }

        private void btnSaleClear_Click(object sender, EventArgs e)
        {
            SaleStatic.Sales = new List<Sale>();
            SetData();
        }
    }
}
