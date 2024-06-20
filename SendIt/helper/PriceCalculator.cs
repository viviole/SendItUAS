using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendIt.helper
{
    public static class PriceCalculator
    {
        public static int CalculatePrice(int berat, int jarak)
        {
            int hargaDasar = 10000;
            int biayaPerKilometer = 1000;
            int biayaPerKilogram = 500;
            return hargaDasar + (jarak * biayaPerKilometer) + (berat * biayaPerKilogram);
        }

        public static bool IsWeightValid(int berat)
        {
            return berat <= 20;
        }

        public static bool IsDistanceValid(int jarak)
        {
            return jarak <= 7;
        }
    }
}
