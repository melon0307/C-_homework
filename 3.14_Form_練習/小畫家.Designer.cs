
namespace _3._14_Form_練習
{
    partial class 小畫家
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
            this.pictureboxCanvas = new System.Windows.Forms.PictureBox();
            this.labPen = new System.Windows.Forms.Label();
            this.trackPen = new System.Windows.Forms.TrackBar();
            this.labColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxCanvas
            // 
            this.pictureboxCanvas.Location = new System.Drawing.Point(-12, -24);
            this.pictureboxCanvas.Name = "pictureboxCanvas";
            this.pictureboxCanvas.Size = new System.Drawing.Size(823, 478);
            this.pictureboxCanvas.TabIndex = 0;
            this.pictureboxCanvas.TabStop = false;
            this.pictureboxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureboxCanvas_MouseDown);
            this.pictureboxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureboxCanvas_MouseMove);
            // 
            // labPen
            // 
            this.labPen.AutoSize = true;
            this.labPen.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPen.Location = new System.Drawing.Point(727, 278);
            this.labPen.Name = "labPen";
            this.labPen.Size = new System.Drawing.Size(46, 16);
            this.labPen.TabIndex = 8;
            this.labPen.Text = "label2";
            // 
            // trackPen
            // 
            this.trackPen.Location = new System.Drawing.Point(730, 100);
            this.trackPen.Name = "trackPen";
            this.trackPen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackPen.Size = new System.Drawing.Size(45, 175);
            this.trackPen.TabIndex = 7;
            this.trackPen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackPen.Scroll += new System.EventHandler(this.trackPen_Scroll);
            // 
            // labColor
            // 
            this.labColor.AutoSize = true;
            this.labColor.BackColor = System.Drawing.Color.Black;
            this.labColor.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labColor.Location = new System.Drawing.Point(723, 55);
            this.labColor.Name = "labColor";
            this.labColor.Size = new System.Drawing.Size(0, 27);
            this.labColor.TabIndex = 6;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(715, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(73, 40);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // 小畫家
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPen);
            this.Controls.Add(this.trackPen);
            this.Controls.Add(this.labColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pictureboxCanvas);
            this.Name = "小畫家";
            this.Text = "小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxCanvas;
        private System.Windows.Forms.Label labPen;
        private System.Windows.Forms.TrackBar trackPen;
        private System.Windows.Forms.Label labColor;
        private System.Windows.Forms.Button btnColor;
    }
}