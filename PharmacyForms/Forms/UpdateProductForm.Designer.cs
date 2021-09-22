
namespace PharmacyForms.Forms
{
    partial class UpdateProductForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbRetailPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPurchasingPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(0, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 23);
            this.tbName.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(102, 48);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(136, 23);
            this.tbDescription.TabIndex = 2;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(102, 77);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(136, 23);
            this.tbQuantity.TabIndex = 2;
            // 
            // tbRetailPrice
            // 
            this.tbRetailPrice.Location = new System.Drawing.Point(102, 106);
            this.tbRetailPrice.Name = "tbRetailPrice";
            this.tbRetailPrice.Size = new System.Drawing.Size(136, 23);
            this.tbRetailPrice.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(62, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Описание";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 15);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Количество";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(3, 109);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(97, 15);
            this.lblRetailPrice.TabIndex = 1;
            this.lblRetailPrice.Text = "Цена розничная";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена оптовая";
            // 
            // tbPurchasingPrice
            // 
            this.tbPurchasingPrice.Location = new System.Drawing.Point(102, 135);
            this.tbPurchasingPrice.Name = "tbPurchasingPrice";
            this.tbPurchasingPrice.Size = new System.Drawing.Size(136, 23);
            this.tbPurchasingPrice.TabIndex = 2;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 225);
            this.Controls.Add(this.tbPurchasingPrice);
            this.Controls.Add(this.tbRetailPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(266, 264);
            this.MinimumSize = new System.Drawing.Size(266, 264);
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbRetailPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPurchasingPrice;
    }
}