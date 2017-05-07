namespace WindowsFormsApplication1
{
    partial class LopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDLopHoc = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cmbIDGVCN = new System.Windows.Forms.ComboBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbIDGVToan = new System.Windows.Forms.ComboBox();
            this.cmbIDGVHoa = new System.Windows.Forms.ComboBox();
            this.cmbIDGVLy = new System.Windows.Forms.ComboBox();
            this.cmbIDGVSinh = new System.Windows.Forms.ComboBox();
            this.cmbIDGVSu = new System.Windows.Forms.ComboBox();
            this.cmbIDGVDia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Lớp Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID GVCN";
            // 
            // txtIDLopHoc
            // 
            this.txtIDLopHoc.Location = new System.Drawing.Point(75, 16);
            this.txtIDLopHoc.Name = "txtIDLopHoc";
            this.txtIDLopHoc.Size = new System.Drawing.Size(216, 20);
            this.txtIDLopHoc.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(75, 55);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(216, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // cmbIDGVCN
            // 
            this.cmbIDGVCN.FormattingEnabled = true;
            this.cmbIDGVCN.Location = new System.Drawing.Point(75, 94);
            this.cmbIDGVCN.Name = "cmbIDGVCN";
            this.cmbIDGVCN.Size = new System.Drawing.Size(216, 21);
            this.cmbIDGVCN.TabIndex = 2;
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgvLopHoc.Location = new System.Drawing.Point(15, 184);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.Size = new System.Drawing.Size(861, 298);
            this.dgvLopHoc.TabIndex = 3;
            this.dgvLopHoc.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLopHoc_RowPrePaint);
            this.dgvLopHoc.Click += new System.EventHandler(this.dgvLopHoc_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(214, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(418, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(520, 140);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(622, 140);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID GV Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID GV Lý";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID GV Hóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID GV Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID GV Sử";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID GV Địa";
            // 
            // cmbIDGVToan
            // 
            this.cmbIDGVToan.FormattingEnabled = true;
            this.cmbIDGVToan.Location = new System.Drawing.Point(386, 16);
            this.cmbIDGVToan.Name = "cmbIDGVToan";
            this.cmbIDGVToan.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVToan.TabIndex = 2;
            // 
            // cmbIDGVHoa
            // 
            this.cmbIDGVHoa.FormattingEnabled = true;
            this.cmbIDGVHoa.Location = new System.Drawing.Point(386, 94);
            this.cmbIDGVHoa.Name = "cmbIDGVHoa";
            this.cmbIDGVHoa.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVHoa.TabIndex = 2;
            // 
            // cmbIDGVLy
            // 
            this.cmbIDGVLy.FormattingEnabled = true;
            this.cmbIDGVLy.Location = new System.Drawing.Point(386, 55);
            this.cmbIDGVLy.Name = "cmbIDGVLy";
            this.cmbIDGVLy.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVLy.TabIndex = 2;
            // 
            // cmbIDGVSinh
            // 
            this.cmbIDGVSinh.FormattingEnabled = true;
            this.cmbIDGVSinh.Location = new System.Drawing.Point(636, 16);
            this.cmbIDGVSinh.Name = "cmbIDGVSinh";
            this.cmbIDGVSinh.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVSinh.TabIndex = 2;
            // 
            // cmbIDGVSu
            // 
            this.cmbIDGVSu.FormattingEnabled = true;
            this.cmbIDGVSu.Location = new System.Drawing.Point(636, 55);
            this.cmbIDGVSu.Name = "cmbIDGVSu";
            this.cmbIDGVSu.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVSu.TabIndex = 2;
            // 
            // cmbIDGVDia
            // 
            this.cmbIDGVDia.FormattingEnabled = true;
            this.cmbIDGVDia.Location = new System.Drawing.Point(636, 94);
            this.cmbIDGVDia.Name = "cmbIDGVDia";
            this.cmbIDGVDia.Size = new System.Drawing.Size(140, 21);
            this.cmbIDGVDia.TabIndex = 2;
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 494);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.cmbIDGVHoa);
            this.Controls.Add(this.cmbIDGVDia);
            this.Controls.Add(this.cmbIDGVSu);
            this.Controls.Add(this.cmbIDGVSinh);
            this.Controls.Add(this.cmbIDGVLy);
            this.Controls.Add(this.cmbIDGVToan);
            this.Controls.Add(this.cmbIDGVCN);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtIDLopHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LopHoc";
            this.Text = "Lớp Học";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDLopHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cmbIDGVCN;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbIDGVToan;
        private System.Windows.Forms.ComboBox cmbIDGVHoa;
        private System.Windows.Forms.ComboBox cmbIDGVLy;
        private System.Windows.Forms.ComboBox cmbIDGVSinh;
        private System.Windows.Forms.ComboBox cmbIDGVSu;
        private System.Windows.Forms.ComboBox cmbIDGVDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}