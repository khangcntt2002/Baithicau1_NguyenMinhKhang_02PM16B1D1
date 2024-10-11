using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithicau1_NguyenMinhKhang_02PM16B1D1
{
    internal class Car
    {
        string hangxe;
        string bienso;
        string namsanxuat;
        double giaban;

        public string Hangxe { get => hangxe; set => hangxe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Namsanxuat { get => namsanxuat; set => namsanxuat = value; }
        public double Giaban { get => giaban; set => giaban = value; }

        public Car() { }

        public Car(string hangxe, string bienso, string namsanxuat, double giaban)
        {

            this.hangxe = hangxe;
            this.bienso = bienso;
            this.namsanxuat = namsanxuat;
            this.giaban = giaban;
        }
    }
}
