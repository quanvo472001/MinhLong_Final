using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food.NewFolder1
{
    public partial class FormPayment : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-3JNHTJUV\SQLEXPRESS01;Initial Catalog=QLThucPham;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableProductInformation = new DataTable();
        DataView dataTableProduct;
        DataView dataTableInvoice;
        // Đổ dữ liệu vào bảng thông tin sản phẩm
        void LoadData1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaSanPham,TenSanPham,SoLuong,DonGia from SANPHAM";
            adapter.SelectCommand = command;
            tableProductInformation.Clear();
            adapter.Fill(tableProductInformation);
            dgvProductInformation.DataSource = tableProductInformation;
            dataTableProduct = new DataView(tableProductInformation);

        }
        // Đổ dữ liệu vào bảng thông tin hóa đơn
        DataTable tableInvoiceInformation = new DataTable();

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT HOADON.MaHD,SANPHAM.MaSanPham,TenSanPham,KHACHHANG.IdKhachHang,TenKhachHang,CHITIETHOADON.SoLuong,DonGia,DonGia*CHITIETHOADON.SoLuong AS 'Total Price',NgayBan FROM SANPHAM ,HOADON ,KHACHHANG ,CHITIETHOADON  where (SANPHAM.MaSanPham = CHITIETHOADON.MaSanPham) AND (HOADON.IdKhachHang = KHACHHANG.IdKhachHang) AND (HOADON.MaHD=CHITIETHOADON.MaHD)";
            adapter.SelectCommand = command;
            tableInvoiceInformation.Clear();
            adapter.Fill(tableInvoiceInformation);
            dgvInvoiceInformation.DataSource = tableInvoiceInformation;
            dataTableInvoice = new DataView(tableInvoiceInformation);

        }
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData1();
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
            EditTablesFormPayment();
           
        }
        void AutoIncreaseCustomerCode()
        {
            
        }
        //chỉnh sửa 2 bảng trong form payment
        public void EditTablesFormPayment()
        {
            //Đoi ten bang thong tin San Pham
            dgvProductInformation.Columns[0].HeaderText = "Product's Code";
            dgvProductInformation.Columns[1].HeaderText = "Product's Name";
            dgvProductInformation.Columns[2].HeaderText = "Quantity";
            dgvProductInformation.Columns[3].HeaderText = "Price";
            dgvProductInformation.Columns[3].DefaultCellStyle.Format = "00,0";
            dgvProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Đoi ten bang thong tin Hoa Don
            dgvInvoiceInformation.Columns[0].HeaderText = "Code Bill";
            dgvInvoiceInformation.Columns[1].HeaderText = "Product's Code";
            dgvInvoiceInformation.Columns[2].HeaderText = "Product's Name";
            dgvInvoiceInformation.Columns[5].HeaderText = "Quantity";
            dgvInvoiceInformation.Columns[6].HeaderText = "Price";
            dgvInvoiceInformation.Columns[7].HeaderText = "Total";
            dgvInvoiceInformation.Columns[8].HeaderText = "Day Of Sale";
            //Format gia tri tien te
            dgvInvoiceInformation.Columns[6].DefaultCellStyle.Format = "00,0";
            dgvInvoiceInformation.Columns[7].DefaultCellStyle.Format = "00,0";
            //An cot khong can hien thi, nhung can dung gia tri cua no
            dgvInvoiceInformation.Columns[3].Visible = false;
            dgvInvoiceInformation.Columns[1].Visible = false;
            dgvInvoiceInformation.Columns[4].Visible = false;
            dgvInvoiceInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvProductInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvProductInformation.CurrentRow.Index;
            txtProductCode.Text = dgvProductInformation.Rows[i].Cells[0].Value.ToString();
            txtProductName.Text = dgvProductInformation.Rows[i].Cells[1].Value.ToString();
            txtPrice.Text = dgvProductInformation.Rows[i].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            command = connection.CreateCommand();
            command.CommandText = "insert into KHACHHANG(TenKhachHang) values('" + txtCustomerName.Text + "')";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO HOADON(IdKhachHang , NgayBan) SELECT TOP 1 KHACHHANG.IdKhachHang,'"+dtpDaleOfSale.Text+"' FROM KHACHHANG ORDER BY IdKhachHang DESC";
            command.ExecuteNonQuery();
            command.CommandText = "insert into CHITIETHOADON(MaHD,SoLuong,MaSanPham) SELECT TOP 1 HOADON.MaHD, '" + nupQuantity.Text + "','" + txtProductCode.Text + "' FROM HOADON ORDER BY MaHD DESC";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
        }
        public void SetDefault()
        {

            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Text = "";
                }
                else
                {
                    if (ctr is NumericUpDown)
                    {
                        NumericUpDown nup = (NumericUpDown)ctr;
                        nup.Text = "";
                    }
                    else
                    {
                        if (ctr is DateTimePicker)
                        {
                            DateTimePicker dtp = (DateTimePicker)ctr;
                            dtp.Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update  HOADON set NgayBan = '" + dtpDaleOfSale.Text + "' where MaHD ='" + txtCodeBill.Text + "'";
            command.ExecuteNonQuery();
            command.CommandText = "update  KHACHHANG set TenKhachHang ='" + txtCustomerName.Text + "'  where IdKhachHang ='" + txtCustomerCode.Text + "'";
            command.ExecuteNonQuery();
            command.CommandText = "update  CHITIETHOADON set SoLuong = '" + nupQuantity.Text + "'  where MaHD ='" + txtCodeBill.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KHACHHANG where IdKhachHang ='" + txtCustomerCode.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
            // em dùng Tạo khóa ngoại với ràng buộc tự động xóa bằng lệnh CREATE TABLE nên chỉ cần 1 lệnh này để xóa hết dữ liệu toàn bộ 3 bảng (HOADON,CHITTIETHOADON va KHACHHANG)
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCodeBill.ReadOnly = true;
            SetDefault();
        }

        private void dgvInvoiceInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeBill.ReadOnly = true;
            txtCustomerCode.ReadOnly = true;
            txtProductCode.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtCustomerCode.ReadOnly = true;
            int i;
            i = dgvInvoiceInformation.CurrentRow.Index;
            txtCodeBill.Text = dgvInvoiceInformation.Rows[i].Cells[0].Value.ToString();
            txtProductCode.Text = dgvInvoiceInformation.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dgvInvoiceInformation.Rows[i].Cells[2].Value.ToString();
            txtCustomerCode.Text = dgvInvoiceInformation.Rows[i].Cells[3].Value.ToString();
            txtCustomerName.Text = dgvInvoiceInformation.Rows[i].Cells[4].Value.ToString();
            nupQuantity.Text = dgvInvoiceInformation.Rows[i].Cells[5].Value.ToString();
            txtPrice.Text = dgvInvoiceInformation.Rows[i].Cells[6].Value.ToString();
            dtpDaleOfSale.Text = dgvInvoiceInformation.Rows[i].Cells[8].Value.ToString();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            dataTableProduct.RowFilter = "TenSanPham like '%" + txtSearchProduct.Text + "%'";
            dgvProductInformation.DataSource = dataTableProduct;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataTableInvoice.RowFilter = "TenKhachHang like '%" + textBox1.Text + "%'";

            dgvInvoiceInformation.DataSource = dataTableInvoice;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
