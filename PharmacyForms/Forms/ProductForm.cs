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

namespace PharmacyForms
{
    public partial class ProductForm : Form
    {
        private Categories Categories;
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Categories categories)
        {
            InitializeComponent();
            Categories = categories;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ЗАПОЛНИТЬ dgvProduct при загрузке. Вывод определенных дополнительных столбцов таблицы для конкретной роли происходит засчет проверки Caterogies. 
        }
    }
}
