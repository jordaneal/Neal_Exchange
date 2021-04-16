using System;

namespace Neal_Exchange
{
    static class Exchanger
    {
        public static decimal USDtoGBP(decimal input)
        {
            return Math.Round(input * 0.72523m, 2);
        }
        public static decimal USDtoCAN(decimal input)
        {
            return Math.Round(input * 1.25427m, 2);
        }
        public static decimal USDtoEUR(decimal input)
        {
            return Math.Round(input * 0.83572m, 2);
        }
        public static decimal GBPtoUSD(decimal input)
        {
            return Math.Round(input * 1.37887m, 2);
        }
        public static decimal GBPtoCAN(decimal input)
        {
            return Math.Round(input * 1.72947m, 2);
        }
        public static decimal GBPtoEUR(decimal input)
        {
            return Math.Round(input * 1.15195m, 2);
        }
        public static decimal CANtoUSD(decimal input)
        {
            return Math.Round(input * 0.79728m, 2);
        }
        public static decimal CANtoGBP(decimal input)
        {
            return Math.Round(input * 0.57848m, 2);
        }
        public static decimal CANtoEUR(decimal input)
        {
            return Math.Round(input * 0.66645m, 2);
        }
        public static decimal EURtoUSD(decimal input)
        {
            return Math.Round(input * 1.19648m, 2);
        }
        public static decimal EURtoGBP(decimal input)
        {
            return Math.Round(input * 0.86826m, 2);
        }
        public static decimal EURtoCAN(decimal input)
        {
            return Math.Round(input * 1.50040m, 2);
        }
    }
}
