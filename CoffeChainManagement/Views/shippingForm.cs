using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement
{
	public partial class shippingForm : Form
	{
		public shippingForm()
		{
			InitializeComponent();
		}

		private void shippingForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet18.Shipping' table. You can move, or remove it, as needed.
			this.shippingTableAdapter1.Fill(this.coffeChainManagementDBDataSet18.Shipping);
			// TODO: This line of code loads data into the 'coffeChainManagementDBDataSet17.Shipping' table. You can move, or remove it, as needed.
			this.shippingTableAdapter.Fill(this.coffeChainManagementDBDataSet17.Shipping);

        }
		private void InitiaalizeMap()
		{
			gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; // Để sử dụng bản đồ từ server và lưu cache
			gMapControl1.ShowCenter = false;
			gMapControl1.MinZoom = 2;
			gMapControl1.MaxZoom = 18;
			gMapControl1.Zoom = 12;
			gMapControl1.Position = new GMap.NET.PointLatLng(0, 0); // Đặt vị trí khởi đầu
		}


		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			
		}


		private void gMapControl1_Load(object sender, EventArgs e)
		{
			this.shippingTableAdapter1.Fill(this.coffeChainManagementDBDataSet18.Shipping);
			InitiaalizeMap(); // Gọi hàm khởi tạo bản đồ
		}

		private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridView1.SelectedRows[0];

				// Kiểm tra giá trị hợp lệ của Latitude và Longitude
				if (selectedRow.Cells[8].Value != DBNull.Value && selectedRow.Cells[9].Value != DBNull.Value)
				{
					double latitude = Convert.ToDouble(selectedRow.Cells[8].Value);
					double longitude = Convert.ToDouble(selectedRow.Cells[9].Value);

					gMapControl1.Position = new GMap.NET.PointLatLng(latitude, longitude);
					var markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
					var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
						new GMap.NET.PointLatLng(latitude, longitude),
						GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
					markers.Markers.Add(marker);

					gMapControl1.Overlays.Clear();
					gMapControl1.Overlays.Add(markers);
				}

				else
				{
					MessageBox.Show("Latitude hoặc Longitude không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

        private void dataGridView1_SelectionChanged_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Kiểm tra giá trị hợp lệ của Latitude và Longitude
                if (selectedRow.Cells[8].Value != DBNull.Value && selectedRow.Cells[9].Value != DBNull.Value)
                {
                    double latitude = Convert.ToDouble(selectedRow.Cells[8].Value);
                    double longitude = Convert.ToDouble(selectedRow.Cells[9].Value);

                    gMapControl1.Position = new GMap.NET.PointLatLng(latitude, longitude);
                    var markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
                    var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(latitude, longitude),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
                    markers.Markers.Add(marker);

                    gMapControl1.Overlays.Clear();
                    gMapControl1.Overlays.Add(markers);
                }

                else
                {
                    MessageBox.Show("Latitude hoặc Longitude không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
