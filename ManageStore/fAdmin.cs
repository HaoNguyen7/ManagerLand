using ManageStore.DAO;
using ManageStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStore
{
    public partial class fAdmin : Form
    {
        BindingSource staffList = new BindingSource();
        BindingSource accountList = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            
            InitializeComponent();
            Load();
            
        }
        void Load()
        {
            dtgvStaff.DataSource = staffList;
            dtgvAccount.DataSource = accountList;   
            LoadListStaff();
            LoadAccount();
        }
        #region methods
        void AddAccount(string userName,  int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName,  type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName,  int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName,  type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        List<Staff> SearchStaffByName(string name)
        {
            List<Staff> listFood = StaffDAO.Instance.SearchStaffByName(name);

            return listFood;
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
      
      
        
        void LoadListStaff()
        {
            staffList.DataSource = StaffDAO.Instance.GetListStaff();
        }
        private void btnDisplayStaff_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }
        #endregion

        #region events
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, type);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
       
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;

            DeleteAccount(userName);
        }
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;

            ResetPass(userName);
        }




        private event EventHandler insertStaff;
        public event EventHandler InsertStaff
        {
            add { insertStaff += value; }
            remove { insertStaff -= value; }
        }

        private event EventHandler deleteStaff;
        public event EventHandler DeleteStaff
        {
            add { deleteStaff += value; }
            remove { deleteStaff -= value; }
        }

        private event EventHandler updateStaff;
        public event EventHandler UpdateStaff
        {
            add { updateStaff += value; }
            remove { updateStaff -= value; }
        }


        #endregion

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            int id = (int)Convert.ToInt32(tbStaffID.Text);
            int idcnhanh = (int)Convert.ToInt32(tbIDchinhanh.Text);
            string name = tbStaffName.Text;
            string sdt = tbSDT.Text;
            string gioitinh = tbGender.Text;
            DateTime? ngaysinh = dTPBirth.Value;
            float luong = (float)Convert.ToDouble(tbSalary.Text);
            string diachi = tbAddr.Text;


            if (StaffDAO.Instance.InsertStaff(id, idcnhanh, name, sdt, gioitinh, ngaysinh, luong, diachi))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadListStaff();
                if (insertStaff != null)
                    insertStaff(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbStaffID.Text);

            if (StaffDAO.Instance.DeleteStaff(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListStaff();
                if (deleteStaff != null)
                    deleteStaff(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhân viên");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            int id = (int)Convert.ToInt32(tbStaffID.Text);
            int idcnhanh = (int)Convert.ToInt32(tbIDchinhanh.Text);
            string name = tbStaffName.Text;
            string sdt = tbSDT.Text;
            string gioitinh = tbGender.Text;
            DateTime? ngaysinh = dTPBirth.Value;
            float luong = (float)Convert.ToDouble(tbSalary.Text);
            string diachi = tbAddr.Text;

            if (StaffDAO.Instance.UpdateStaff(id, idcnhanh, name, sdt, gioitinh, ngaysinh, luong, diachi))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                LoadListStaff();
                if (updateStaff != null)
                    updateStaff(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên");
            }
        }

        private void btnDisplayStaff_Click_1(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            staffList.DataSource = SearchStaffByName(tbSearchStaffName.Text);
        }

        
    }
}
