using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedIndex == 0)
            {
                txtSoTinChi.Text = "2";
            }
            else if (cbTenMonHoc.SelectedIndex == 1)
            {
                txtSoTinChi.Text = "3";
            }
            else if (cbTenMonHoc.SelectedIndex == 2)
            {
                txtSoTinChi.Text = "3";
            }
            else if (cbTenMonHoc.SelectedIndex == 3)
            {
                txtSoTinChi.Text = "2";
            }
            else if (cbTenMonHoc.SelectedIndex == 4)
            {
                txtSoTinChi.Text = "3";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDiem.Text, out double Diem) && cbTenMonHoc.SelectedIndex != -1
                && txtSoTinChi.Text != null)
            {
                listBox1.Items.Add(cbTenMonHoc.Text + " Số tín chỉ: " + txtSoTinChi.Text + " Điểm: " + Diem);
            }
            else
            {
                MessageBox.Show("Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            
        }
    }
}