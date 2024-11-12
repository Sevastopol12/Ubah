namespace Fe
{
    partial class Form4
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
            button2 = new Button();
            history = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Location = new Point(11, 11);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 15;
            button2.Text = "<- Trở về";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // history
            // 
            history.Location = new Point(55, 71);
            history.Name = "history";
            history.ReadOnly = true;
            history.Size = new Size(559, 485);
            history.TabIndex = 16;
            history.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(245, 11);
            label1.Name = "label1";
            label1.Size = new Size(190, 41);
            label1.TabIndex = 17;
            label1.Text = "Trip history";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = button2;
            ClientSize = new Size(679, 614);
            Controls.Add(label1);
            Controls.Add(history);
            Controls.Add(button2);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Đặt xe";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private RichTextBox history;
        private Label label1;
    }
}