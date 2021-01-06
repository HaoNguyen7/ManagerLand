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
    public partial class fOwner : Form
    {
        BindingSource houseList = new BindingSource();

        public fOwner()
        {
            InitializeComponent();
            Load();

        }
        void Load()
        {
            dtgvHouse.DataSource = houseList;
            
            
            LoadListHouse();
        }
        void LoadListHouse()
        {
            houseList.DataSource = HouseDAO.Instance.GetListHouse();
        }
    }
}
