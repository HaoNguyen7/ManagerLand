using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DTO
{
    class House
    {

        public House(int idnha, int idcnha, int idcnhanh, int idnv, int idloai, int soluong, DateTime? ngaydang, DateTime? ngayhethan, string tinhtrang, int luotxem, string duong, string quan, string tp, string khuvuc)
        {
            this.IDNha = idnha;
            this.IDCNha = idcnha;
            this.IDCNhanh = idcnhanh;
            this.IDNV = idnv;
            this.IDLoai = idloai;
            this.SoLuong = soluong;
            this.NgayDang = ngaydang;
            this.NgayHetHan = ngayhethan;
            this.TinhTrang = tinhtrang;
            this.LuotXem = luotxem;
            this.Duong = duong;
            this.Quan = quan;
            this.TP = tp;
            this.KhuVuc = khuvuc;
        }
        public House(DataRow row)
        {
            this.IDNha = (int)Convert.ToInt32(row["IDNHA"]);
            this.IDCNha = (int)Convert.ToInt32(row["IDCNHA"]);
            this.IDCNhanh = (int)Convert.ToInt32(row["IDCNHANH"]);
            this.IDNV = (int)Convert.ToInt32(row["IDNV"]);
            this.iDLoai = (int)Convert.ToInt32(row["IDLOAINHA"]);
            this.SoLuong = (int)Convert.ToInt32(row["SOLUONGNHA"]);
            this.NgayDang = (DateTime?)row["NGAYDANG"];
            this.NgayHetHan = (DateTime?)row["NGAYHETHANG"];
            this.TinhTrang = row["TINHTRANG"].ToString();
            this.LuotXem = (int)Convert.ToInt32(row["LUOTXEM"]);
            this.Duong = row["DUONGNHA"].ToString();
            this.Quan= row["QUANNHA"].ToString();
            this.TP= row["TPNHA"].ToString();
            this.KhuVuc= row["KHUVUCNHA"].ToString();
        }
        private int iDNha;
        private int iDCNha;
        private int iDCNhanh;
        private int iDNV;
        private int iDLoai;
        private int soLuong;
        private DateTime? ngayDang;
        private DateTime? ngayHetHan;
        private string tinhTrang;
        private int luotXem;
        private string duong;
        private string quan;
        private string tP;
        private string khuVuc;


        public int IDNha { get => iDNha; set => iDNha = value; }
        public int IDCNha { get => iDCNha; set => iDCNha = value; }
        public int IDCNhanh { get => iDCNhanh; set => iDCNhanh = value; }
        public int IDNV { get => iDNV; set => iDNV = value; }
        public int IDLoai { get => iDLoai; set => iDLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime? NgayDang { get => ngayDang; set => ngayDang = value; }
        public DateTime? NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int LuotXem { get => luotXem; set => luotXem = value; }
        public string Duong { get => duong; set => duong = value; }
        public string Quan { get => quan; set => quan = value; }
        public string TP { get => tP; set => tP = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
    }
}
