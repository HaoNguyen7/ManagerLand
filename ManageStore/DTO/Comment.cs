using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DTO
{
    class Comment
    {
        public Comment(int stt,string idnha,DateTime? ngaynx,string nx)
        {
            this.Stt = stt;
            this.IDNha = idnha;
            this.NgayNX = ngaynx;
            this.NhanXet = nx;
        }
        public Comment (DataRow row)
        {
            this.Stt = (int)Convert.ToInt32(row["STT"]);
            this.IDNha = row["IDNHA"].ToString();
            this.NgayNX = (DateTime?)row["NGAYNX"];
            this.NhanXet = row["NHANXET"].ToString();
            
        }
        private int stt;
        private string iDNha;
        private DateTime? ngayNX;
        private string nhanXet;

        public int Stt { get => stt; set => stt = value; }
        public string IDNha { get => iDNha; set => iDNha = value; }
        public DateTime? NgayNX { get => ngayNX; set => ngayNX = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
    }
}
