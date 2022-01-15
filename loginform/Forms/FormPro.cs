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
    public partial class FormPro : Form
    {
        // đổ dữ liệu vào bảng duy nhất trên form
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-3JNHTJUV\SQLEXPRESS01;Initial Catalog=QLThucPham;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataView dataTable;
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SANPHAM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataTable = new DataView(table);
            dgvListOfProducts.DataSource = table;
            
        }
 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataTable.RowFilter = "TenSanPham like '%" + txtSearch.Text + "%'";
            dgvListOfProducts.DataSource = dataTable;
        }
        public FormPro()
        {
            InitializeComponent();
        }

        private void FormPro_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
            EditTableListOfProducts();
        }

        private void dgvListOfProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
            int i;
            i = dgvListOfProducts.CurrentRow.Index;
            txtProductCode.Text = dgvListOfProducts.Rows[i].Cells[0].Value.ToString();
            txtProductName.Text = dgvListOfProducts.Rows[i].Cells[1].Value.ToString();
            nupQuantity.Text = dgvListOfProducts.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dgvListOfProducts.Rows[i].Cells[3].Value.ToString();
            dtpDateAdded.Text = dgvListOfProducts.Rows[i].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into SANPHAM values('"+ txtProductName.Text+"','"+ nupQuantity.Text+"','"+ txtPrice.Text+"','"+ dtpDateAdded.Text+"')";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from SANPHAM where MaSanPham='"+ txtProductCode.Text+"'";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            command = connection.CreateCommand();
            command.CommandText = "update SANPHAM set TenSanPham ='"+ txtProductName.Text + "',SoLuong= '" + nupQuantity.Text + "',DonGia='" + txtPrice.Text + "',NgayNhap='" + dtpDateAdded.Text + "' where MaSanPham='" + txtProductCode.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
            SetDefault();
        }
       
        //Format bảng
        public void EditTableListOfProducts()
        {
            dgvListOfProducts.Columns[0].HeaderText = "Product's Code";
            dgvListOfProducts.Columns[1].HeaderText = "Product's Name";
            dgvListOfProducts.Columns[2].HeaderText = "Quantity";
            dgvListOfProducts.Columns[3].HeaderText = "Price";
            dgvListOfProducts.Columns[3].DefaultCellStyle.Format = "00,0";
            dgvListOfProducts.Columns[4].HeaderText = "Date Added";
            dgvListOfProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        //test   
      
        //endtest

        private void btnReset_Click(object sender, EventArgs e)
        {
          
            SetDefault();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
