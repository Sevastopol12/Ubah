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
            // 
            // history
            // 
            history.Location = new Point(16, 73);
            history.Name = "history";
            history.Size = new Size(443, 451);
            history.TabIndex = 16;
            history.Text = "";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = button2;
            ClientSize = new Size(481, 614);
            Controls.Add(history);
            Controls.Add(button2);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Đặt xe";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private RichTextBox history;
    }
}