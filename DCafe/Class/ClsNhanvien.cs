using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCafe
{
    public class ClsNhanvien
    {
        public string Ma_Nv{get; set;}
        public string Ten_Nv { get; set; }
        public string Password { get; set; }
        public bool Gioitinh { get; set; }
        public string Ma_Kv { get; set; }
        public bool Is_Admin { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public DateTime Ngayvaolam { get; set; }
        public DateTime Ngaysinh { get; set; }
    }
}
