using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStore
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại hệ thống không hổ trợ tính năng này. Bạn chỉ được sửa yêu cầu của mình!");
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHADATDataSet.LOAINHA' table. You can move, or remove it, as needed.
            this.lOAINHATableAdapter.Fill(this.qLNHADATDataSet.LOAINHA);

        }
    }
}
