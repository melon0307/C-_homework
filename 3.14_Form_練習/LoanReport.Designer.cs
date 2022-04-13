
namespace _3._14_Form_練習
{
    partial class LoanReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtmonthlypmt = new System.Windows.Forms.TextBox();
            this.txttotalpayment = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(192, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(194, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "利率(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(194, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "月付款:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(194, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "總付款:";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttotal.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttotal.Location = new System.Drawing.Point(316, 30);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(151, 29);
            this.txttotal.TabIndex = 6;
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtyear.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtyear.Location = new System.Drawing.Point(316, 97);
            this.txtyear.Name = "txtyear";
            this.txtyear.ReadOnly = true;
            this.txtyear.Size = new System.Drawing.Size(151, 29);
            this.txtyear.TabIndex = 7;
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtrate.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtrate.Location = new System.Drawing.Point(316, 161);
            this.txtrate.Name = "txtrate";
            this.txtrate.ReadOnly = true;
            this.txtrate.Size = new System.Drawing.Size(151, 29);
            this.txtrate.TabIndex = 8;
            // 
            // txtmonthlypmt
            // 
            this.txtmonthlypmt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtmonthlypmt.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmonthlypmt.Location = new System.Drawing.Point(316, 225);
            this.txtmonthlypmt.Name = "txtmonthlypmt";
            this.txtmonthlypmt.ReadOnly = true;
            this.txtmonthlypmt.Size = new System.Drawing.Size(151, 29);
            this.txtmonthlypmt.TabIndex = 9;
            // 
            // txttotalpayment
            // 
            this.txttotalpayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttotalpayment.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttotalpayment.Location = new System.Drawing.Point(316, 295);
            this.txttotalpayment.Name = "txttotalpayment";
            this.txttotalpayment.ReadOnly = true;
            this.txttotalpayment.Size = new System.Drawing.Size(151, 29);
            this.txttotalpayment.TabIndex = 10;
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(593, 362);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(122, 43);
            this.btnEmail.TabIndex = 11;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txttotalpayment);
            this.Controls.Add(this.txtmonthlypmt);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoanReport";
            this.Text = "LoanReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtmonthlypmt;
        private System.Windows.Forms.TextBox txttotalpayment;
        private System.Windows.Forms.Button btnEmail;
    }
}