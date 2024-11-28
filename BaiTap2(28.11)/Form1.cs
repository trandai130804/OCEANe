using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTap2_28._11_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(txtSlot1.Text);
            newitem.SubItems.Add(txtSlot2.Text);
            newitem.SubItems.Add(txtSlot3.Text);
            lv1.Items.Add(newitem);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lv1.SelectedItems[0];

            selectedItem.Text = txtSlot1.Text;           
            selectedItem.SubItems[1].Text = txtSlot2.Text;  
            selectedItem.SubItems[2].Text = txtSlot3.Text; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa mục này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                foreach (ListViewItem item in lv1.SelectedItems)
                {
                    lv1.Items.Remove(item); // Xóa mục được chọn
                }
            }
        }

        private void lv1_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedIndices.Count > 0)
            {
                txtSlot1.Text = lv1.SelectedItems[0].SubItems[0].Text;
                txtSlot2.Text = lv1.SelectedItems[0].SubItems[1].Text;
                txtSlot3.Text = lv1.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
