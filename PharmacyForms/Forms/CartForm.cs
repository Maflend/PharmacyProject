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
            var sale = SaleStatic.Sales.Select(s=> new { Name = s.Product.Name, Description = s.Product.Description, Quantity = s.Quantity, Price = s.Product.RetailPrice }).ToList();
            dgvCart.DataSource=sale;
            dgvCart.Columns["Name"].HeaderText = "Наименование";
            dgvCart.Columns["Description"].HeaderText = "Описание";
            dgvCart.Columns["Quantity"].HeaderText = "Количество";
            dgvCart.Columns["Price"].HeaderText = "Цена";
            double total = 0;
            foreach(var tmp in sale)
            {
                total += tmp.Price;
            }
            lblTotalCost.Text = total.ToString(); 
        }
    }
}
