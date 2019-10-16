﻿using System;

namespace A2_Zahlensysteme
{
    class Zahlensysteme
    {
        static void Main(string[] args)
        {
            int dec = 15;
            int baseNum = ConvertToBaseFromDecimal(7, dec);

            Console.WriteLine("input dec: " + dec);
            Console.WriteLine("dec to hexal: " + baseNum);
            Console.WriteLine("hexal back to hex: " + ConvertToDecimalFromBase(7, baseNum));
        }

        static int ConvertDecimalToHexal(int dec)
        {
            int sixes = dec / 6;
            int rest = dec - (sixes * 6);

            return (sixes * 10) + rest;
        }

        static int ConvertHexalToDecimal(int hexal)
        {
            int sixes = hexal / 10;
            int rest = hexal - (sixes * 10);

            return (sixes * 6) + rest;
        }

        static int ConvertToBaseFromDecimal(int toBase, int dec)
        {
            int bases = dec / toBase;
            int rest = dec - (bases * toBase);

            return (bases * 10) + rest;
        }

        static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int bases = number / 10;
            int rest = number - (bases * 10);

            return (bases * fromBase) + rest;
        }
    }
}
