using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageStore.DAO;


namespace ManageStore
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

        private void btnDisplayStaff_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            string query = "exec sp_TimNhaChoKhachHang";
            //object[] parameter = {}
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dtgvCategory.DataSource = data;
        }

        private void dtgvCustomerRequirments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisplayStaff_Click(object sender, EventArgs e)
        {
            string query = "exec sp_XemYeuCauKhachHang";
            //object[] parameter = {}
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dtgvCustomerRequirments.DataSource = data;
        }
    }
}
