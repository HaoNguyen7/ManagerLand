using ManageStore.DTO;
using System.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set => instance = value;
        }

        private CustomerDAO() { }

        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM dbo.KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }
        public List<Customer> SearchCustomerByName(string name)
        {
            List<Customer> list = new List<Customer>();
            string query = string.Format("SELECT * FROM KHACHHANG WHERE dbo.GetUnsignString(TENNV) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }
        public bool InsertCustomer(int id, int idchinhanh, string ten, string sdt, string gioitinh, DateTime? ngaysinh, float luong, string diachi)
        {
            //string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            string query = string.Format("INSERT dbo.NHANVIEN(IDNV,IDCNHANH,TENNV,DIENTHOAINV,GIOITINHNV,NGAYSINHNV,LUONGNV,DIACHINV) VALUES({0},{1},N'{2}',N'{3}',N'{4}',N'{5}',{6},N'{7}')", id, idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCustomer(int id, int idchinhanh, string ten, string sdt, string gioitinh, DateTime? ngaysinh, float luong, string diachi)
        {
            string query = string.Format("UPDATE dbo.NHANVIEN SET IDCNHANH = {0}, TENNV = N'{1}', DIENTHOAINV = N'{2}',GIOITINHNV = N'{3}',NGAYSINHNV= N'{4}', LUONGNV={5},DIACHINV= N'{6}' WHERE IDNV = {7}", idchinhanh, ten, sdt, gioitinh, ngaysinh, luong, diachi, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCustomer(int idCustomer)
        {


            string query = string.Format("Delete NHANVIEN where IDNV = {0}", idCustomer);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
