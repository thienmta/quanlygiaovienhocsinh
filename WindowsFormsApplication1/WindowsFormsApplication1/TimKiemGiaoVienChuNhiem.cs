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
namespace WindowsFormsApplication1
{
    public partial class TimKiemGiaoVienChuNhiem : Form
    {
        string strConn = "Data Source=.\\SQLEXPRESS; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVienChuNhiem.DataSource = dt;
        }

        public TimKiemGiaoVienChuNhiem()
        {
            InitializeComponent();
        }

        private void TimKiemGiaoVienChuNhiem_Load(object sender, EventArgs e)
        {
            string sql = "select * from lop";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TIMKIEMGVCN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtIDLop.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVienChuNhiem.DataSource = dt;
        }
    }
}
