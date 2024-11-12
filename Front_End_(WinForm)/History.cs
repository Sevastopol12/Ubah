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
using Fe;

namespace Project
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear existing rows and columns
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Add a single column
            dataGridView1.Columns.Add("Column1", "Data");

            // Populate rows
            foreach (string item in FormUser.user.ShowTripHistory().Split("\n\n").ToList()) 
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
