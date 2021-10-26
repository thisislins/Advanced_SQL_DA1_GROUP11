using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoaDon
{
    public partial class XemHDControl : UserControl
    {
        public XemHDControl()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=KAYDEE\\SQLEXPRESS;Initial Catalog=QuanLyHoaDon;Integrated Security=True");
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        void LoadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT* FROM HOADON", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void XemHDControl_Load(object sender, EventArgs e)
        {

        }
    }
}
