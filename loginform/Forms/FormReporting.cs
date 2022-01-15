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
    public partial class FormReporting : Form
    {
        public FormReporting()
        {
            InitializeComponent();
        }
        //Tab Thống kê sản phẩm bán được từng tháng
        void LoadListBillByDate (DateTime checkDateStart, DateTime checkDateFinish)
        {
           dgvProductsSold.DataSource = Statistical.Instance.GetBillListByDate(checkDateStart, checkDateFinish);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
                LoadListBillByDate(dtpStart.Value, dtpFinish.Value);
                EditTableProductsSold();
        }
        public void EditTableProductsSold()
        {
            dgvProductsSold.Columns[0].HeaderText = "Product's Code";
            dgvProductsSold.Columns[1].HeaderText = "Product's Name";
            dgvProductsSold.Columns[2].HeaderText = "Price";
            dgvProductsSold.Columns[2].DefaultCellStyle.Format = "00,0";
            dgvProductsSold.Columns[3].HeaderText = "Quantity";
            dgvProductsSold.Columns[4].HeaderText = "Date of Sale";
            dgvProductsSold.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // cac tab Chart
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-3JNHTJUV\SQLEXPRESS01;Initial Catalog=QLThucPham;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void fillChartSellingProducts()
        {
            command = connection.CreateCommand();
            command.CommandText = "select TenSanPham,CHITIETHOADON.SoLuong From CHITIETHOADON, SANPHAM where SANPHAM.MaSanPham = CHITIETHOADON.MaSanPham";
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            chtSellingProduct.DataSource = ds;
            chtSellingProduct.Series["PRODUCTS SOLD"].XValueMember = "TenSanPham";
            chtSellingProduct.Series["PRODUCTS SOLD"].YValueMembers = "SoLuong";
            
        }
        private void fillChartDeepCustomers()
        {
            DataSet ds = new DataSet();
            command = connection.CreateCommand();
            command.CommandText = "Select TenKhachHang,SANPHAM.DonGia*CHITIETHOADON.SoLuong as'Total' from KHACHHANG,HOADON,SANPHAM,CHITIETHOADON where KHACHHANG.IdKhachHang = HOADON.IdKhachHang AND HOADON.MaHD=CHITIETHOADON.MaHD  AND CHITIETHOADON.MaSanPham = SANPHAM.MaSanPham";
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            chtDeepCustomers.DataSource = ds;
            chtDeepCustomers.Series["CUSTOMERS"].XValueMember = "TenKhachHang";
            chtDeepCustomers.Series["CUSTOMERS"].YValueMembers = "Total";

        }
        private void fillChartTotalRevenue()
        {
            DataSet ds = new DataSet();
            command = connection.CreateCommand();
            command.CommandText = "select NgayBan,CHITIETHOADON.SoLuong*DONGIA as Total From CHITIETHOADON, SANPHAM,HOADON where SANPHAM.MaSanPham = CHITIETHOADON.MaSanPham and CHITIETHOADON.MaHD=HOADON.MaHD";
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            chtTotalRevenue.DataSource = ds;
            chtTotalRevenue.Series["REVENUE"].XValueMember = "NgayBan";
            chtTotalRevenue.Series["REVENUE"].YValueMembers = "Total";
        }
        private void FormReporting_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            fillChartSellingProducts();
            fillChartDeepCustomers(); 
            fillChartTotalRevenue();
            }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFinish_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chtTotalRevenue_Click(object sender, EventArgs e)
        {

        }
    }
    }

