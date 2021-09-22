using PhamacyLibrary.Models;
using PharmacyForms.Controllers;
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
    public partial class UpdateProductForm : Form
    {
        private Product currentProduct;
        public UpdateProductForm()
        {
            InitializeComponent();
        }
        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            currentProduct = product;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductController controller = new ProductController();
            Product product = new Product();
            product.Id = currentProduct.Id;
            product.Name = tbName.Text;
            product.Quantity = Int32.Parse(tbQuantity.Text);
            product.Description = tbDescription.Text;
            product.RetailPrice = Int32.Parse(tbRetailPrice.Text);
            product.PurchasingPrice = Int32.Parse(tbPurchasingPrice.Text);
           
            bool isUpdate = controller.Update(product);
            if (isUpdate)
                MessageBox.Show("Изменения успешно сохранены");
            this.DialogResult = DialogResult.OK;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            tbName.Text = currentProduct.Name;
            tbQuantity.Text = currentProduct.Quantity.ToString();
            tbDescription.Text = currentProduct.Description;
            tbRetailPrice.Text = currentProduct.RetailPrice.ToString();
            tbPurchasingPrice.Text = currentProduct.PurchasingPrice.ToString();
            
        }
    }
}
