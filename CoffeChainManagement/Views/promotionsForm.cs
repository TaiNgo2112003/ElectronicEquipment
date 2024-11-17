using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder; // Thư viện để tạo mã QR
using CoffeChainManagement.Models; // Đảm bảo rằng bạn đã có các mô hình này
using CoffeChainManagement.Controller; // Đảm bảo rằng bạn đã có các controller này

namespace CoffeChainManagement
{
    public partial class promotionsForm : Form
    {
        private PromotionController promotionController = new PromotionController(); // Khởi tạo controller

        public promotionsForm()
        {
            InitializeComponent();
        }

        private void promotionsForm_Load(object sender, EventArgs e)
        {
            // Load dữ liệu từ bảng Promotion vào DataGridView
            this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn in phiếu giảm giá này không ?", "Xác nhận in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet4.PromotionRow;
                        if (rowoob != null)
                        {
                            int id = rowoob.Id;
                            string promotionName = rowoob.PromotionName;
                            decimal discount = rowoob.Discount;
                            DateTime startDate = rowoob.StartDate;
                            DateTime endDate = rowoob.EndDate;
                            printPromotion(id, promotionName, discount, startDate, endDate);
                        }
                    }
                }
            }
        }

        private void printPromotion(int id, string promotionName, decimal discount, DateTime startDate, DateTime endDate)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                // Tạo mã QR
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(id.ToString(), QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                    {
                        // Vẽ nội dung lên trang
                        string text = $"Giảm giá: {discount}%\n" +
                                      $"Ngày bắt đầu: {startDate.ToShortDateString()}\n" +
                                      $"Ngày kết thúc: {endDate.ToShortDateString()}";

                        e.Graphics.DrawString(text, new Font("Arial", 10), Brushes.Black, new PointF(100, 100));
                        e.Graphics.DrawImage(qrCodeImage, new PointF(100, 150)); // Vẽ mã QR xuống dưới nội dung văn bản
                    }
                }
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            printPreviewDialog.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string promotionName = txtPromotionName.Text;
            decimal discountPercent = decimal.Parse(txtDiscountPercent.Text);
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;

            // Tạo đối tượng Promotion
            Promotion newPromotion = new Promotion
            {
                PromotionName = promotionName,
                Discount = discountPercent,
                StartDate = startDate,
                EndDate = endDate
            };

            // Lưu khuyến mãi
            bool isSuccess = promotionController.Save(newPromotion);
            if (isSuccess)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!");
                this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet4.PromotionRow;
                        if (rowoob != null)
                        {
                            int id = rowoob.Id;
                            Promotion promotionToDelete = new Promotion { Id = id };

                            bool isSuccess = promotionController.Delete(promotionToDelete);
                            if (isSuccess)
                            {
                                MessageBox.Show("Xóa khuyến mãi thành công!");
                                this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
                            }
                            else
                            {
                                MessageBox.Show("Xóa khuyến mãi thất bại!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để xóa.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet4.PromotionRow;
                    if (rowoob != null)
                    {
                        int id = rowoob.Id;
                        string promotionName = txtPromotionName.Text;
                        decimal discountPercent = decimal.Parse(txtDiscountPercent.Text);
                        DateTime startDate = dateTimePickerStartDate.Value;
                        DateTime endDate = dateTimePickerEndDate.Value;

                        // Tạo đối tượng Promotion để cập nhật
                        Promotion promotionToUpdate = new Promotion
                        {
                            Id = id,
                            PromotionName = promotionName,
                            Discount = discountPercent,
                            StartDate = startDate,
                            EndDate = endDate
                        };

                        bool isSuccess = promotionController.Update(promotionToUpdate);
                        if (isSuccess)
                        {
                            MessageBox.Show("Cập nhật khuyến mãi thành công!");
                            this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khuyến mãi thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để sửa.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string promotionName = txtPromotionName.Text;
            decimal discountPercent = decimal.Parse(txtDiscountPercent.Text);
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;

            // Tạo đối tượng Promotion
            Promotion newPromotion = new Promotion
            {
                PromotionName = promotionName,
                Discount = discountPercent,
                StartDate = startDate,
                EndDate = endDate
            };

            // Lưu khuyến mãi
            bool isSuccess = promotionController.Save(newPromotion);
            if (isSuccess)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!");
                this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet4.PromotionRow;
                        if (rowoob != null)
                        {
                            int id = rowoob.Id;
                            Promotion promotionToDelete = new Promotion { Id = id };

                            bool isSuccess = promotionController.Delete(promotionToDelete);
                            if (isSuccess)
                            {
                                MessageBox.Show("Xóa khuyến mãi thành công!");
                                this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
                            }
                            else
                            {
                                MessageBox.Show("Xóa khuyến mãi thất bại!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để xóa.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var rowoob = ((System.Data.DataRowView)row.DataBoundItem)?.Row as Data.CoffeChainManagementDBDataSet4.PromotionRow;
                    if (rowoob != null)
                    {
                        int id = rowoob.Id;
                        string promotionName = txtPromotionName.Text;
                        decimal discountPercent = decimal.Parse(txtDiscountPercent.Text);
                        DateTime startDate = dateTimePickerStartDate.Value;
                        DateTime endDate = dateTimePickerEndDate.Value;

                        // Tạo đối tượng Promotion để cập nhật
                        Promotion promotionToUpdate = new Promotion
                        {
                            Id = id,
                            PromotionName = promotionName,
                            Discount = discountPercent,
                            StartDate = startDate,
                            EndDate = endDate
                        };

                        bool isSuccess = promotionController.Update(promotionToUpdate);
                        if (isSuccess)
                        {
                            MessageBox.Show("Cập nhật khuyến mãi thành công!");
                            this.promotionTableAdapter.Fill(this.coffeChainManagementDBDataSet4.Promotion); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khuyến mãi thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để sửa.");
            }
        }
    }
}
