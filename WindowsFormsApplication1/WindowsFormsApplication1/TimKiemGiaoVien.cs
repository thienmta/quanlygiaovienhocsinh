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
    public partial class TimKiemGiaoVien : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIAOVIEN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVien.DataSource = dt;
        }
        public TimKiemGiaoVien()
        {
            InitializeComponent();
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TIMKIEMGIAOVIEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtIDGiaoVien.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVien.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
