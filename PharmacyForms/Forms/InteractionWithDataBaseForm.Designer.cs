namespace PharmacyForms.Forms
{
    partial class InteractionWithDataBaseForm
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
            this.tbPathForBackUp = new System.Windows.Forms.TextBox();
            this.tbPathForRestore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseForBackUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseForRestore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewConnectionString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPathForBackUp
            // 
            this.tbPathForBackUp.Location = new System.Drawing.Point(316, 173);
            this.tbPathForBackUp.Name = "tbPathForBackUp";
            this.tbPathForBackUp.Size = new System.Drawing.Size(295, 23);
            this.tbPathForBackUp.TabIndex = 2;
            // 
            // tbPathForRestore
            // 
            this.tbPathForRestore.Location = new System.Drawing.Point(316, 254);
            this.tbPathForRestore.Name = "tbPathForRestore";
            this.tbPathForRestore.Size = new System.Drawing.Size(295, 23);
            this.tbPathForRestore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите путь куда хотите сохранить backup базы";
            // 
            // btnBrowseForBackUp
            // 
            this.btnBrowseForBackUp.Location = new System.Drawing.Point(617, 173);
            this.btnBrowseForBackUp.Name = "btnBrowseForBackUp";
            this.btnBrowseForBackUp.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForBackUp.TabIndex = 4;
            this.btnBrowseForBackUp.Text = "Обзор";
            this.btnBrowseForBackUp.UseVisualStyleBackColor = true;
            this.btnBrowseForBackUp.Click += new System.EventHandler(this.btnBrowseForBackUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите путь к backup файлу для его востановления";
            // 
            // btnBrowseForRestore
            // 
            this.btnBrowseForRestore.Location = new System.Drawing.Point(617, 253);
            this.btnBrowseForRestore.Name = "btnBrowseForRestore";
            this.btnBrowseForRestore.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForRestore.TabIndex = 6;
            this.btnBrowseForRestore.Text = "Обзор";
            this.btnBrowseForRestore.UseVisualStyleBackColor = true;
            this.btnBrowseForRestore.Click += new System.EventHandler(this.btnBrowseForRestore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Укажите сервер для востановления БД ";
            // 
            // tbNewConnectionString
            // 
            this.tbNewConnectionString.Location = new System.Drawing.Point(316, 36);
            this.tbNewConnectionString.Name = "tbNewConnectionString";
            this.tbNewConnectionString.Size = new System.Drawing.Size(295, 23);
            this.tbNewConnectionString.TabIndex = 9;
            this.tbNewConnectionString.TextChanged += new System.EventHandler(this.tbNewConnectionString_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Пример: localhost\\SQLEXPRESS)";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestore.Location = new System.Drawing.Point(520, 480);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(182, 51);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Восстановить базу";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBackUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackUp.Location = new System.Drawing.Point(3, 480);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(182, 51);
            this.btnBackUp.TabIndex = 12;
            this.btnBackUp.Text = "Создать BackUp базы ";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // InteractionWithDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 534);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNewConnectionString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseForRestore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseForBackUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPathForRestore);
            this.Controls.Add(this.tbPathForBackUp);
            this.Name = "InteractionWithDataBaseForm";
            this.Text = "InteractionWithDataBaseForm";
            this.Load += new System.EventHandler(this.InteractionWithDataBaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPathForBackUp;
        private System.Windows.Forms.TextBox tbPathForRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseForBackUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseForRestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewConnectionString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackUp;
    }
}