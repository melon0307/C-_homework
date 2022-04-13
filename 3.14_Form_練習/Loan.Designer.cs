
namespace _3._14_Form_練習
{
    partial class Loan
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
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtdownpayment = new System.Windows.Forms.TextBox();
            this.btnmonthlypmt = new System.Windows.Forms.Button();
            this.btntotalpayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(128, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(128, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(128, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttotal.Location = new System.Drawing.Point(250, 33);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(151, 29);
            this.txttotal.TabIndex = 4;
            this.txttotal.Text = "100000";
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtyear.Location = new System.Drawing.Point(250, 96);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(151, 29);
            this.txtyear.TabIndex = 5;
            this.txtyear.Text = "2";
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtrate.Location = new System.Drawing.Point(250, 156);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(151, 29);
            this.txtrate.TabIndex = 6;
            this.txtrate.Text = "10";
            // 
            // txtdownpayment
            // 
            this.txtdownpayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtdownpayment.Location = new System.Drawing.Point(250, 222);
            this.txtdownpayment.Name = "txtdownpayment";
            this.txtdownpayment.Size = new System.Drawing.Size(151, 29);
            this.txtdownpayment.TabIndex = 7;
            this.txtdownpayment.Text = "0";
            // 
            // btnmonthlypmt
            // 
            this.btnmonthlypmt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmonthlypmt.Location = new System.Drawing.Point(114, 305);
            this.btnmonthlypmt.Name = "btnmonthlypmt";
            this.btnmonthlypmt.Size = new System.Drawing.Size(129, 47);
            this.btnmonthlypmt.TabIndex = 8;
            this.btnmonthlypmt.Text = "月付";
            this.btnmonthlypmt.UseVisualStyleBackColor = true;
            this.btnmonthlypmt.Click += new System.EventHandler(this.btnmonthlypmt_Click);
            // 
            // btntotalpayment
            // 
            this.btntotalpayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntotalpayment.Location = new System.Drawing.Point(301, 305);
            this.btntotalpayment.Name = "btntotalpayment";
            this.btntotalpayment.Size = new System.Drawing.Size(129, 47);
            this.btntotalpayment.TabIndex = 9;
            this.btntotalpayment.Text = "總付款";
            this.btntotalpayment.UseVisualStyleBackColor = true;
            this.btntotalpayment.Click += new System.EventHandler(this.btntotalpayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(504, 305);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(129, 47);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btntotalpayment);
            this.Controls.Add(this.btnmonthlypmt);
            this.Controls.Add(this.txtdownpayment);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtdownpayment;
        private System.Windows.Forms.Button btnmonthlypmt;
        private System.Windows.Forms.Button btntotalpayment;
        private System.Windows.Forms.Button btnReport;
    }
}