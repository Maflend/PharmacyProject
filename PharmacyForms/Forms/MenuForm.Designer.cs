
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
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnMonthReport = new System.Windows.Forms.Button();
            this.btnShowAdminMenu = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
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
            this.panelCenterLogo = new System.Windows.Forms.Panel();
            this.lbbCenterLogo = new System.Windows.Forms.Label();
            this.lblBelowCenterLogo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelCenterLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnOrderHistory);
            this.panelMenu.Controls.Add(this.btnMonthReport);
            this.panelMenu.Controls.Add(this.btnShowAdminMenu);
            this.panelMenu.Controls.Add(this.btnChangeUser);
            this.panelMenu.Controls.Add(this.btnShoppingCart);
            this.panelMenu.Controls.Add(this.panelCategories);
            this.panelMenu.Controls.Add(this.btnCategories);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrderHistory.Image = global::PharmacyForms.Properties.Resources.time_8_32;
            this.btnOrderHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 505);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrderHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrderHistory.Size = new System.Drawing.Size(220, 60);
            this.btnOrderHistory.TabIndex = 8;
            this.btnOrderHistory.Text = "   История заказов";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthReport.FlatAppearance.BorderSize = 0;
            this.btnMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthReport.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonthReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonthReport.Image = global::PharmacyForms.Properties.Resources.value__1_;
            this.btnMonthReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthReport.Location = new System.Drawing.Point(0, 445);
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMonthReport.Size = new System.Drawing.Size(220, 60);
            this.btnMonthReport.TabIndex = 4;
            this.btnMonthReport.Text = "   Ежемесячный отчет";
            this.btnMonthReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonthReport.UseVisualStyleBackColor = true;
            this.btnMonthReport.Click += new System.EventHandler(this.btnOpenMonthReport_Click);
            // 
            // btnShowAdminMenu
            // 
            this.btnShowAdminMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAdminMenu.FlatAppearance.BorderSize = 0;
            this.btnShowAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdminMenu.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAdminMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowAdminMenu.Image = global::PharmacyForms.Properties.Resources.value__1_;
            this.btnShowAdminMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAdminMenu.Location = new System.Drawing.Point(0, 385);
            this.btnShowAdminMenu.Name = "btnShowAdminMenu";
            this.btnShowAdminMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnShowAdminMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowAdminMenu.Size = new System.Drawing.Size(220, 60);
            this.btnShowAdminMenu.TabIndex = 7;
            this.btnShowAdminMenu.Text = "   Пользователи";
            this.btnShowAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAdminMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAdminMenu.UseVisualStyleBackColor = true;
            this.btnShowAdminMenu.Click += new System.EventHandler(this.btnShowAdminMenu_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnChangeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangeUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeUser.FlatAppearance.BorderSize = 0;
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangeUser.Location = new System.Drawing.Point(0, 602);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(220, 51);
            this.btnChangeUser.TabIndex = 6;
            this.btnChangeUser.Text = "Сменить пользователя";
            this.btnChangeUser.UseVisualStyleBackColor = false;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoppingCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShoppingCart.Image = global::PharmacyForms.Properties.Resources.shopping_cart__1_;
            this.btnShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 325);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnShoppingCart.Size = new System.Drawing.Size(220, 60);
            this.btnShoppingCart.TabIndex = 5;
            this.btnShoppingCart.Text = "   Корзина";
            this.btnShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
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
            this.btnVitamins.Click += new System.EventHandler(this.btnOpenProductForm_Click);
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
            this.btnAntibiotics.Click += new System.EventHandler(this.btnOpenProductForm_Click);
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
            this.btnAntiviralAgent.Click += new System.EventHandler(this.btnOpenProductForm_Click);
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
            this.btnPainReliever.Click += new System.EventHandler(this.btnOpenProductForm_Click);
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
            this.btnCategories.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategories.Image = global::PharmacyForms.Properties.Resources.shopping_list;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 80);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(220, 60);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "   Категории";
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
            this.lblUserLogin.AutoEllipsis = true;
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserLogin.Location = new System.Drawing.Point(545, 0);
            this.lblUserLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Padding = new System.Windows.Forms.Padding(0, 23, 60, 0);
            this.lblUserLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserLogin.Size = new System.Drawing.Size(175, 53);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "UserName";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelCenterLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(720, 573);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelCenterLogo
            // 
            this.panelCenterLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenterLogo.Controls.Add(this.lbbCenterLogo);
            this.panelCenterLogo.Controls.Add(this.lblBelowCenterLogo);
            this.panelCenterLogo.Location = new System.Drawing.Point(211, 173);
            this.panelCenterLogo.Name = "panelCenterLogo";
            this.panelCenterLogo.Size = new System.Drawing.Size(340, 192);
            this.panelCenterLogo.TabIndex = 1;
            // 
            // lbbCenterLogo
            // 
            this.lbbCenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbCenterLogo.AutoSize = true;
            this.lbbCenterLogo.Font = new System.Drawing.Font("Modern No. 20", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbbCenterLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbbCenterLogo.Location = new System.Drawing.Point(17, 31);
            this.lbbCenterLogo.Name = "lbbCenterLogo";
            this.lbbCenterLogo.Size = new System.Drawing.Size(303, 83);
            this.lbbCenterLogo.TabIndex = 0;
            this.lbbCenterLogo.Text = "Pharma";
            // 
            // lblBelowCenterLogo
            // 
            this.lblBelowCenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBelowCenterLogo.AutoSize = true;
            this.lblBelowCenterLogo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBelowCenterLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.lblBelowCenterLogo.Location = new System.Drawing.Point(31, 114);
            this.lblBelowCenterLogo.Name = "lblBelowCenterLogo";
            this.lblBelowCenterLogo.Size = new System.Drawing.Size(279, 34);
            this.lblBelowCenterLogo.TabIndex = 0;
            this.lblBelowCenterLogo.Text = "Добро пожаловать.";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(956, 690);
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
            this.panelDesktop.ResumeLayout(false);
            this.panelCenterLogo.ResumeLayout(false);
            this.panelCenterLogo.PerformLayout();
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
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Button btnVitamins;
        private System.Windows.Forms.Button btnAntibiotics;
        private System.Windows.Forms.Button btnAntiviralAgent;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnShowAdminMenu;
        private System.Windows.Forms.Label lblBelowCenterLogo;
        private System.Windows.Forms.Label lbbCenterLogo;
        private System.Windows.Forms.Panel panelCenterLogo;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnMonthReport;
    }
}