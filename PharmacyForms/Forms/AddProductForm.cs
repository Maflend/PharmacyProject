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
    public partial class AddProductForm : Form
    {
        private Categories currentCategory;
        public AddProductForm(Categories categories)
        {
            currentCategory = categories;
            InitializeComponent();
        }
        private Product product = new Product();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                ProductController controller = new ProductController();
                var isAdd = controller.Post(product);
                if (isAdd)
                {
                    MessageBox.Show("Продукт успешно добавлен");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Продукт не добавлен");
            }
            else
                MessageBox.Show("Данные заполнены не корректно");
        }
        private bool isValid()
        {
            product.Name = tbName.Text;
            product.Description = tbDescription.Text;
            product.Category = new Category() {Categories = currentCategory };
            if (double.TryParse(tbPurchasingPrice.Text, out double purPrice) && double.TryParse(tbRetailPrice.Text, out double retPrice) && int.TryParse(tbQuantity.Text, out int quantity))
            {
                if (purPrice <= retPrice)
                {
                    product.PurchasingPrice = purPrice;
                    product.RetailPrice = retPrice;
                    product.Quantity = quantity;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
