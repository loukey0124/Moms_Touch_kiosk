namespace START
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.eventImage = new System.Windows.Forms.PictureBox();
            this.btnTakeout = new System.Windows.Forms.Button();
            this.btnEatin = new System.Windows.Forms.Button();
            this.timer_5Sec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // eventImage
            // 
            this.eventImage.Location = new System.Drawing.Point(0, 0);
            this.eventImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventImage.Name = "eventImage";
            this.eventImage.Size = new System.Drawing.Size(850, 850);
            this.eventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventImage.TabIndex = 1;
            this.eventImage.TabStop = false;
            // 
            // btnTakeout
            // 
            this.btnTakeout.BackColor = System.Drawing.Color.Tomato;
            this.btnTakeout.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakeout.Location = new System.Drawing.Point(20, 875);
            this.btnTakeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(250, 100);
            this.btnTakeout.TabIndex = 2;
            this.btnTakeout.Text = "포장";
            this.btnTakeout.UseVisualStyleBackColor = false;
            this.btnTakeout.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnEatin
            // 
            this.btnEatin.BackColor = System.Drawing.Color.Tomato;
            this.btnEatin.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEatin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEatin.Location = new System.Drawing.Point(580, 875);
            this.btnEatin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEatin.Name = "btnEatin";
            this.btnEatin.Size = new System.Drawing.Size(250, 100);
            this.btnEatin.TabIndex = 4;
            this.btnEatin.Text = "매장";
            this.btnEatin.UseVisualStyleBackColor = false;
            this.btnEatin.Click += new System.EventHandler(this.ButtonClick);
            // 
            // timer_5Sec
            // 
            this.timer_5Sec.Interval = 5000;
            this.timer_5Sec.Tick += new System.EventHandler(this.timer_5Sec_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 1000);
            this.Controls.Add(this.btnEatin);
            this.Controls.Add(this.btnTakeout);
            this.Controls.Add(this.eventImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Start";
            this.Text = "Mom\'s Touch";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox eventImage;
        private System.Windows.Forms.Button btnTakeout;
        private System.Windows.Forms.Button btnEatin;
        private System.Windows.Forms.Timer timer_5Sec;
    }
}