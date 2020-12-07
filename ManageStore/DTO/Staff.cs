using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DTO
{
    class Staff
    {
        public Staff(int id,int idchinhanh,string name,string sdt,string gender,DateTime? dateofbirth,float salary,string addr)
        {
            this.ID = id;
            this.IDchinhanh = idchinhanh;
            this.Name = name;
            this.Sdt = sdt;
            this.Gender = gender;
            this.Dateofbirth = dateofbirth;
            this.Sal = salary;
            this.Address = addr;
        }
        public Staff(DataRow row)
        {
            this.ID = (int)Convert.ToInt32(row["idnv"]);
            this.IDchinhanh = (int)Convert.ToInt32(row["idcnhanh"]);
            this.Name = row["TENNV"].ToString();
            this.Sdt = row["DIENTHOAINV"].ToString();
            this.Gender = row["GIOITINHNV"].ToString();
            this.Dateofbirth = (DateTime?)row["NGAYSINHNV"];
            this.Sal = (float)Convert.ToDouble(row["LUONGNV"].ToString());
            this.Address = row["DIACHINV"].ToString();
        }

        private int iD;
        private string name;
        private int iDchinhanh;
        private string sdt;
        private string gender;
        private DateTime? dateofbirth;
        private float sal;
        private string address;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDchinhanh { get => iDchinhanh; set => iDchinhanh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime? Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public float Sal { get => sal; set => sal = value; }
        public string Address { get => address; set => address = value; }
    }
}
