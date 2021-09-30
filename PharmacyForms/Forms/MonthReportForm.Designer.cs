
namespace PharmacyForms.Forms
{
    partial class MonthReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.dgvReportProducts = new System.Windows.Forms.DataGridView();
            this.dtpOrdersDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(637, 499);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(19, 21);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "0";
            // 
            // dgvReportProducts
            // 
            this.dgvReportProducts.AllowUserToAddRows = false;
            this.dgvReportProducts.AllowUserToDeleteRows = false;
            this.dgvReportProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReportProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvReportProducts.Name = "dgvReportProducts";
            this.dgvReportProducts.ReadOnly = true;
            this.dgvReportProducts.RowTemplate.Height = 25;
            this.dgvReportProducts.Size = new System.Drawing.Size(704, 461);
            this.dgvReportProducts.TabIndex = 2;
            // 
            // dtpOrdersDate
            // 
            this.dtpOrdersDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpOrdersDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpOrdersDate.Location = new System.Drawing.Point(1, 463);
            this.dtpOrdersDate.Name = "dtpOrdersDate";
            this.dtpOrdersDate.Size = new System.Drawing.Size(208, 29);
            this.dtpOrdersDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(460, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прибыль за месяц:";
            // 
            // btnFindByDate
            // 
            this.btnFindByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnFindByDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFindByDate.Location = new System.Drawing.Point(1, 492);
            this.btnFindByDate.Name = "btnFindByDate";
            this.btnFindByDate.Size = new System.Drawing.Size(208, 44);
            this.btnFindByDate.TabIndex = 4;
            this.btnFindByDate.Text = "Показать";
            this.btnFindByDate.UseVisualStyleBackColor = false;
            this.btnFindByDate.Click += new System.EventHandler(this.btnFindByDate_Click);
            // 
            // MonthReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 534);
            this.Controls.Add(this.btnFindByDate);
            this.Controls.Add(this.dtpOrdersDate);
            this.Controls.Add(this.dgvReportProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalCost);
            this.Name = "MonthReportForm";
            this.Text = "MonthReportForm";
            this.Load += new System.EventHandler(this.MonthReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.DataGridView dgvReportProducts;
        private System.Windows.Forms.DateTimePicker dtpOrdersDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindByDate;
    }
}