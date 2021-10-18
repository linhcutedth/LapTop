using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapTop.Models
{
    public class Customer
    {
        string maKH;
        string tenDN;
        string tenKH;
        string soDT;
        string email;
        string gTinh;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string GTinh { get => gTinh; set => gTinh = value; }

        public Customer()
        {
        }

        public Customer(string maKH, string tenDN, string tenKH, string soDT, string email, string gTinh)
        {
            this.maKH = maKH;
            this.tenDN = tenDN;
            this.tenKH = tenKH;
            this.soDT = soDT;
            this.email = email;
            this.gTinh = gTinh;
        }
    }
}
