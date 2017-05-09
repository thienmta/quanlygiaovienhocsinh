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
    public partial class Hocsinh : Form
    {
        string strConn = @"Data Source=HAPRO955\SQLEXPRESS; Database=QuanLiGiaoVienHocSinh; Integrated Security=True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOCSINH", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
            txtIDHocSinh.Enabled = false;
            btnLuu.Enabled = false;
        }

        public Hocsinh()
        {
            InitializeComponent();
        }

        private void show_HocSinh()
        {
            string sql = "SELECT * FROM HOCSINH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGioiTinh.DataSource = dt;
            cmbGioiTinh.ValueMember = "GIOITINH";
            cmbGioiTinh.DisplayMember = "GIOITINH";
        }

        private void show_Lop()
        {
            string sql = "SELECT * FROM LOP";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIDLop.DataSource = dt;
            cmbIDLop.ValueMember = "IDLOP";
            cmbIDLop.DisplayMember = "IDLOP";
        }

        private void Hocsinh_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            show_HocSinh();
            show_Lop();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        int index;
        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            index = dgvHocSinh.CurrentRow.Index;
            txtIDHocSinh.Text = dgvHocSinh.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dgvHocSinh.Rows[index].Cells[2].Value.ToString();
            cmbGioiTinh.Text = dgvHocSinh.Rows[index].Cells[3].Value.ToString();
            dtNgaySinh.Text = dgvHocSinh.Rows[index].Cells[4].Value.ToString();
            cmbIDLop.Text = dgvHocSinh.Rows[index].Cells[5].Value.ToString();
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDHocSinh.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDHocSinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            a = 0;
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
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Báo");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemHocSinh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@Ten", txtHoTen.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Gt", cmbGioiTinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Ngaysinh", dtNgaySinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@Malop", cmbIDLop.Text);
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
                SqlCommand cmd = new SqlCommand("SuaHocSinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDHocSinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtHoTen.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Gt", cmbGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ngaysinh", dtNgaySinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Malop", cmbIDLop.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaHocSinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDHocSinh.Text);
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
