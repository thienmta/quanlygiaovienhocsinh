using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();
            lh.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new WindowsFormsApplication1.GiaoVien();
            gv.Show();
        }

        private void bộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bomon bm = new Bomon();
            bm.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new WindowsFormsApplication1.Hocsinh();
            hs.Show();
        }

        private void họcSinhToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh tkhs = new TimKiemHocSinh();
            tkhs.Show();
        }

        private void giáoViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien tkgv = new TimKiemGiaoVien();
            tkgv.Show();
        }

        private void giáoVienChuNhiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVienChuNhiem tkgvcn = new TimKiemGiaoVienChuNhiem();
            tkgvcn.Show();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }
    }
}
