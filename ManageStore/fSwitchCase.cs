using ManageStore.DAO;
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
    public partial class fSwitchCase : Form
    {
        public fSwitchCase()
        {
            InitializeComponent();
        }

        private void fSwitchCase_Load(object sender, EventArgs e)
        {

        }

        private void btnDemoDatabase_Click(object sender, EventArgs e)
        {
            DataProvider.ConnectionSTR = @"Data Source=DESKTOP-4ATVFV8\MSSQLSERVER01;Initial Catalog=QLNHADAT_TEST;Integrated Security=True";
        }

        private void btnCompletedDatabase_Click(object sender, EventArgs e)
        {
            DataProvider.ConnectionSTR = @"Data Source=DESKTOP-4ATVFV8\MSSQLSERVER01;Initial Catalog=QLNHADAT;Integrated Security=True";
        }

        public string Demo => comboBox1.Text;
        
        public string Completed => comCompleted.Text;

        public string TransactionOwner => comOwner.Text;

        public string TransactionSituation => comSituation.Text;
    }
}
