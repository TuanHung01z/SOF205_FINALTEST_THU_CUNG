using BUS.Services;
using DAL.Models;


namespace PRL.Forms
{
    public partial class Form1 : Form
    {
        ThuCungService _service;
        List<Thucung> _listTC = new();
        int _IdWhenClick;
        public Form1()
        {
            InitializeComponent();
            _service = new ThuCungService();
            LoadGird(null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadGird(null);
        }
        public void LoadGird(string search)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 5;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Tên";
            dtgView.Columns[2].Name = "Loài";
            dtgView.Columns[3].Name = "Màu Lông";
            dtgView.Columns[4].Name = "Tuổi";
            _listTC = _service.GetAll(search);
            foreach (var tc in _service.GetAll(txtSearch.Text))
            {
                int stt = _listTC.IndexOf(tc) + 1;
                dtgView.Rows.Add(stt, tc.Ten, tc.Loai, tc.Maulong, tc.Tuoi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tc = new Thucung();
            tc.Ten = txtTen.Text;
            tc.Loai = txtLoai.Text;
            tc.Maulong = txtMauLong.Text;
            tc.Tuoi = Convert.ToInt32(txtTuoi.Text);
            var option = MessageBox.Show("Xác nhận muốn thêm thú cưng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(tc));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tc = new Thucung();
            tc.Id = _IdWhenClick;
            tc.Ten = txtTen.Text;
            tc.Loai = txtLoai.Text;
            tc.Maulong = txtMauLong.Text;
            tc.Tuoi = Convert.ToInt32(txtTuoi.Text);
            var option = MessageBox.Show("Xác nhận muốn sửa thú cưng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(tc));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var tc = new Thucung();
            tc.Id = _IdWhenClick;
            var option = MessageBox.Show("Xác nhận muốn Xoá thú cưng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(tc));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listTC.Count)
            {
                return;
            }
            var obj = _listTC[index];
            _IdWhenClick = obj.Id;
            txtTen.Text = obj.Ten;
            txtLoai.Text = obj.Loai;
            txtMauLong.Text = obj.Maulong;
            txtTuoi.Text = obj.Tuoi.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }
    }
}
