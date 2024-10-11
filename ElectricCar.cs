using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithicau1_NguyenMinhKhang_02PM16B1D1
{
    internal class ElectricCar : Car
    {
        string BatteryCapacity;

        public string BatteryCapacity1 { get => BatteryCapacity; set => BatteryCapacity = value; }

        public ElectricCar() { }

        public ElectricCar(string hangxe, string bienso, string namsanxuat, double giaban, string BatteryCapacity)
            : base(hangxe, bienso, namsanxuat, giaban)
        {
            this.BatteryCapacity = BatteryCapacity;
        }

    }
}
