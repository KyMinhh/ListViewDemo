using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tạo một list view item - 1 dòng data
            ListViewItem lvi = new ListViewItem(txtLastName.Text);
            //Thêm các cột còn lại
            lvi.SubItems.Add(txtFirstName.Text);
            lvi.SubItems.Add(txtPhone.Text);

            //Đưa dòng này tên listview
            lviSinhVien.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lviSinhVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    lviSinhVien.Items.Remove(lviSinhVien.SelectedItems[0]);
                }
            }
            else
                MessageBox.Show("Xóa không thành công");

        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            if (lviSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lviSinhVien.SelectedItems[0];

                selectedItem.Text = txtLastName.Text; 
                selectedItem.SubItems[1].Text = txtFirstName.Text; 
                selectedItem.SubItems[2].Text = txtPhone.Text; 

                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để cập nhật.");
            }
        }

        private void lviSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (lviSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lviSinhVien.SelectedItems[0];

                txtLastName.Text = selectedItem.Text; 
                txtFirstName.Text = selectedItem.SubItems[1].Text; 
                txtPhone.Text = selectedItem.SubItems[2].Text; 
            }
        }
    }
}
