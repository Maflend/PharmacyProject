
namespace PharmacyForms.Forms
{
    partial class MenuForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.btnVitamins = new System.Windows.Forms.Button();
            this.btnAntibiotics = new System.Windows.Forms.Button();
            this.btnAntiviralAgent = new System.Windows.Forms.Button();
            this.btnPainReliever = new System.Windows.Forms.Button();
            this.btnAntipyretic = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnShoppingCart);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.panelCategories);
            this.panelMenu.Controls.Add(this.btnCategories);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoppingCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShoppingCart.Image = global::PharmacyForms.Properties.Resources.shopping_cart__1_;
            this.btnShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 385);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnShoppingCart.Size = new System.Drawing.Size(220, 60);
            this.btnShoppingCart.TabIndex = 5;
            this.btnShoppingCart.Text = "   Shopping cart";
            this.btnShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Image = global::PharmacyForms.Properties.Resources.value__1_;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 325);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(220, 60);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "   My profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelCategories
            // 
            this.panelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.panelCategories.Controls.Add(this.btnVitamins);
            this.panelCategories.Controls.Add(this.btnAntibiotics);
            this.panelCategories.Controls.Add(this.btnAntiviralAgent);
            this.panelCategories.Controls.Add(this.btnPainReliever);
            this.panelCategories.Controls.Add(this.btnAntipyretic);
            this.panelCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategories.Location = new System.Drawing.Point(0, 140);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(220, 185);
            this.panelCategories.TabIndex = 2;
            // 
            // btnVitamins
            // 
            this.btnVitamins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnVitamins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVitamins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVitamins.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVitamins.Location = new System.Drawing.Point(0, 144);
            this.btnVitamins.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnVitamins.Name = "btnVitamins";
            this.btnVitamins.Size = new System.Drawing.Size(220, 36);
            this.btnVitamins.TabIndex = 5;
            this.btnVitamins.Text = "Витамины";
            this.btnVitamins.UseVisualStyleBackColor = false;
            // 
            // btnAntibiotics
            // 
            this.btnAntibiotics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAntibiotics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntibiotics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntibiotics.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAntibiotics.Location = new System.Drawing.Point(0, 108);
            this.btnAntibiotics.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnAntibiotics.Name = "btnAntibiotics";
            this.btnAntibiotics.Size = new System.Drawing.Size(220, 36);
            this.btnAntibiotics.TabIndex = 4;
            this.btnAntibiotics.Text = "Антибиотики";
            this.btnAntibiotics.UseVisualStyleBackColor = false;
            // 
            // btnAntiviralAgent
            // 
            this.btnAntiviralAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAntiviralAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntiviralAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiviralAgent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAntiviralAgent.Location = new System.Drawing.Point(0, 72);
            this.btnAntiviralAgent.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnAntiviralAgent.Name = "btnAntiviralAgent";
            this.btnAntiviralAgent.Size = new System.Drawing.Size(220, 36);
            this.btnAntiviralAgent.TabIndex = 3;
            this.btnAntiviralAgent.Text = "Противовирусные";
            this.btnAntiviralAgent.UseVisualStyleBackColor = false;
            // 
            // btnPainReliever
            // 
            this.btnPainReliever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnPainReliever.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPainReliever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainReliever.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPainReliever.Location = new System.Drawing.Point(0, 36);
            this.btnPainReliever.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnPainReliever.Name = "btnPainReliever";
            this.btnPainReliever.Size = new System.Drawing.Size(220, 36);
            this.btnPainReliever.TabIndex = 2;
            this.btnPainReliever.Text = "Болеутоляющие";
            this.btnPainReliever.UseVisualStyleBackColor = false;
            // 
            // btnAntipyretic
            // 
            this.btnAntipyretic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAntipyretic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntipyretic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntipyretic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAntipyretic.Location = new System.Drawing.Point(0, 0);
            this.btnAntipyretic.Margin = new System.Windows.Forms.Padding(30);
            this.btnAntipyretic.Name = "btnAntipyretic";
            this.btnAntipyretic.Size = new System.Drawing.Size(220, 36);
            this.btnAntipyretic.TabIndex = 0;
            this.btnAntipyretic.Text = "Жаропонижающие";
            this.btnAntipyretic.UseVisualStyleBackColor = false;
            this.btnAntipyretic.Click += new System.EventHandler(this.btnOpenProductForm_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategories.Image = global::PharmacyForms.Properties.Resources.shopping_list;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 80);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(220, 60);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "   Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLogo.Location = new System.Drawing.Point(53, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(103, 29);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Pharma";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblUserLogin);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(720, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserLogin.Location = new System.Drawing.Point(585, 0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Padding = new System.Windows.Forms.Padding(0, 23, 20, 0);
            this.lblUserLogin.Size = new System.Drawing.Size(135, 53);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "UserName";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(720, 573);
            this.panelDesktop.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelCategories.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Button btnAntipyretic;
        private System.Windows.Forms.Button btnPainReliever;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Button btnVitamins;
        private System.Windows.Forms.Button btnAntibiotics;
        private System.Windows.Forms.Button btnAntiviralAgent;
    }
}