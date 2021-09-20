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
        private Categories currentCategory;
        private Roles currentRole;
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Roles role,Categories category)
        {
            InitializeComponent();
            currentCategory = category;
            currentRole = role;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ЗАПОЛНИТЬ dgvProduct при загрузке. Вывод определенных дополнительных столбцов таблицы для конкретной роли происходит засчет проверки Role. А категории - Category
            label1.Text = currentCategory.ToString() + "    " + currentRole.ToString();
        }
    }
}
