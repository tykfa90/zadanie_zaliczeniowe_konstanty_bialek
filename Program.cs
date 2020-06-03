using System;
using System.Numerics;

namespace zadanie_zaliczeniowe_konstanty_bialek
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Silnia(4);
        }

        private static BigInteger Silnia(int liczba)
        {
            if (liczba == 0)
                return 1;
            else
                return liczba * Silnia(liczba - 1);
        }
    }
}
