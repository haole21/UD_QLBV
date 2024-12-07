namespace GUI_QLBV
{
    partial class GUI_KhoaNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_KhoaNV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.cbo_Khoa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_KhoaNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 280);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khoa Nhân Viên";
            // 
            // dgv_KhoaNV
            // 
            this.dgv_KhoaNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhoaNV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_KhoaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoaNV.Location = new System.Drawing.Point(6, 19);
            this.dgv_KhoaNV.Name = "dgv_KhoaNV";
            this.dgv_KhoaNV.Size = new System.Drawing.Size(572, 244);
            this.dgv_KhoaNV.TabIndex = 0;
            this.dgv_KhoaNV.Click += new System.EventHandler(this.dgv_KhoaNV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, -47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 37);
            this.label7.TabIndex = 120;
            this.label7.Text = "Thông Tin Khoa ";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(594, 503);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 115;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(311, 503);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 35);
            this.btn_LamMoi.TabIndex = 113;
            this.btn_LamMoi.Text = "Làm mới ";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(195, 506);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 110;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(78, 506);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 35);
            this.btn_Them.TabIndex = 109;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Khoa :";
            // 
            // txt_key
            // 
            this.txt_key.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_key.Location = new System.Drawing.Point(396, 465);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(192, 20);
            this.txt_key.TabIndex = 114;
            this.txt_key.Text = "Nhập tên nhân viên cần tìm";
            this.txt_key.Enter += new System.EventHandler(this.txt_key_Enter);
            this.txt_key.Leave += new System.EventHandler(this.txt_key_Leave);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(594, 465);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 112;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 37);
            this.label1.TabIndex = 122;
            this.label1.Text = "Thông Tin Khoa Nhân Viên ";
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.lb_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Khoa.Location = new System.Drawing.Point(533, 76);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(26, 16);
            this.lb_Khoa.TabIndex = 126;
            this.lb_Khoa.Text = "ID :";
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhanVien.Location = new System.Drawing.Point(533, 116);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(26, 16);
            this.lb_NhanVien.TabIndex = 125;
            this.lb_NhanVien.Text = "ID :";
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(311, 116);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(200, 21);
            this.cbo_NhanVien.TabIndex = 124;
            this.cbo_NhanVien.SelectedValueChanged += new System.EventHandler(this.cbo_NhanVien_SelectedValueChanged);
            // 
            // cbo_Khoa
            // 
            this.cbo_Khoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_Khoa.FormattingEnabled = true;
            this.cbo_Khoa.Location = new System.Drawing.Point(311, 76);
            this.cbo_Khoa.Name = "cbo_Khoa";
            this.cbo_Khoa.Size = new System.Drawing.Size(200, 21);
            this.cbo_Khoa.TabIndex = 123;
            this.cbo_Khoa.SelectedValueChanged += new System.EventHandler(this.cbo_Khoa_SelectedValueChanged);
            // 
            // GUI_KhoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLBV.Properties.Resources.knv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 581);
            this.Controls.Add(this.lb_Khoa);
            this.Controls.Add(this.lb_NhanVien);
            this.Controls.Add(this.cbo_NhanVien);
            this.Controls.Add(this.cbo_Khoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.btn_TimKiem);
            this.Name = "GUI_KhoaNV";
            this.Text = "GUI_KhoaNV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_KhoaNV_FormClosing);
            this.Load += new System.EventHandler(this.GUI_KhoaNV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_KhoaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.ComboBox cbo_Khoa;
    }
}