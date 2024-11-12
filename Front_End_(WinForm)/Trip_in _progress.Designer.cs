namespace Fe
{
    partial class Progress
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
            pictureBox1 = new PictureBox();
            progressing = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Project.Properties.Resources.anh_gif_1_min;
            pictureBox1.Location = new Point(171, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // progressing
            // 
            progressing.Anchor = AnchorStyles.None;
            progressing.AutoSize = true;
            progressing.BackColor = Color.White;
            progressing.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            progressing.Location = new Point(230, 424);
            progressing.Name = "progressing";
            progressing.Size = new Size(407, 38);
            progressing.TabIndex = 4;
            progressing.Text = "Looking for nearby driver....";
            // 
            // Progress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 20, 21);
            ClientSize = new Size(883, 553);
            Controls.Add(progressing);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Progress";
            Text = "Xác định địa điểm đang ở";
            Load += Progress_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label progressing;
    }
}