using ManageStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set => instance = value;
        }

        private StaffDAO() { }

        public List<Staff> GetListStaff()
        {
            List<Staff> list = new List<Staff>();
            string query = "SELECT * FROM dbo.NHANVIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }

            return list;
        }
        public List<Staff> SearchStaffByName(string name)
        {
            List<Staff> list = new List<Staff>();
            string query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE dbo.GetUnsignString(TENNV) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }

            return list;
        }
        public bool InsertStaff(int id,int idchinhanh,string ten, string sdt,string gioitinh,DateTime? ngaysinh,float luong,string diachi)
        {
            //string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            string query = string.Format("INSERT dbo.NHANVIEN(IDNV,IDCNHANH,TENNV,DIENTHOAINV,GIOITINHNV,NGAYSINHNV,LUONGNV,DIACHINV) VALUES({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',{6},N'{7}')", id, idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateStaff(int id, int idchinhanh, string ten, string sdt, string gioitinh, DateTime? ngaysinh, float luong, string diachi)
        {
            string query = string.Format("UPDATE dbo.NHANVIEN SET IDCNHANH = {0}, TENNV = N'{1}', DIENTHOAINV = N'{2}',GIOITINHNV = N'{3}',NGAYSINHNV= N'{4}', LUONGNV={5},DIACHINV= N'{6}' WHERE IDNV = {7}", idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteStaff(int idstaff)
        {
            

            string query = string.Format("Delete NHANVIEN where IDNV = {0}", idstaff);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
