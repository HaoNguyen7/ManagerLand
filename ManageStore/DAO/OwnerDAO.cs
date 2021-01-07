using ManageStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DAO
{
    class OwnerDAO
    {
        private static OwnerDAO instance;

        public static OwnerDAO Instance
        {
            get { if (instance == null) instance = new OwnerDAO(); return OwnerDAO.instance; }
            private set => instance = value;
        }

        private OwnerDAO() { }

        public List<Owner> GetListOwner()
        {
            List<Owner> list = new List<Owner>();
            string query = "SELECT * FROM dbo.CHUNHA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Owner Owner = new Owner(item);
                list.Add(Owner);
            }

            return list;
        }
        public List<Owner> SearchOwnerByName(string name)
        {
            List<Owner> list = new List<Owner>();
            string query = string.Format("SELECT * FROM dbo.CHUNHA WHERE dbo.GetUnsignString(TENNV) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Owner Owner = new Owner(item);
                list.Add(Owner);
            }

            return list;
        }
        public bool InsertOwner(int id, int idchinhanh, string ten, string sdt, string gioitinh, DateTime? ngaysinh, float luong, string diachi)
        {
            //string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            string query = string.Format("INSERT dbo.NHANVIEN(IDNV,IDCNHANH,TENNV,DIENTHOAINV,GIOITINHNV,NGAYSINHNV,LUONGNV,DIACHINV) VALUES({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',{6},N'{7}')", id, idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateOwner(int id, int idchinhanh, string ten, string sdt, string gioitinh, DateTime? ngaysinh, float luong, string diachi)
        {
            string query = string.Format("UPDATE dbo.NHANVIEN SET IDCNHANH = {0}, TENNV = N'{1}', DIENTHOAINV = N'{2}',GIOITINHNV = N'{3}',NGAYSINHNV= N'{4}', LUONGNV={5},DIACHINV= N'{6}' WHERE IDNV = {7}", idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteOwner(int idOwner)
        {
            string query = string.Format("Delete CHUNHA where IDCNHA = {0}", idOwner);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
