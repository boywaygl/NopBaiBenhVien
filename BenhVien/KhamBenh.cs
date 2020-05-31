using System;
using System.Collections.Generic;
using System.Text;

namespace BenhVien
{
    [Serializable]
    public class KhamBenh
    {
        private string msbn;
        private string msbacsy;
        private DateTime ngaykham;
        private string ghichu;

        public KhamBenh(string msbn, string msbacsy, DateTime ngaykham, string ghichu)
        {
            this.Msbn = msbn;
            this.Msbacsy = msbacsy;
            this.Ngaykham = ngaykham;
            this.Ghichu = ghichu;
        }
        public KhamBenh()
        {

        }

        public string Msbn { get => msbn; set => msbn = value; }
        public string Msbacsy { get => msbacsy; set => msbacsy = value; }
        public DateTime Ngaykham { get => ngaykham; set => ngaykham = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
