using CoffeChainManagement.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace CoffeChainManagement
{
    public partial class orderForm : Form
    {
        private string connectionString = DbConnection_.DbConfig.ConnectionString;

        public orderForm()
        {
            InitializeComponent();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet16.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.coffeChainManagementDBDataSet16.Payment);
            foreach (DataGridViewColumn column in dataGridViewOrder.Columns)
            {
                Console.WriteLine(column.Name);  // In tên cột để kiểm tra
            }
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet12.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.coffeChainManagementDBDataSet12.OrderItem);
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet11.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.coffeChainManagementDBDataSet11.Order);

        }
        private DataTable dtOrder;
        private DataTable dtOrderItem;
        private DataTable dtPayment;
        private void loadOrderData()
        {
            string queryOrder = "SELECT Id, OrderDate, OrderNumber, CustomerId, TotalAmount, PromotionId FROM [Order]";
            using (SqlDataAdapter adapter = new SqlDataAdapter(queryOrder, connectionString))
            {
                dtOrder = new DataTable();
                adapter.Fill(dtOrder);
                dataGridViewOrder.DataSource = dtOrder;
            }
        }
        private void loadPayment(int OrderId)
        {
            string queryPayment = "SELECT * FROM Payment WHERE OrderId = @OrderId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryPayment, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", OrderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        dtPayment = new DataTable();
                        adapter.Fill(dtPayment);
                        dataGridViewPayment.DataSource = dtPayment;
                    }
                    connection.Close();
                }
            }
        }
        private void LoadOrderItemData(int orderId)
        {
            string queryOrderItem = "SELECT Id, OrderId, ProductId, UnitPrice, Quantity FROM OrderItem WHERE OrderId = @OrderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryOrderItem, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtOrderItem = new DataTable();
                        adapter.Fill(dtOrderItem);
                        dataGridViewOrderItem.DataSource = dtOrderItem;
                    }
                }

                connection.Close();
            }
        }
        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                {
                    int selectedOrderId = Convert.ToInt32(dataGridViewOrder.SelectedRows[0].Cells[0].Value);
                    LoadOrderItemData(selectedOrderId);
                    loadPayment(selectedOrderId);
                }
            }

        }
        private void Form_load(object sender, EventArgs e)
        {
            loadOrderData();
            dataGridViewOrder.SelectionChanged += new EventHandler(dataGridViewOrder_SelectionChanged);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridViewOrder.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 đơn hàng để in PDF !");
                return;
            }
            // Lấy thông tin đơn hàng được chọn
            int selectedOrderId = Convert.ToInt32(dataGridViewOrder.SelectedRows[0].Cells[0].Value);
            string orderNumber = dataGridViewOrder.SelectedRows[0].Cells[2].Value.ToString();
            string customerId = dataGridViewOrder.SelectedRows[0].Cells[3].Value.ToString();
            string totalAmount = dataGridViewOrder.SelectedRows[0].Cells[4].Value.ToString();

            string filePath = $"Order_{orderNumber}.pdf";
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            // Thêm tiêu đề
            document.Add(new Paragraph($"Order Number: {orderNumber}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            document.Add(new Paragraph($"Customer ID: {customerId}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
            document.Add(new Paragraph($"Total Amount: {totalAmount}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
            document.Add(new Paragraph(" ")); // Dòng trống

            // Thêm thông tin chi tiết đơn hàng
            document.Add(new Paragraph("Order Items:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
            PdfPTable tableOrderItem = new PdfPTable(dataGridViewOrderItem.Columns.Count);
            foreach (DataGridViewColumn column in dataGridViewOrderItem.Columns)
            {
                tableOrderItem.AddCell(new Phrase(column.HeaderText));
            }
            foreach (DataGridViewRow row in dataGridViewOrderItem.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    tableOrderItem.AddCell(cell.Value?.ToString());
                }
            }
            document.Add(tableOrderItem);

            // Thêm thông tin thanh toán
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("Payment Details:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
            PdfPTable tablePayment = new PdfPTable(dataGridViewPayment.Columns.Count);
            foreach (DataGridViewColumn column in dataGridViewPayment.Columns)
            {
                tablePayment.AddCell(new Phrase(column.HeaderText));
            }
            foreach (DataGridViewRow row in dataGridViewPayment.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    tablePayment.AddCell(cell.Value?.ToString());
                }
            }
            document.Add(tablePayment);

            // Đóng tài liệu PDF
            document.Close();
            // Mở file PDF sau khi tạo
            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file PDF.");
            }
            // Thông báo hoàn tất
            MessageBox.Show($"Đã in đơn hàng thành công ra file PDF tại: {filePath}");

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
