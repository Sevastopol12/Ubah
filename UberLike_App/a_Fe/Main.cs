using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;
using Ubah;
using BFE;
using System.Diagnostics;
using Project;


namespace Fe
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            Login login = new Login();
            Progress progress = new Progress();
        }

        private void ValidCheck()
        {
            if ((this.loc.Text == null) |
                (this.des.Text == null))
            {
                throw new Exception("Invalid location or destination");
            }
            
        }

        private async void preview_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidCheck();
                Dictionary<string, object> location = Ubah.System.CastLoc(loc.Text);
                Dictionary<string, object> destination = Ubah.System.CastLoc(des.Text);

                FormUser.meineTrip = await FormUser.user.RequestRide(pickup: location, dropoff: destination);
                if (FormUser.meineTrip is null) { throw new Exception(); }

                Location locationen = FormUser.meineTrip.PickupLocation;
                double latitude = locationen.Latitude;
                double longitude = locationen.Longitude;

                string meineLoc = $"https://www.openstreetmap.org/#map=20/{latitude}/{longitude}";

                webView21.CoreWebView2.Navigate(meineLoc);
                this.farevar.Text = $"{FormUser.meineTrip.FareAmount.ToString()} $";
                this.disvar.Text = $"{FormUser.meineTrip.TravelDistance.ToString()} km";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Location or Address cannot be found, try other location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void request_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidCheck();
                FormUser.user.StartTrip(trip: FormUser.meineTrip);

                Progress progress = new Progress();
                this.Hide();
                progress.ShowDialog();
                this.loc.Text = null;
                this.des.Text = null;
                this.farevar.Text = null;
                this.disvar.Text = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Location or Address cannot be found, try other location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MainForm1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            int zoom = 10;
            double latitude = 10.7509540;
            double longitude = 106.6504227;

            string url = $"https://www.openstreetmap.org/#map={zoom}/{latitude}/{longitude}";
            webView21.CoreWebView2.Navigate(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.des.Text = "59C Nguyễn Đình Chiểu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.des.Text = "279 Nguyễn Tri Phương";
        }

        private void myhistory_Click_1(object sender, EventArgs e)
        {
            Form4 history = new Form4();
            this.Hide();
            history.ShowDialog();
            this.Show();
        }


        // Nút trở lại
    }
}
