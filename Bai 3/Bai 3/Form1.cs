using System;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CbSoLuong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTien.Text = "";
            tinhTien();
        }
        private void CbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTien.Text = "";
            tinhTien();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RadioCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaThue.Text = "200";
        }

        private void RadioNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaThue.Text = "100";
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            radioNuaNgay.Checked = false;
            radioCaNgay.Checked = false;
            txtGiaThue.Text = null;
            txtHoTen.Text = null;
            cbDoUong.SelectedIndex = -1;
            cbSoLuong.SelectedIndex = -1;
            txtTien.Text = null;
            txtHoTen.Focus();
        }
        private void tinhTien()
        {
            if (cbDoUong.SelectedIndex != -1 && cbSoLuong.SelectedIndex != -1)
            {
                if (cbDoUong.SelectedIndex == 0)
                {
                    txtTien.Text = (0.5 * double.Parse(cbSoLuong.Text)).ToString();
                }
                else if (cbDoUong.SelectedIndex == 1)
                {
                    txtTien.Text = (0.8 * double.Parse(cbSoLuong.Text)).ToString();
                }
                else if (cbDoUong.SelectedIndex == 2)
                {
                    txtTien.Text = (1 * double.Parse(cbSoLuong.Text)).ToString();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && (radioCaNgay.Checked == true || radioNuaNgay.Checked == true) &&
                cbDoUong.SelectedIndex != -1 && cbSoLuong.SelectedIndex != -1)
            {
                if (radioCaNgay.Checked == true)
                {
                    listBox1.Items.Add(txtHoTen.Text + " | " + radioCaNgay.Text + " " + txtGiaThue.Text + "$ | "
                        + cbDoUong.Text + " " + txtTien.Text + "$ | " + "Tổng " + (double.Parse(txtTien.Text)
                        + double.Parse(txtGiaThue.Text)).ToString() + "$");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }
    }
}
