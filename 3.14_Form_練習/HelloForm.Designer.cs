
namespace _3._14_Form_練習
{
    partial class HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.labEngName = new System.Windows.Forms.Label();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.labsex = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.labConstellation = new System.Windows.Forms.Label();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(272, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 35);
            this.txtName.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName.Location = new System.Drawing.Point(31, 64);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 26);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名:";
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHello.Location = new System.Drawing.Point(276, 328);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(139, 56);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "Say Hello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btmSayHello_Click);
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEngName.Location = new System.Drawing.Point(31, 119);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(157, 26);
            this.labEngName.TabIndex = 4;
            this.labEngName.Text = "English Name:";
            // 
            // txtEngName
            // 
            this.txtEngName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngName.Location = new System.Drawing.Point(272, 119);
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.Size = new System.Drawing.Size(143, 35);
            this.txtEngName.TabIndex = 3;
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.BackColor = System.Drawing.Color.Transparent;
            this.labsex.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labsex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labsex.Location = new System.Drawing.Point(31, 184);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(59, 26);
            this.labsex.TabIndex = 6;
            this.labsex.Text = "性別:";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(272, 183);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(143, 35);
            this.txtSex.TabIndex = 5;
            // 
            // labConstellation
            // 
            this.labConstellation.AutoSize = true;
            this.labConstellation.BackColor = System.Drawing.Color.Transparent;
            this.labConstellation.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labConstellation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labConstellation.Location = new System.Drawing.Point(31, 242);
            this.labConstellation.Name = "labConstellation";
            this.labConstellation.Size = new System.Drawing.Size(59, 26);
            this.labConstellation.TabIndex = 8;
            this.labConstellation.Text = "星座:";
            // 
            // txtConstellation
            // 
            this.txtConstellation.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtConstellation.Location = new System.Drawing.Point(272, 241);
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(143, 35);
            this.txtConstellation.TabIndex = 7;
            // 
            // btnSayHi
            // 
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(484, 328);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(139, 56);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi !";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3._14_Form_練習.Properties.Resources._50850711003_5cfb150154_c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.labConstellation);
            this.Controls.Add(this.txtConstellation);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Name = "HelloForm";
            this.Text = "hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.TextBox txtEngName;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label labConstellation;
        private System.Windows.Forms.TextBox txtConstellation;
        private System.Windows.Forms.Button btnSayHi;
    }
}

