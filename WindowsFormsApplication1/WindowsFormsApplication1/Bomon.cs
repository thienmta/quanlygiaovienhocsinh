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
    public partial class Bomon : Form
    {
<<<<<<< HEAD
        string strConn = @"Data Source=HAPRO955\SQLEXPRESS; Database=QuanLiGiaoVienHocSinh; Integrated Security=True";
=======
        string strConn = "Data Source=.\\SQLEXPRESS; Initial Catalog = QUANLYGIAOVIENHOCSINH; Integrated Security = True";
>>>>>>> origin/master
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOMON", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBoMon.DataSource = dt;
            txtIDBoMon.Enabled = false;
            btnLuu.Enabled = false;
        }

        public Bomon()
        {
            InitializeComponent();
        }

        private void Bomon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        int index;
        private void dgvBoMon_Click(object sender, EventArgs e)
        {
            index = dgvBoMon.CurrentRow.Index;
            txtIDBoMon.Text = dgvBoMon.Rows[index].Cells[1].Value.ToString();
            txtTenBoMon.Text = dgvBoMon.Rows[index].Cells[2].Value.ToString();
        }

        private void dgvBoMon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvBoMon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDBoMon.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDBoMon.Enabled = false;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaBoMon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDBoMon.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtTenBoMon.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (txtTenBoMon.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemBoMon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@Ten", txtTenBoMon.Text);
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
                SqlCommand cmd = new SqlCommand("SuaBoMon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtIDBoMon.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtTenBoMon.Text);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát chương trình ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traloi==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
