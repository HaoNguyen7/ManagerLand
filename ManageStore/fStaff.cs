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
            string query = "exec sp_XemYeuCauKhachHang @idKhachHang, @tenKhachHang, @idChiNhanh";
            object[] parameter = { tBoxStaffID.Text, tBoxStaffName.Text, tBoxBranchName.Text}; //Phai chuyen ve Text moi xu ly duoc Query

            DataTable data = DataProvider.Instance.ExecuteParameterQuery(query, parameter);
            dtgvCustomerRequirments.DataSource = data;
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bTonSearch_Click(object sender, EventArgs e)
        {
            string query = "exec sp_TimNhaChoKhachHang @loaiNha, @gia," +
                " @loaiGia, @soLuongPhong,@duongNha, @quanNha, @tpNha," +
                " @khuVucNha, @idChiNhanh";
            object[] parameter = {lBoxHouseTypes.Text, tBoxCost.Text, 2, 
                numericRoom.Value, tBoxStreet.Text, tBoxDistrict.Text,
                tBoxCity.Text, tBoxRegion.Text, tBoxBranchID.Text};

            DataTable data = DataProvider.Instance.ExecuteParameterQuery(query, parameter);
            dtgvCategory.DataSource = data;
        }
    }
}
