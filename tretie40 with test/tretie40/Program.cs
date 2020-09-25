using System;

namespace Tretie40
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Bool1());
            Console.WriteLine(Bool2());
            Console.WriteLine(Bool4());
            Console.WriteLine(Bool7());
            Console.WriteLine(Bool10());
            Console.WriteLine(Bool11());
            Console.WriteLine(Bool14());
            Console.WriteLine(Bool15());
            Console.WriteLine(Bool16());
            Console.WriteLine(Bool19());
            Console.WriteLine(Bool20());
        }
        public static bool Bool1()
        {
            int a = 13;
            return a > 0;
        }
        static bool Bool2()
        {
            int a = 12;
            return a % 2 > 0;
        }
       static bool Bool4()
        {
            int a = 1, b = 3;
            return a > 2 && b <= 3;
        }
        static bool Bool7()
        {
            int a = 3, b = 2, c = 1;
            return ((a<b)&&(b<c)) || ((a>b)&&(b>c));
        }
        static bool Bool10()
        {
            int a = 11, b = 11;
            return a % 2 > 0 ^ b % 2 > 0;
        }
        static bool Bool11()
        {
            int a = 11, b = 10;
            return Math.Abs(a%2 - b%2)<1;
        }
        public static bool Bool14()
        {
            int a = 1, b = 1, c = -1;
            return a > 0 ^ b > 0 ^ c > 0;
        }
        static bool Bool15()
        {
            int a = 1,b = -1, c =  1;
            return (a > 0 && b > 0) ^ c > 0;
        }
        static bool Bool16()
        {
            int a = 32;
            return a % 2 < 1 && a / 10 > 0;
        }
        static bool Bool19()
        {
            int a = 1, b = 2, c = -1;
            return a == -b || a == -c || c == -b;
        }
        public static bool Bool20()
        {
            int a = 123;
            int a1 = a / 100, a2 = a % 100 / 10, a3 = a % 100;
            return a1 != a2 && a2 != a3 && a3 != a1;
        }
        static bool Bool22()
        {
            int a = 432;
            int a1 = a / 100, a2 = a % 100 / 10, a3 = a % 100;
            return (a1 > a2 && a2 > a3) || (a1 < a2 && a2 < a3);
        }

    }
}
