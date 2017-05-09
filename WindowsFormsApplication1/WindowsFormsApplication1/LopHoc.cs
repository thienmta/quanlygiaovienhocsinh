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
    public partial class LopHoc : Form
    {
        string strConn = "Data Source=.\\SQLEXPRESS; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLopHoc.DataSource = dt;
            txtIDLopHoc.Enabled = false;
            btnLuu.Enabled = false;
        }

        public LopHoc()
        {
            InitializeComponent();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_MonToan()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=1";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVToan.DataSource = dt;
            cmbIDGVToan.ValueMember = "IDGiaoVien";
            cmbIDGVToan.DisplayMember = "IDGiaoVien";
        }
        private void show_MonLy()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=2";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVLy.DataSource = dt;
            cmbIDGVLy.ValueMember = "IDGiaoVien";
            cmbIDGVLy.DisplayMember = "IDGiaoVien";
        }
        private void show_MonHoa()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=3";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVHoa.DataSource = dt;
            cmbIDGVHoa.ValueMember = "IDGiaoVien";
            cmbIDGVHoa.DisplayMember = "IDGiaoVien";
        }
        private void show_MonSinh()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=4";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVSinh.DataSource = dt;
            cmbIDGVSinh.ValueMember = "IDGiaoVien";
            cmbIDGVSinh.DisplayMember = "IDGiaoVien";
        }
        private void show_MonSu()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=5";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVSu.DataSource = dt;
            cmbIDGVSu.ValueMember = "IDGiaoVien";
            cmbIDGVSu.DisplayMember = "IDGiaoVien";
        }
        private void show_MonDia()
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE IDBOMON=6";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVDia.DataSource = dt;
            cmbIDGVDia.ValueMember = "IDGiaoVien";
            cmbIDGVDia.DisplayMember = "IDGiaoVien";
        }
        private void show_GiaoVien()
        {
            string sql = "SELECT * FROM GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDGVCN.DataSource = dt;
            cmbIDGVCN.ValueMember = "IDGiaoVien";
            cmbIDGVCN.DisplayMember = "IDGiaoVien";
        }
        private void LopHoc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            show_MonToan();
            show_MonLy();
            show_MonHoa();
            show_MonSinh();
            show_MonSu();
            show_MonDia();
            show_GiaoVien();
        }

        private void dgvLopHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLopHoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        int index;
        private void dgvLopHoc_Click(object sender, EventArgs e)
        {
            index = dgvLopHoc.CurrentRow.Index;
            txtIDLopHoc.Text = dgvLopHoc.Rows[index].Cells[1].Value.ToString();
            txtTenLop.Text = dgvLopHoc.Rows[index].Cells[2].Value.ToString();
            cmbIDGVCN.Text = dgvLopHoc.Rows[index].Cells[3].Value.ToString();
            cmbIDGVToan.Text = dgvLopHoc.Rows[index].Cells[4].Value.ToString();
            cmbIDGVLy.Text = dgvLopHoc.Rows[index].Cells[5].Value.ToString();
            cmbIDGVHoa.Text = dgvLopHoc.Rows[index].Cells[6].Value.ToString();
            cmbIDGVSinh.Text = dgvLopHoc.Rows[index].Cells[7].Value.ToString();
            cmbIDGVSu.Text = dgvLopHoc.Rows[index].Cells[8].Value.ToString();
            cmbIDGVDia.Text = dgvLopHoc.Rows[index].Cells[9].Value.ToString();
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDLopHoc.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDLopHoc.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            a = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDLopHoc.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtTenLop.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (txtTenLop.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Báo");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemLop", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@Ten", txtTenLop.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magv", cmbIDGVCN.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvtoan", cmbIDGVToan.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvly", cmbIDGVLy.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvhoa", cmbIDGVHoa.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvsinh", cmbIDGVSinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvsu", cmbIDGVSu.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Magvdia", cmbIDGVDia.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới !");
                    }
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SuaLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDLopHoc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtTenLop.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magv", cmbIDGVCN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvtoan", cmbIDGVToan.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvly", cmbIDGVLy.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvhoa", cmbIDGVHoa.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvsinh", cmbIDGVSinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvsu", cmbIDGVSu.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Magvdia", cmbIDGVDia.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể sửa !");
                }
            }
        }
    }
}
