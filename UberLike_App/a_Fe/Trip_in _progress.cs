using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubah;

namespace Fe
{
    public partial class Progress : Form
    {
        internal readonly object txtDiaDiem;

        public Progress()
        {
            InitializeComponent();
        }

        private async void Progress_Load(object sender, EventArgs e)
        {
            this.progressing.Text = "Searching for nearby drivers....";
            await Task.Delay(1000);
            this.progressing.Text = "Driver found, He is coming!!!";
            await Task.Delay(1000);
            this.progressing.Text = "Trip in progress.....";
            await Task.Delay(10000);
            this.progressing.Text = "Complete!!";
            await Task.Delay(1000);
            this.Hide();
            MainForm1 mainform = new MainForm1();
            mainform.ShowDialog();
        }
    }
}
