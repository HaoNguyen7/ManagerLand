using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.DTO
{
    class Owner
    {
        public Owner(string idcnha,string tencnha,string diachi,string dtcnha)
        {
            this.IDCNHA = idcnha;
            this.TenCNHA = tencnha;
            this.DiaChiCNHA = diachi;
            this.DtCNHA = dtcnha;
        }
        public Owner(DataRow row)
        {
            this.IDCNHA = row["IDCNHA"].ToString();
            this.TenCNHA = row["TENCNHA"].ToString();
            this.DiaChiCNHA = row["DIACHICNHA"].ToString();
            this.DtCNHA = row["_DTCNHA_"].ToString();
        }
        private string iDCNHA;
        private string tenCNHA;
        private string diaChiCNHA;
        private string dtCNHA;

        public string IDCNHA { get => iDCNHA; set => iDCNHA = value; }
        public string TenCNHA { get => tenCNHA; set => tenCNHA = value; }
        public string DiaChiCNHA { get => diaChiCNHA; set => diaChiCNHA = value; }
        public string DtCNHA { get => dtCNHA; set => dtCNHA = value; }
    }
}
