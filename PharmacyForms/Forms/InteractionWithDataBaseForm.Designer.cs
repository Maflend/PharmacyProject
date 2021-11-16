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
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.tbPathForBackUp = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseForBackUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(525, 480);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(144, 42);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Востановить базу";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(21, 480);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(144, 42);
            this.btnBackUp.TabIndex = 1;
            this.btnBackUp.Text = "Создать BackUp базы ";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // tbPathForBackUp
            // 
            this.tbPathForBackUp.Location = new System.Drawing.Point(305, 6);
            this.tbPathForBackUp.Name = "tbPathForBackUp";
            this.tbPathForBackUp.Size = new System.Drawing.Size(188, 23);
            this.tbPathForBackUp.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите путь куда хотите сохранить backup базы";
            // 
            // btnBrowseForBackUp
            // 
            this.btnBrowseForBackUp.Location = new System.Drawing.Point(499, 6);
            this.btnBrowseForBackUp.Name = "btnBrowseForBackUp";
            this.btnBrowseForBackUp.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForBackUp.TabIndex = 4;
            this.btnBrowseForBackUp.Text = "Обзор";
            this.btnBrowseForBackUp.UseVisualStyleBackColor = true;
            this.btnBrowseForBackUp.Click += new System.EventHandler(this.btnBrowseForBackUp_Click);
            // 
            // InteractionWithDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 534);
            this.Controls.Add(this.btnBrowseForBackUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbPathForBackUp);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnRestore);
            this.Name = "InteractionWithDataBaseForm";
            this.Text = "InteractionWithDataBaseForm";
            this.Load += new System.EventHandler(this.InteractionWithDataBaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.TextBox tbPathForBackUp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseForBackUp;
    }
}