﻿namespace hansot_pos
{
    partial class Stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCgPrice = new System.Windows.Forms.Label();
            this.lbCgSales = new System.Windows.Forms.Label();
            this.lbCgTotalSales = new System.Windows.Forms.Label();
            this.lbCgTotalPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMnSales = new System.Windows.Forms.Label();
            this.lbMnPrice = new System.Windows.Forms.Label();
            this.lbMnTotalSales = new System.Windows.Forms.Label();
            this.lbMnTotalPrice = new System.Windows.Forms.Label();
            this.lbMenu = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPmSales = new System.Windows.Forms.Label();
            this.lbPmPrice = new System.Windows.Forms.Label();
            this.lbPmTotalSales = new System.Windows.Forms.Label();
            this.lbPmTotalPrice = new System.Windows.Forms.Label();
            this.lbPaymentMethod = new System.Windows.Forms.Label();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbCgPrice);
            this.panel1.Controls.Add(this.lbCgSales);
            this.panel1.Controls.Add(this.lbCgTotalSales);
            this.panel1.Controls.Add(this.lbCgTotalPrice);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 550);
            this.panel1.TabIndex = 0;
            // 
            // lbCgPrice
            // 
            this.lbCgPrice.AutoSize = true;
            this.lbCgPrice.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbCgPrice.Location = new System.Drawing.Point(165, 423);
            this.lbCgPrice.Name = "lbCgPrice";
            this.lbCgPrice.Size = new System.Drawing.Size(77, 27);
            this.lbCgPrice.TabIndex = 5;
            this.lbCgPrice.Text = " 0 원";
            this.lbCgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCgSales
            // 
            this.lbCgSales.AutoSize = true;
            this.lbCgSales.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbCgSales.Location = new System.Drawing.Point(165, 289);
            this.lbCgSales.Name = "lbCgSales";
            this.lbCgSales.Size = new System.Drawing.Size(77, 27);
            this.lbCgSales.TabIndex = 7;
            this.lbCgSales.Text = " 0 개";
            // 
            // lbCgTotalSales
            // 
            this.lbCgTotalSales.AutoSize = true;
            this.lbCgTotalSales.Font = new System.Drawing.Font("굴림", 16F);
            this.lbCgTotalSales.Location = new System.Drawing.Point(42, 216);
            this.lbCgTotalSales.Name = "lbCgTotalSales";
            this.lbCgTotalSales.Size = new System.Drawing.Size(76, 22);
            this.lbCgTotalSales.TabIndex = 4;
            this.lbCgTotalSales.Text = "판매량";
            // 
            // lbCgTotalPrice
            // 
            this.lbCgTotalPrice.AutoSize = true;
            this.lbCgTotalPrice.Font = new System.Drawing.Font("굴림", 16F);
            this.lbCgTotalPrice.Location = new System.Drawing.Point(42, 367);
            this.lbCgTotalPrice.Name = "lbCgTotalPrice";
            this.lbCgTotalPrice.Size = new System.Drawing.Size(76, 22);
            this.lbCgTotalPrice.TabIndex = 3;
            this.lbCgTotalPrice.Text = "매출액";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(109, 30);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(93, 20);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(86, 83);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(140, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbMnSales);
            this.panel2.Controls.Add(this.lbMnPrice);
            this.panel2.Controls.Add(this.lbMnTotalSales);
            this.panel2.Controls.Add(this.lbMnTotalPrice);
            this.panel2.Controls.Add(this.lbMenu);
            this.panel2.Controls.Add(this.menuComboBox);
            this.panel2.Location = new System.Drawing.Point(328, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 550);
            this.panel2.TabIndex = 1;
            // 
            // lbMnSales
            // 
            this.lbMnSales.AutoSize = true;
            this.lbMnSales.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbMnSales.Location = new System.Drawing.Point(158, 289);
            this.lbMnSales.Name = "lbMnSales";
            this.lbMnSales.Size = new System.Drawing.Size(77, 27);
            this.lbMnSales.TabIndex = 7;
            this.lbMnSales.Text = " 0 개";
            // 
            // lbMnPrice
            // 
            this.lbMnPrice.AutoSize = true;
            this.lbMnPrice.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbMnPrice.Location = new System.Drawing.Point(158, 423);
            this.lbMnPrice.Name = "lbMnPrice";
            this.lbMnPrice.Size = new System.Drawing.Size(77, 27);
            this.lbMnPrice.TabIndex = 6;
            this.lbMnPrice.Text = " 0 원";
            this.lbMnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMnTotalSales
            // 
            this.lbMnTotalSales.AutoSize = true;
            this.lbMnTotalSales.Font = new System.Drawing.Font("굴림", 16F);
            this.lbMnTotalSales.Location = new System.Drawing.Point(42, 216);
            this.lbMnTotalSales.Name = "lbMnTotalSales";
            this.lbMnTotalSales.Size = new System.Drawing.Size(76, 22);
            this.lbMnTotalSales.TabIndex = 6;
            this.lbMnTotalSales.Text = "판매량";
            // 
            // lbMnTotalPrice
            // 
            this.lbMnTotalPrice.AutoSize = true;
            this.lbMnTotalPrice.Font = new System.Drawing.Font("굴림", 16F);
            this.lbMnTotalPrice.Location = new System.Drawing.Point(42, 367);
            this.lbMnTotalPrice.Name = "lbMnTotalPrice";
            this.lbMnTotalPrice.Size = new System.Drawing.Size(76, 22);
            this.lbMnTotalPrice.TabIndex = 5;
            this.lbMnTotalPrice.Text = "매출액";
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbMenu.Location = new System.Drawing.Point(121, 30);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(59, 20);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "Menu";
            // 
            // menuComboBox
            // 
            this.menuComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(68, 83);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(180, 24);
            this.menuComboBox.TabIndex = 2;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuCB_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.backBtn.Location = new System.Drawing.Point(960, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(184, 550);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "뒤로가기";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.lbPmSales);
            this.panel3.Controls.Add(this.lbPmPrice);
            this.panel3.Controls.Add(this.lbPmTotalSales);
            this.panel3.Controls.Add(this.lbPmTotalPrice);
            this.panel3.Controls.Add(this.lbPaymentMethod);
            this.panel3.Controls.Add(this.PaymentMethodComboBox);
            this.panel3.Location = new System.Drawing.Point(644, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 550);
            this.panel3.TabIndex = 8;
            // 
            // lbPmSales
            // 
            this.lbPmSales.AutoSize = true;
            this.lbPmSales.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbPmSales.Location = new System.Drawing.Point(158, 289);
            this.lbPmSales.Name = "lbPmSales";
            this.lbPmSales.Size = new System.Drawing.Size(77, 27);
            this.lbPmSales.TabIndex = 7;
            this.lbPmSales.Text = " 0 개";
            // 
            // lbPmPrice
            // 
            this.lbPmPrice.AutoSize = true;
            this.lbPmPrice.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbPmPrice.Location = new System.Drawing.Point(158, 423);
            this.lbPmPrice.Name = "lbPmPrice";
            this.lbPmPrice.Size = new System.Drawing.Size(77, 27);
            this.lbPmPrice.TabIndex = 6;
            this.lbPmPrice.Text = " 0 원";
            this.lbPmPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPmTotalSales
            // 
            this.lbPmTotalSales.AutoSize = true;
            this.lbPmTotalSales.Font = new System.Drawing.Font("굴림", 16F);
            this.lbPmTotalSales.Location = new System.Drawing.Point(42, 216);
            this.lbPmTotalSales.Name = "lbPmTotalSales";
            this.lbPmTotalSales.Size = new System.Drawing.Size(76, 22);
            this.lbPmTotalSales.TabIndex = 6;
            this.lbPmTotalSales.Text = "판매량";
            // 
            // lbPmTotalPrice
            // 
            this.lbPmTotalPrice.AutoSize = true;
            this.lbPmTotalPrice.Font = new System.Drawing.Font("굴림", 16F);
            this.lbPmTotalPrice.Location = new System.Drawing.Point(42, 367);
            this.lbPmTotalPrice.Name = "lbPmTotalPrice";
            this.lbPmTotalPrice.Size = new System.Drawing.Size(76, 22);
            this.lbPmTotalPrice.TabIndex = 5;
            this.lbPmTotalPrice.Text = "매출액";
            // 
            // lbPaymentMethod
            // 
            this.lbPaymentMethod.AutoSize = true;
            this.lbPaymentMethod.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbPaymentMethod.Location = new System.Drawing.Point(68, 30);
            this.lbPaymentMethod.Name = "lbPaymentMethod";
            this.lbPaymentMethod.Size = new System.Drawing.Size(167, 20);
            this.lbPaymentMethod.TabIndex = 3;
            this.lbPaymentMethod.Text = "Payment method";
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(78, 83);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(150, 24);
            this.PaymentMethodComboBox.TabIndex = 2;
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Label lbCgTotalPrice;
        private System.Windows.Forms.Label lbCgTotalSales;
        private System.Windows.Forms.Label lbMnTotalSales;
        private System.Windows.Forms.Label lbMnTotalPrice;
        private System.Windows.Forms.Label lbCgPrice;
        private System.Windows.Forms.Label lbCgSales;
        private System.Windows.Forms.Label lbMnSales;
        private System.Windows.Forms.Label lbMnPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPmSales;
        private System.Windows.Forms.Label lbPmPrice;
        private System.Windows.Forms.Label lbPmTotalSales;
        private System.Windows.Forms.Label lbPmTotalPrice;
        private System.Windows.Forms.Label lbPaymentMethod;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
    }
}