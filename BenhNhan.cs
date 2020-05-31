using System;
using System.Collections.Generic;
using System.Text;

namespace BenhVien
{
    [Serializable]
    public class BenhNhan
    {
        private string msbn;
        private string socmnd;
        private string hoten;
        private string diachi;

        public BenhNhan(string msbn, string socmnd, string hoten, string diachi)
        {
            this.msbn = msbn;
            this.socmnd = socmnd;
            this.hoten = hoten;
            this.diachi = diachi;
        }
        public BenhNhan()
        {
         
        }

        public string Msbn { get => msbn; set => msbn = value; }
        public string Socmnd { get => socmnd; set => socmnd = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
