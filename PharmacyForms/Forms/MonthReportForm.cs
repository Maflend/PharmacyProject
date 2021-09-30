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
    public partial class MonthReportForm : Form
    {
        public MonthReportForm()
        {
            InitializeComponent();
           
        }

        private void btnFindByDate_Click(object sender, EventArgs e)
        {
            var days = DateTime.DaysInMonth(dtpOrdersDate.Value.Year, dtpOrdersDate.Value.Month);
            var beginningOfPeriod = dtpOrdersDate.Value.AddDays(-days);
            var endOfPeriod = dtpOrdersDate.Value;

           
            PharmacyContext db = new PharmacyContext();
            var productsWithQuantitySale = db.Sales.Where(s => s.Order.DateSale <= endOfPeriod && s.Order.DateSale >= beginningOfPeriod)
                .Select(s => new { Category = s.Product.Category.Categories, Name = s.Product.Name, Description = s.Product.Description, Quantity = s.Quantity, Price = s.Product.RetailPrice - s.Product.PurchasingPrice })
                .OrderBy(s => s.Category)
                .ToList();
            if (productsWithQuantitySale != null)
            {   
                 var groupProducts = productsWithQuantitySale
                      .GroupBy(p => p.Name)
                      .Select(g => new { Category = g.First().Category, Name = g.Key,Description = g.First().Description, Quantity = g.Sum(i => i.Quantity), Price = g.First().Price})
                      .ToList();
                 
                dgvReportProducts.DataSource = groupProducts;
                dgvReportProducts.Columns["Category"].HeaderText = "Категория";
                dgvReportProducts.Columns["Name"].HeaderText = "Наименование";
                dgvReportProducts.Columns["Description"].HeaderText = "Описание";
                dgvReportProducts.Columns["Quantity"].HeaderText = "Кол-во купленного";
                dgvReportProducts.Columns["Price"].HeaderText = "Выручка за шт";
                lblTotalCost.Text = productsWithQuantitySale.Sum(p => p.Price).ToString();
            }
            
            

        }

        private void MonthReportForm_Load(object sender, EventArgs e)
        {
            dtpOrdersDate.Format = DateTimePickerFormat.Custom;
            dtpOrdersDate.CustomFormat = "MMMM yyyy";
            dtpOrdersDate.ShowUpDown = true;
        }
    }
}
