
namespace _3._14_Form_練習
{
    partial class POS
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
            this.btnpineapple = new System.Windows.Forms.Button();
            this.btngrape = new System.Windows.Forms.Button();
            this.btnbanana = new System.Windows.Forms.Button();
            this.btnapple = new System.Windows.Forms.Button();
            this.labMenu = new System.Windows.Forms.Label();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnclean = new System.Windows.Forms.Button();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.labList = new System.Windows.Forms.Label();
            this.panelTotalPrice = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.panelPaymentMethod = new System.Windows.Forms.Panel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.labPaymentMethod = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelTotalPrice.SuspendLayout();
            this.panelPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnpineapple);
            this.panelMenu.Controls.Add(this.btngrape);
            this.panelMenu.Controls.Add(this.btnbanana);
            this.panelMenu.Controls.Add(this.btnapple);
            this.panelMenu.Controls.Add(this.labMenu);
            this.panelMenu.Location = new System.Drawing.Point(12, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(271, 370);
            this.panelMenu.TabIndex = 0;
            // 
            // btnpineapple
            // 
            this.btnpineapple.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpineapple.Image = global::_3._14_Form_練習.Properties.Resources.pineapple;
            this.btnpineapple.Location = new System.Drawing.Point(143, 201);
            this.btnpineapple.Name = "btnpineapple";
            this.btnpineapple.Size = new System.Drawing.Size(96, 121);
            this.btnpineapple.TabIndex = 4;
            this.btnpineapple.Text = "鳳梨 pineapple 15元";
            this.btnpineapple.UseVisualStyleBackColor = true;
            this.btnpineapple.Click += new System.EventHandler(this.btnpineapple_Click);
            // 
            // btngrape
            // 
            this.btngrape.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngrape.Image = global::_3._14_Form_練習.Properties.Resources.grape;
            this.btngrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngrape.Location = new System.Drawing.Point(21, 201);
            this.btngrape.Name = "btngrape";
            this.btngrape.Size = new System.Drawing.Size(96, 121);
            this.btngrape.TabIndex = 3;
            this.btngrape.Text = "葡萄 grape 100元";
            this.btngrape.UseVisualStyleBackColor = true;
            this.btngrape.Click += new System.EventHandler(this.btngrape_Click);
            // 
            // btnbanana
            // 
            this.btnbanana.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbanana.Image = global::_3._14_Form_練習.Properties.Resources.banana;
            this.btnbanana.Location = new System.Drawing.Point(143, 60);
            this.btnbanana.Name = "btnbanana";
            this.btnbanana.Size = new System.Drawing.Size(96, 121);
            this.btnbanana.TabIndex = 2;
            this.btnbanana.Text = "香蕉 banana 50元";
            this.btnbanana.UseVisualStyleBackColor = true;
            this.btnbanana.Click += new System.EventHandler(this.btnbanana_Click);
            // 
            // btnapple
            // 
            this.btnapple.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnapple.Image = global::_3._14_Form_練習.Properties.Resources.apple;
            this.btnapple.Location = new System.Drawing.Point(21, 60);
            this.btnapple.Name = "btnapple";
            this.btnapple.Size = new System.Drawing.Size(96, 121);
            this.btnapple.TabIndex = 1;
            this.btnapple.Text = "蘋果 apple 30元";
            this.btnapple.UseVisualStyleBackColor = true;
            this.btnapple.Click += new System.EventHandler(this.btnapple_Click);
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(-1, 0);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(118, 26);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Menu";
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelList.Controls.Add(this.btnclean);
            this.panelList.Controls.Add(this.txtlist);
            this.panelList.Controls.Add(this.labList);
            this.panelList.Location = new System.Drawing.Point(598, 31);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(275, 369);
            this.panelList.TabIndex = 1;
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclean.Location = new System.Drawing.Point(161, 322);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(94, 33);
            this.btnclean.TabIndex = 7;
            this.btnclean.Text = "清除";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // txtlist
            // 
            this.txtlist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlist.Location = new System.Drawing.Point(5, 29);
            this.txtlist.Multiline = true;
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(265, 268);
            this.txtlist.TabIndex = 6;
            this.txtlist.Text = "尚未點餐";
            this.txtlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(3, 0);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(136, 26);
            this.labList.TabIndex = 1;
            this.labList.Text = "購物清單 List";
            // 
            // panelTotalPrice
            // 
            this.panelTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalPrice.Controls.Add(this.txtTotalPrice);
            this.panelTotalPrice.Controls.Add(this.labTotalPrice);
            this.panelTotalPrice.Location = new System.Drawing.Point(289, 31);
            this.panelTotalPrice.Name = "panelTotalPrice";
            this.panelTotalPrice.Size = new System.Drawing.Size(303, 131);
            this.panelTotalPrice.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.Location = new System.Drawing.Point(23, 43);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(259, 50);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "NT$: 0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(3, -1);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(187, 26);
            this.labTotalPrice.TabIndex = 0;
            this.labTotalPrice.Text = "總金額 Total Price";
            // 
            // panelPaymentMethod
            // 
            this.panelPaymentMethod.BackColor = System.Drawing.SystemColors.Control;
            this.panelPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaymentMethod.Controls.Add(this.txtAd);
            this.panelPaymentMethod.Controls.Add(this.btnCreditCard);
            this.panelPaymentMethod.Controls.Add(this.btnCash);
            this.panelPaymentMethod.Controls.Add(this.labPaymentMethod);
            this.panelPaymentMethod.Location = new System.Drawing.Point(290, 186);
            this.panelPaymentMethod.Name = "panelPaymentMethod";
            this.panelPaymentMethod.Size = new System.Drawing.Size(303, 131);
            this.panelPaymentMethod.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAd.Location = new System.Drawing.Point(177, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(105, 27);
            this.txtAd.TabIndex = 4;
            this.txtAd.Text = "信用卡打九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.Location = new System.Drawing.Point(164, 51);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(103, 41);
            this.btnCreditCard.TabIndex = 3;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(34, 51);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(103, 41);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labPaymentMethod
            // 
            this.labPaymentMethod.AutoSize = true;
            this.labPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPaymentMethod.Location = new System.Drawing.Point(3, 0);
            this.labPaymentMethod.Name = "labPaymentMethod";
            this.labPaymentMethod.Size = new System.Drawing.Size(96, 26);
            this.labPaymentMethod.TabIndex = 1;
            this.labPaymentMethod.Text = "付款方式";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.panelPaymentMethod);
            this.Controls.Add(this.panelTotalPrice);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelMenu);
            this.Name = "POS";
            this.Text = "POS";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.panelTotalPrice.ResumeLayout(false);
            this.panelTotalPrice.PerformLayout();
            this.panelPaymentMethod.ResumeLayout(false);
            this.panelPaymentMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnpineapple;
        private System.Windows.Forms.Button btngrape;
        private System.Windows.Forms.Button btnbanana;
        private System.Windows.Forms.Button btnapple;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.TextBox txtlist;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Panel panelTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Panel panelPaymentMethod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labPaymentMethod;
    }
}