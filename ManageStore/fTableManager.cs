using ManageStore.DAO;
using ManageStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;


namespace ManageStore
{
    public partial class fTableManager : Form
    {
      
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; ChangeAccount(loginAccount.Type); } }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            nhânViênToolStripMenuItem.Enabled = type == 2;
            chuNhaToolStripMenuItem.Enabled = type == 3;
            thôngTinCáNhânToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
       

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            f.ShowDialog();
        }

        private void chuNhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fOwner f = new fOwner();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fCustomer f = new fCustomer();
            f.ShowDialog();
        }
    }
}
