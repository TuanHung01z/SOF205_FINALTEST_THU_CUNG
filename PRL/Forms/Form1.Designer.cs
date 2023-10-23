namespace PRL.Forms
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtLoai = new TextBox();
            txtMauLong = new TextBox();
            txtTuoi = new TextBox();
            btnHienThi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dtgView = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 50);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 84);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Màu Lông";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 122);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 3;
            label4.Text = "Tuổi";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(170, 6);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(437, 31);
            txtTen.TabIndex = 4;
            // 
            // txtLoai
            // 
            txtLoai.Location = new Point(170, 43);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(437, 31);
            txtLoai.TabIndex = 5;
            // 
            // txtMauLong
            // 
            txtMauLong.Location = new Point(170, 78);
            txtMauLong.Name = "txtMauLong";
            txtMauLong.Size = new Size(437, 31);
            txtMauLong.TabIndex = 6;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(170, 115);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(437, 31);
            txtTuoi.TabIndex = 7;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(641, 3);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(112, 34);
            btnHienThi.TabIndex = 8;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(641, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(641, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(641, 112);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(4, 196);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 62;
            dtgView.Size = new Size(794, 254);
            dtgView.TabIndex = 12;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 152);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Mời nhập Tên / Loại cần tìm!";
            txtSearch.Size = new Size(437, 31);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(dtgView);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnHienThi);
            Controls.Add(txtTuoi);
            Controls.Add(txtMauLong);
            Controls.Add(txtLoai);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtLoai;
        private TextBox txtMauLong;
        private TextBox txtTuoi;
        private Button btnHienThi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dtgView;
        private TextBox txtSearch;
    }
}