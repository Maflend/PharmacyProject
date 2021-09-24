﻿using PharmacyForms.Models;
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
    public partial class PurchaseForm : Form
    {
        private Product currentProduct;
        public PurchaseForm()
        {
            InitializeComponent();
        }
        public PurchaseForm(Product product)
        {
            InitializeComponent();
            currentProduct = product;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuantity.Text, out int quantity))
            {
                Product product = ContextStatic.PharmacyContext.Products.FirstOrDefault(i => i.Id == currentProduct.Id);
                Sale sale = new Sale() { Product = product, Quantity = quantity };
                ContextStatic.PharmacyContext.Sales.Add(sale);
               SaleStatic.Sales.Add(sale);
            }
            this.DialogResult = DialogResult.Retry;
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            lblProductName.Text = currentProduct.Name;
        }
    }
}
