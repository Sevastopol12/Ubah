namespace BFE
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userID = new TextBox();
            password = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginBtn = new Button();
            error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // userID
            // 
            userID.Location = new Point(86, 324);
            userID.Name = "userID";
            userID.PlaceholderText = "userID";
            userID.Size = new Size(301, 27);
            userID.TabIndex = 0;
            userID.Text = "1";
            // 
            // password
            // 
            password.Location = new Point(86, 383);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(301, 27);
            password.TabIndex = 1;
            password.Text = "ftSBuVfjjM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Project.Properties.Resources.icons8_user_24;
            pictureBox1.Location = new Point(27, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Project.Properties.Resources.icons8_password_50;
            pictureBox2.Location = new Point(27, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Project.Properties.Resources.man_user_color_icon;
            pictureBox3.Location = new Point(134, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(160, 431);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(132, 48);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error.Location = new Point(68, 271);
            error.Name = "error";
            error.Size = new Size(0, 31);
            error.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(447, 548);
            Controls.Add(error);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(password);
            Controls.Add(userID);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userID;
        private TextBox password;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginBtn;
        private Label error;
    }
}
