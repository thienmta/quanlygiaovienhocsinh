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
    public partial class TimKiemHocSinh : Form
    {
        string strConn = "Data Source=.\\SQLEXPRESS; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOCSINH", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemHocSinh.DataSource = dt;
        }

        public TimKiemHocSinh()
        {
            InitializeComponent();
        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HOCSINH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TIMKIEMHOCSINH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtIDHocSinh.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemHocSinh.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
