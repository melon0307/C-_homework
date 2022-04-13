
namespace _3._14_Form_練習
{
    partial class StudentGrade
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
            this.labData = new System.Windows.Forms.Label();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labData
            // 
            this.labData.AutoSize = true;
            this.labData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labData.Location = new System.Drawing.Point(285, 39);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(44, 17);
            this.labData.TabIndex = 31;
            this.labData.Text = "label1";
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(51, 438);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(127, 34);
            this.btnRandom20.TabIndex = 30;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(51, 398);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 34);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnresult.Location = new System.Drawing.Point(51, 312);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(127, 34);
            this.btnresult.TabIndex = 28;
            this.btnresult.Text = "各科統計";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom.Location = new System.Drawing.Point(51, 272);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 34);
            this.btnRandom.TabIndex = 27;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddData.Location = new System.Drawing.Point(51, 232);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(127, 34);
            this.btnAddData.TabIndex = 26;
            this.btnAddData.Text = "加入學生資料";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(279, 341);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(555, 150);
            this.txtResult.TabIndex = 25;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtData.Location = new System.Drawing.Point(279, 36);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(555, 299);
            this.txtData.TabIndex = 24;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(89, 156);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(89, 29);
            this.txtMath.TabIndex = 23;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(89, 110);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(89, 29);
            this.txtEnglish.TabIndex = 22;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(89, 65);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(89, 29);
            this.txtChinese.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(89, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 29);
            this.txtName.TabIndex = 20;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(31, 156);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(52, 24);
            this.labMath.TabIndex = 19;
            this.labMath.Text = "數學:";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(31, 110);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(52, 24);
            this.labEnglish.TabIndex = 18;
            this.labEnglish.Text = "英文:";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(31, 65);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(52, 24);
            this.labChinese.TabIndex = 17;
            this.labChinese.Text = "國文:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(31, 21);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 24);
            this.labName.TabIndex = 16;
            this.labName.Text = "姓名:";
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 513);
            this.Controls.Add(this.labData);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labName;
    }
}