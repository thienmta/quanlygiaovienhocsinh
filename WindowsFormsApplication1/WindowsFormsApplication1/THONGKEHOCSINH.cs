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
using System.Data;
namespace WindowsFormsApplication1
{
    public partial class THONGKEHOCSINH : Form
    {
        ConnectDB conn = new ConnectDB();
        public THONGKEHOCSINH()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHocSinh.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void THONGKEHOCSINH_Load(object sender, EventArgs e)
        {
            show_LopHoc();
        }
        private void show_LopHoc()
        {
            string sql = "select * from LOP";

            cmbLopHoc.DataSource = conn.GetDataTable(sql);
            cmbLopHoc.ValueMember = "IDLOP";
            cmbLopHoc.DisplayMember = "TENLOP";
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenDB();
                SqlCommand cmd = new SqlCommand("ThongKeHocSinh", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@idlop", Convert.ToString(cmbLopHoc.SelectedValue));
                cmd.Parameters.Add(p);          
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHocSinh.DataSource = dt;
                conn.CloseDB();
            }
            catch
            {
                MessageBox.Show("lỗi, không hiển thị được dữ liệu!");
            }
        }

      
    }
}
