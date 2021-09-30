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
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            OrderController controller = new OrderController();
            var orders = controller.GetAll();
            if(orders !=null)
            {
                dgvOrders.DataSource = orders;
                dgvOrders.Columns["Id"].HeaderText = "Номер заказа";
                dgvOrders.Columns["User"].Visible = false;
                //dgvOrders.Columns["Sales"].Visible = false;
                dgvOrders.Columns["DateSale"].HeaderText = "Дата покупки";
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                Order order = new Order();
                order.Id = (int)dgvOrders.Rows[e.RowIndex].Cells[0].Value;
                order.DateSale = Convert.ToDateTime(dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString());
                PharmacyContext db = new PharmacyContext();
                var salesProduct = db.Sales.Where(s => s.Order.Id == order.Id).Select(s => new { s.Product.Name, s.Product.RetailPrice, s.Quantity }).ToList();
                if (salesProduct != null)
                {

                    dgvSales.DataSource = salesProduct;
                    dgvSales.Columns["Name"].HeaderText = "Наименование";
                    dgvSales.Columns["RetailPrice"].HeaderText = "Цена за шт";
                    dgvSales.Columns["Quantity"].HeaderText = "Количество купленного";
                }
            }
            
        }    
    }

   
    
}
