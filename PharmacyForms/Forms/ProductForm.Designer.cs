
namespace PharmacyForms
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.btnResetFindProduct = new System.Windows.Forms.Button();
            this.tbFindName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddproduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActionBar.Controls.Add(this.label2);
            this.panelActionBar.Controls.Add(this.cbOrderBy);
            this.panelActionBar.Controls.Add(this.btnResetFindProduct);
            this.panelActionBar.Controls.Add(this.tbFindName);
            this.panelActionBar.Controls.Add(this.label1);
            this.panelActionBar.Controls.Add(this.btnAddproduct);
            this.panelActionBar.Location = new System.Drawing.Point(0, 0);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(704, 119);
            this.panelActionBar.TabIndex = 2;
            // 
            // btnResetFindProduct
            // 
            this.btnResetFindProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnResetFindProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetFindProduct.Location = new System.Drawing.Point(303, 25);
            this.btnResetFindProduct.Name = "btnResetFindProduct";
            this.btnResetFindProduct.Size = new System.Drawing.Size(75, 36);
            this.btnResetFindProduct.TabIndex = 3;
            this.btnResetFindProduct.Text = "Сброс";
            this.btnResetFindProduct.UseVisualStyleBackColor = false;
            this.btnResetFindProduct.Click += new System.EventHandler(this.btnResetFindProduct_Click);
            // 
            // tbFindName
            // 
            this.tbFindName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFindName.Location = new System.Drawing.Point(10, 27);
            this.tbFindName.Name = "tbFindName";
            this.tbFindName.Size = new System.Drawing.Size(287, 34);
            this.tbFindName.TabIndex = 2;
            this.tbFindName.TextChanged += new System.EventHandler(this.tbFindName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название лекарства";
            // 
            // btnAddproduct
            // 
            this.btnAddproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddproduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddproduct.Location = new System.Drawing.Point(519, 65);
            this.btnAddproduct.Name = "btnAddproduct";
            this.btnAddproduct.Size = new System.Drawing.Size(182, 51);
            this.btnAddproduct.TabIndex = 0;
            this.btnAddproduct.Text = "Добавить товар";
            this.btnAddproduct.UseVisualStyleBackColor = false;
            this.btnAddproduct.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(0, 144);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(704, 388);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Location = new System.Drawing.Point(176, 65);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(121, 23);
            this.cbOrderBy.TabIndex = 4;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.cbOrderBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сортировать по :\r\n";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 534);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panelActionBar);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAddproduct;
        private System.Windows.Forms.TextBox tbFindName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetFindProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrderBy;
    }
}

