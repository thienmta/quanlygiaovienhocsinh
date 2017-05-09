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
    public partial class GiaoVien : Form
    {
        string strConn = "Data Source=.\\SQLEXPRESS; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIAOVIEN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGiaoVien.DataSource = dt;
            txtIDGiaoVien.Enabled = false;
            btnLuu.Enabled = false;
        }

        public GiaoVien()
        {
            InitializeComponent();
        }

        private void Giaovien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            show_BoMon();
            show_GiaoVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvGiaoVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        int index;
        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {
            index = dgvGiaoVien.CurrentRow.Index;
            txtIDGiaoVien.Text = dgvGiaoVien.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dgvGiaoVien.Rows[index].Cells[2].Value.ToString();
            cmbGioiTinh.Text = dgvGiaoVien.Rows[index].Cells[3].Value.ToString();
            cmbIDBoMon.Text = dgvGiaoVien.Rows[index].Cells[4].Value.ToString();
        }

        private void show_BoMon()
        {
            string sql = "SELECT * FROM BOMON";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDBoMon.DataSource = dt;
            cmbIDBoMon.ValueMember = "IDBOMON";
            cmbIDBoMon.DisplayMember = "IDBOMON";
        }

        private void show_GiaoVien()
        {
            string sql = "SELECT * FROM GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGioiTinh.DataSource = dt;
            cmbGioiTinh.ValueMember = "GIOITINH";
            cmbGioiTinh.DisplayMember = "GIOITINH";
        }

        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDGiaoVien.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDGiaoVien.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            a = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a==1)
            {
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemGiaoVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@Ten", txtHoTen.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Gt", cmbGioiTinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaBM", cmbIDBoMon.Text);
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
                SqlCommand cmd = new SqlCommand("SuaGiaoVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDGiaoVien.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtHoTen.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Gt", cmbGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaBM", cmbIDBoMon.Text);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaGiaoVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDGiaoVien.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtHoTen.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }
    }
}
