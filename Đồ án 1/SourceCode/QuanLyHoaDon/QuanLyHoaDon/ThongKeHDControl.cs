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
    public partial class ThongKeHDControl : UserControl
    {
        public ThongKeHDControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                connection.Open();
                SqlCommand cmd = new SqlCommand("exec sp_Monthly_Statistic '" + date + "'", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
        }   
    }
}
