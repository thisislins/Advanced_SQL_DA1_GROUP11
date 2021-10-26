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
        
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            /*using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }*/
            LoadData();
        }

        void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT* FROM HOADON", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
        }

        private void XemHDControl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
