
namespace Fe
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            loc = new TextBox();
            des = new TextBox();
            button2 = new Button();
            preview = new Button();
            request = new Button();
            car = new PictureBox();
            fare = new Label();
            farevar = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            disvar = new Label();
            distance = new Label();
            myhistory = new Button();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(10, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 0;
            button1.Text = "<- Trở về";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 1;
            label1.Text = "Bạn muốn đi đâu?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 479);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Gần đây";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(21, 517);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 23);
            label3.TabIndex = 5;
            label3.Text = "📍";
            // 
            // button4
            // 
            button4.BackColor = Color.LightGoldenrodYellow;
            button4.Location = new Point(70, 513);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(121, 32);
            button4.TabIndex = 6;
            button4.Text = "UEH Cơ sở A";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // loc
            // 
            loc.Location = new Point(21, 555);
            loc.Name = "loc";
            loc.PlaceholderText = "🙋‍♂️ Vị trí của bạn";
            loc.Size = new Size(335, 27);
            loc.TabIndex = 7;
            // 
            // des
            // 
            des.Location = new Point(21, 597);
            des.Name = "des";
            des.PlaceholderText = "📍Tìm địa điểm ";
            des.Size = new Size(335, 27);
            des.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Location = new Point(229, 513);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 9;
            button2.Text = "UEH Cơ sở B";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // preview
            // 
            preview.Location = new Point(355, 678);
            preview.Name = "preview";
            preview.Size = new Size(103, 38);
            preview.TabIndex = 11;
            preview.Text = "Preview";
            preview.UseVisualStyleBackColor = true;
            preview.Click += preview_Click;
            // 
            // request
            // 
            request.BackColor = Color.FromArgb(255, 255, 128);
            request.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            request.Location = new Point(481, 678);
            request.Margin = new Padding(2);
            request.Name = "request";
            request.Size = new Size(119, 38);
            request.TabIndex = 13;
            request.Text = "Request";
            request.UseVisualStyleBackColor = false;
            request.Click += request_Click;
            // 
            // car
            // 
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(253, 663);
            car.Name = "car";
            car.Size = new Size(76, 66);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 14;
            car.TabStop = false;
            // 
            // fare
            // 
            fare.AutoSize = true;
            fare.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fare.Location = new Point(419, 517);
            fare.Name = "fare";
            fare.Size = new Size(76, 38);
            fare.TabIndex = 15;
            fare.Text = "Fare";
            // 
            // farevar
            // 
            farevar.AutoSize = true;
            farevar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            farevar.Location = new Point(530, 517);
            farevar.Name = "farevar";
            farevar.Size = new Size(0, 38);
            farevar.TabIndex = 16;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 43);
            webView21.Name = "webView21";
            webView21.Size = new Size(650, 433);
            webView21.TabIndex = 17;
            webView21.ZoomFactor = 1D;
            // 
            // disvar
            // 
            disvar.AutoSize = true;
            disvar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disvar.Location = new Point(530, 590);
            disvar.Name = "disvar";
            disvar.Size = new Size(0, 38);
            disvar.TabIndex = 19;
            // 
            // distance
            // 
            distance.AutoSize = true;
            distance.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distance.Location = new Point(393, 586);
            distance.Name = "distance";
            distance.Size = new Size(137, 38);
            distance.TabIndex = 18;
            distance.Text = "Distance";
            // 
            // myhistory
            // 
            myhistory.Location = new Point(60, 678);
            myhistory.Name = "myhistory";
            myhistory.Size = new Size(116, 38);
            myhistory.TabIndex = 20;
            myhistory.Text = "Show History";
            myhistory.UseVisualStyleBackColor = true;
            myhistory.Click += this.myhistory_Click_1;
            // 
            // MainForm1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(651, 741);
            Controls.Add(myhistory);
            Controls.Add(disvar);
            Controls.Add(distance);
            Controls.Add(webView21);
            Controls.Add(farevar);
            Controls.Add(fare);
            Controls.Add(car);
            Controls.Add(request);
            Controls.Add(preview);
            Controls.Add(button2);
            Controls.Add(des);
            Controls.Add(loc);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "MainForm1";
            Text = " Chọn địa điểm";
            Load += MainForm1_Load;
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private TextBox loc;
        private TextBox des;
        private Button button2;
        private Button preview;
        private Button request;
        private PictureBox car;
        private Label fare;
        private Label farevar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label disvar;
        private Label distance;
        private Button myhistory;
    }
}