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
            object[] parameter = {cBoxHousesType.Text, tBoxCost.Text, cBoxPriceType.Text, 
                numericRoom.Value, tBoxStreet.Text, tBoxDistrict.Text,
                tBoxCity.Text, tBoxRegion.Text, tBoxBranchID.Text};

            DataTable data = DataProvider.Instance.ExecuteParameterQuery(query, parameter);
            dtgvCategory.DataSource = data;
        }

        private void tpHouseStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            fSwitchCase switchCase = new fSwitchCase();
            switchCase.ShowDialog();
            if(switchCase.TransactionOwner == "khoaminhi") //Lua chon nguoi viet 2 tinh huong
            {
                if(switchCase.TransactionSituation == "1") //Lua chon 1 trong 2 tinh huong da viet (Lost update)
                {
                    if (textHouseID.Text == "" || numViews.Value == 0) return;
        
                    if (switchCase.Demo == "T2") //Lua chon transaction
                    {
                        string query = "exec sp_updateView_T2  @houseID, @views";
                        object[] parameter = { textHouseID.Text, numViews.Value };

                        DataProvider.Instance.ExecuteParameterNonQuery(query, parameter);

                        string query2 = "exec sp_TimNhaChoKhachHang";

                        DataTable data = DataProvider.Instance.ExecuteQuery(query2);
                        dtgvCategory.DataSource = data;
                    }
                    else if (switchCase.Demo == "T1")
                    {
                        string query = "exec sp_updateView_T1  @houseID, @views";
                        object[] parameter = { textHouseID.Text, numViews.Value };

                        DataProvider.Instance.ExecuteParameterNonQuery(query, parameter);

                        string query2 = "exec sp_TimNhaChoKhachHang";

                        DataTable data = DataProvider.Instance.ExecuteQuery(query2);
                        dtgvCategory.DataSource = data;
                    }
                }

                if(switchCase.TransactionSituation == "2") //Dirty read, đọc views âm
                {
                    

                    if (switchCase.Demo == "T2") //Lua chon transaction
                    {
                        if (textHouseID.Text == "") return;
                        string query = "exec sp_getView  @houseID";
                        object[] parameter = { textHouseID.Text};

                        DataTable data = DataProvider.Instance.ExecuteParameterQuery(query, parameter);
                    
                        dtgvCategory.DataSource = data;
                    }
                    else if (switchCase.Demo == "T1")
                    {
                        if (textHouseID.Text == "" || numViews.Value == 0) return;
                        string query = "exec sp_updateView_2_T1  @houseID, @views";
                        object[] parameter = { textHouseID.Text, numViews.Value };

                        DataProvider.Instance.ExecuteParameterNonQuery(query, parameter);

                        string query2 = "exec sp_TimNhaChoKhachHang";

                        DataTable data = DataProvider.Instance.ExecuteQuery(query2);
                        dtgvCategory.DataSource = data;
                    }
                }
                
            }


            if(switchCase.TransactionOwner == "hao")
            {

            }

            switchCase.Close();
        }
    }
}
