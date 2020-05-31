using System;

namespace BenhVien
{
    [Serializable]
    public class BacSy
    {
        private string msbacsy;
        private string hotenbacsy;

        public BacSy(string msbacsy, string hotenbacsy)
        {
            this.Msbacsy = msbacsy;
            this.Hotenbacsy = hotenbacsy;
        }
        public BacSy()
        {
      
        }

        public string Msbacsy { get => msbacsy; set => msbacsy = value; }
        public string Hotenbacsy { get => hotenbacsy; set => hotenbacsy = value; }
    }
}
