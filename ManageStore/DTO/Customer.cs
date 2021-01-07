using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DTO
{
    class Customer
    {

        public Customer(string idkh, string idcnhanh, string tenkh, string diachi, string sdt, string loainha, string tieuchi)
        {
            this.IdKH = idkh;
            this.idCNhanh = idcnhanh;
            this.TenKH = tenkh;
            this.DiachiKH = diachi;
            this.SdtKH = sdt;
            this.LoaiNha = loainha;
            this.TieuChi = tieuchi;
        }
        public Customer(DataRow row)
        {
            this.IdKH = row["IDKH"].ToString();
            this.IdCNhanh = row["IDCNHANH"].ToString();
            this.TenKH = row["TENKH"].ToString();
            this.DiachiKH = row["DIACHIKH"].ToString();
            this.SdtKH = row["DIENTHOAIKH"].ToString();
            this.LoaiNha = row["LOAINHA"].ToString();
            this.TieuChi = row["TIEUCHINHA"].ToString();
        }

        private string idKH;
        private string idCNhanh;
        private string tenKH;
        private string diachiKH;
        private string sdtKH;
        private string loaiNha;
        private string tieuChi;

        public string IdKH { get => idKH; set => idKH = value; }
        public string IdCNhanh { get => idCNhanh; set => idCNhanh = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiachiKH { get => diachiKH; set => diachiKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
        public string LoaiNha { get => loaiNha; set => loaiNha = value; }
        public string TieuChi { get => tieuChi; set => tieuChi = value; }
    }
}
