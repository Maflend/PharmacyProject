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
    public partial class PurchaseForm : Form
    {
        private static Product currentProduct;
        public PurchaseForm()
        {
            InitializeComponent();
        }
        public PurchaseForm(Product product)
        {
            InitializeComponent();
            currentProduct = ContextStatic.PharmacyContext.Products.FirstOrDefault(i => i.Id == product.Id);
        }
       
        private void btnBuy_Click(object sender, EventArgs e)
        {


            if (int.TryParse(tbQuantity.Text, out int quantity))
            {
                if (quantity <= currentProduct.Quantity )
                {
                    if(SaleStatic.Sales != null && SaleStatic.Sales.Any(s=>s.Product == currentProduct))
                    {
                        for(int i=0; i<SaleStatic.Sales.Count();i++)
                        {
                            if(SaleStatic.Sales[i].Product.Id == currentProduct.Id)
                            {
                                SaleStatic.Sales[i].Quantity = quantity;
                            }
                        }
                    }
                    else
                    {
                        Sale sale = new Sale() { Product = currentProduct, Quantity = quantity };
                        //ContextStatic.PharmacyContext.Sales.Add(sale);
                        SaleStatic.Sales.Add(sale);
                    }

                   
                    this.DialogResult = DialogResult.Retry;
                }
                else
                {
                    MessageBox.Show($"Вы не можете купить товар в таком количестве. К покупке доступно: {currentProduct.Quantity} шт.");               
                }
                
            }
          
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            if(SaleStatic.Sales != null)
            {
                int tmp = SaleStatic.Sales.Where(s => s.Product.Id == currentProduct.Id).Sum(s => s.Quantity);
                tbQuantity.Text = tmp.ToString();
            }
            lblProductName.Text = currentProduct.Name;
        }
    }
}
