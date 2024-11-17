using CoffeeChainManagement;
using DashboardApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement
{
    public partial class MainPage : Form
    {
        bool sidebarExpand;
        public MainPage()
        {
            InitializeComponent();
        }
        public  void loadform(object Form)
        {
            if (this.boxforform.Controls.Count > 0)
                this.boxforform.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.boxforform.Controls.Add(f);
            this.boxforform.Tag = f;
            f.Show();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                } 
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
        }

        private void statisticalBtn_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform (new accountForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

		private void button3_Click(object sender, EventArgs e)
		{
            loadform(new Form1());
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			loadform(new Form1());

		}

		private void button4_Click(object sender, EventArgs e)
		{
            loadform(new Employee());
		}

		private void button7_Click(object sender, EventArgs e)
		{
            loadform((new promotionsForm()));
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
            loadform(new btnExportInventory());  
		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

		private void label3_Click_1(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
		}

		private void homeBtn_Click_1(object sender, EventArgs e)
		{
		}

		private void button8_Click(object sender, EventArgs e)
		{
            loadform(new orderForm());
		}

		private void homeBtn_Click_2(object sender, EventArgs e)
		{

		}

		private void button2_Click_2(object sender, EventArgs e)
		{
			this.Close();
		}

		private void supportBtn_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_3(object sender, EventArgs e)
		{
            loadform(new productForm()); 
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void supportBtn_Click_1(object sender, EventArgs e)
		{
			loadform(new supportForm());

		}

		private void homeBtn_Click_3(object sender, EventArgs e)
		{
			loadform(new mainForm());

		}

		private void button6_Click_1(object sender, EventArgs e)
		{
            loadform(new shippingForm());
		}

		private void homeBtn_Click_4(object sender, EventArgs e)
		{
            loadform(new mainForm());
		}

		private void logoutBtn_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void supportBtn_Click_2(object sender, EventArgs e)
		{
			loadform(new supportForm());
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/TaiNgo2112003/",
				UseShellExecute = true,
			});
		}

        private void phiênBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.Size = new Size(300, 200);
            popup.Text = "Thông tin Phiên bản";
            popup.BackColor = Color.LightGray;

            Label lblVersion = new Label();
            lblVersion.Text = "Phiên bản 1.0.0";
            lblVersion.Font = new Font("Arial", 12, FontStyle.Bold);
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(90, 40);
            popup.Controls.Add(lblVersion);

            Button btnGitHub = new Button();
            btnGitHub.Text = "Xem trên GitHub";
            btnGitHub.Size = new Size(120, 30);
            btnGitHub.Location = new Point(90, 80);
            btnGitHub.Click += (s, args) => System.Diagnostics.Process.Start("https://github.com/TaiNgo2112003/");
            popup.Controls.Add(btnGitHub);

            Button btnClose = new Button();
            btnClose.Text = "Đóng";
            btnClose.Size = new Size(120, 30);
            btnClose.Location = new Point(90, 120);
            btnClose.Click += (s, args) => popup.Close();
            popup.Controls.Add(btnClose);

            popup.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Close(); // Đóng form hiện tại sau khi form đăng ký được đóng
        }


        private void thôngTinDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.Size = new Size(400, 350);
            popup.Text = "Thông tin Nhóm";
            popup.BackColor = Color.White; // Màu nền của form

            // Tiêu đề
            Label lblTitle = new Label();
            lblTitle.Text = "Thông tin Nhóm 14";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 20);
            lblTitle.ForeColor = Color.DarkSlateBlue; // Màu chữ tiêu đề
            popup.Controls.Add(lblTitle);

            // Thông tin nhóm
            Label lblGroupInfo = new Label();
            lblGroupInfo.Text = "Các thành viên:\n" +
                                "• Ngô Bá Tấn Tài - 1050080197\n" +
                                "• Phan Thị Hồng Hiên - 1050080178\n" +
                                "Trưởng nhóm: Ngô Bá Tấn Tài\n" +
                                "Tỷ lệ đóng góp:\n" +
                                "Ngô Bá Tấn Tài: 60%\n" +
                                "Phan Thị Hồng Hiên: 40%";
            lblGroupInfo.Font = new Font("Arial", 12);
            lblGroupInfo.AutoSize = true;
            lblGroupInfo.Location = new Point(20, 70);
            lblGroupInfo.ForeColor = Color.Black; // Màu chữ
            popup.Controls.Add(lblGroupInfo);

            // Thông tin liên hệ
            Label lblContact = new Label();
            lblContact.Text = "Thông tin liên hệ:\n" +
                              "Email: contact@nhom14.com\n" +
                              "Điện thoại: 0123 456 789";
            lblContact.Font = new Font("Arial", 12);
            lblContact.AutoSize = true;
            lblContact.Location = new Point(20, 160);
            lblContact.ForeColor = Color.Black; // Màu chữ
            popup.Controls.Add(lblContact);

            // Nút Đóng
            Button btnClose = new Button();
            btnClose.Text = "Đóng";
            btnClose.Size = new Size(100, 30);
            btnClose.Location = new Point(150, 260);
            btnClose.BackColor = Color.LightCoral; // Màu nền nút
            btnClose.FlatStyle = FlatStyle.Flat; // Kiểu nút phẳng
            btnClose.ForeColor = Color.White; // Màu chữ nút
            btnClose.Click += (s, args) => popup.Close();
            popup.Controls.Add(btnClose);

            popup.ShowDialog();
        }



        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close(); // Đóng form hiện tại sau khi form đăng ký được đóng
        }

        private void báoLỗiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new supportForm());    
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new supportForm());

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Employee());
        }

        private void cấpMãGiáGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform((new promotionsForm()));

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new accountForm());

        }

        private void quảnLýTổngQuátSpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Form1());

        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new btnExportInventory());

        }

        private void quảnLýĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new orderForm());

        }

        private void quảnLýSpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new productForm());

        }

        private void quảnLýVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new shippingForm());

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
