
namespace _3._14_Form_練習
{
    partial class Student_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.grpScore = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHighestLowest = new System.Windows.Forms.Button();
            this.labScoreName = new System.Windows.Forms.Label();
            this.labScoreChi = new System.Windows.Forms.Label();
            this.labScoreEng = new System.Windows.Forms.Label();
            this.labScoreMath = new System.Windows.Forms.Label();
            this.labHighestScore = new System.Windows.Forms.Label();
            this.labLowestScore = new System.Windows.Forms.Label();
            this.grpScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(73, 63);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 26);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(73, 113);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(59, 26);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文:";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(73, 162);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(59, 26);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(73, 212);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(59, 26);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(138, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 30);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(138, 109);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(158, 30);
            this.txtChinese.TabIndex = 5;
            this.txtChinese.Text = "0";
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(138, 158);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(158, 30);
            this.txtEnglish.TabIndex = 6;
            this.txtEnglish.Text = "0";
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(138, 208);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(158, 30);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(78, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 58);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(220, 293);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 58);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grpScore
            // 
            this.grpScore.Controls.Add(this.labLowestScore);
            this.grpScore.Controls.Add(this.labHighestScore);
            this.grpScore.Controls.Add(this.labScoreMath);
            this.grpScore.Controls.Add(this.labScoreEng);
            this.grpScore.Controls.Add(this.labScoreChi);
            this.grpScore.Controls.Add(this.labScoreName);
            this.grpScore.Controls.Add(this.textBox2);
            this.grpScore.Controls.Add(this.textBox1);
            this.grpScore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpScore.Location = new System.Drawing.Point(420, 2);
            this.grpScore.Name = "grpScore";
            this.grpScore.Size = new System.Drawing.Size(349, 349);
            this.grpScore.TabIndex = 10;
            this.grpScore.TabStop = false;
            this.grpScore.Text = "成績";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 213);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(6, 239);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 104);
            this.textBox2.TabIndex = 1;
            // 
            // btnHighestLowest
            // 
            this.btnHighestLowest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighestLowest.Location = new System.Drawing.Point(584, 357);
            this.btnHighestLowest.Name = "btnHighestLowest";
            this.btnHighestLowest.Size = new System.Drawing.Size(163, 46);
            this.btnHighestLowest.TabIndex = 11;
            this.btnHighestLowest.Text = "最高分/最低分科目";
            this.btnHighestLowest.UseVisualStyleBackColor = true;
            this.btnHighestLowest.Click += new System.EventHandler(this.btnHighestLowest_Click);
            // 
            // labScoreName
            // 
            this.labScoreName.AutoSize = true;
            this.labScoreName.Location = new System.Drawing.Point(15, 29);
            this.labScoreName.Name = "labScoreName";
            this.labScoreName.Size = new System.Drawing.Size(0, 24);
            this.labScoreName.TabIndex = 2;
            // 
            // labScoreChi
            // 
            this.labScoreChi.AutoSize = true;
            this.labScoreChi.Location = new System.Drawing.Point(15, 53);
            this.labScoreChi.Name = "labScoreChi";
            this.labScoreChi.Size = new System.Drawing.Size(0, 24);
            this.labScoreChi.TabIndex = 3;
            // 
            // labScoreEng
            // 
            this.labScoreEng.AutoSize = true;
            this.labScoreEng.Location = new System.Drawing.Point(15, 77);
            this.labScoreEng.Name = "labScoreEng";
            this.labScoreEng.Size = new System.Drawing.Size(0, 24);
            this.labScoreEng.TabIndex = 4;
            // 
            // labScoreMath
            // 
            this.labScoreMath.AutoSize = true;
            this.labScoreMath.Location = new System.Drawing.Point(15, 101);
            this.labScoreMath.Name = "labScoreMath";
            this.labScoreMath.Size = new System.Drawing.Size(0, 24);
            this.labScoreMath.TabIndex = 5;
            // 
            // labHighestScore
            // 
            this.labHighestScore.AutoSize = true;
            this.labHighestScore.Location = new System.Drawing.Point(15, 242);
            this.labHighestScore.Name = "labHighestScore";
            this.labHighestScore.Size = new System.Drawing.Size(0, 24);
            this.labHighestScore.TabIndex = 6;
            // 
            // labLowestScore
            // 
            this.labLowestScore.AutoSize = true;
            this.labLowestScore.Location = new System.Drawing.Point(15, 266);
            this.labLowestScore.Name = "labLowestScore";
            this.labLowestScore.Size = new System.Drawing.Size(0, 24);
            this.labLowestScore.TabIndex = 7;
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHighestLowest);
            this.Controls.Add(this.grpScore);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.grpScore.ResumeLayout(false);
            this.grpScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox grpScore;
        private System.Windows.Forms.Label labScoreMath;
        private System.Windows.Forms.Label labScoreEng;
        private System.Windows.Forms.Label labScoreChi;
        private System.Windows.Forms.Label labScoreName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHighestLowest;
        private System.Windows.Forms.Label labLowestScore;
        private System.Windows.Forms.Label labHighestScore;
    }
}