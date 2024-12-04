using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhAn
    {
        private string id;
        private string maBenhNhan;
        private string ketQua;

        public ET_BenhAn()
        {
        }

        public ET_BenhAn(string id, string maBenhNhan, string ketQua)
        {
            this.id = id;
            this.maBenhNhan = maBenhNhan;
            this.ketQua = ketQua;
        }

        public string Id { get => id; set => id = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string KetQua { get => ketQua; set => ketQua = value; }
    }
}
