using System;

namespace pervie40
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin1();
            Begin2();
            Begin3();
            Begin4();
            Begin5();
            Begin6();
            Begin7();
            Begin8();
            Begin9();
            Begin10();
            Begin11();
            Begin12();
            Begin13();
            Begin14();
            Begin15();
            Begin16();
            Begin17();
            Begin18();
            Begin19();
            Begin20();
            Begin21();
            Begin22();
            Begin23();
            Begin24();
            Begin25();
            Begin26();
            Begin27();
            Begin28();
            Begin29();
            Begin30();
            Begin31();
            Begin32();
            Begin33();
            Begin34();
            Begin35();
            Begin36();
            Begin37();
            Begin38();
            Begin39();
            Begin40();
        }
        static void Begin1()
        {
            int a=12;
            int p = 4 * a;
            Console.WriteLine(p);
        }
        static void Begin2()
        {
            int a = 17;
            int s = a * a;
            Console.WriteLine(s);
        }
        static void Begin3()
        {
            int a = 19,b=8;
            int s = a * b;
            int p = 2 * (a + b);
            Console.WriteLine(s);
            Console.WriteLine(p);
        }
        static void Begin4()
        {
            int d = 21;
            double l = d * Math.PI;
            Console.WriteLine(l);
        }
        static void Begin5()
        {
            int a = 7, v = a * a * a,s=6*a*a;
            Console.WriteLine(v);
            Console.WriteLine(s);
        }
        static void Begin6()
        {
            int a = 6, b = 19, c = 9,v=a*b*c,s=2*(a*b+a*c+c*b);
            Console.WriteLine(v);
            Console.WriteLine(s);
        }
        static void Begin7()
        {
            int r = 7;
            double s = Math.PI * r, l = Math.PI * 2 * r;
            Console.WriteLine(s);
            Console.WriteLine(l);
        }
        static void Begin8()
        {
            double a = 8, b = 9, s = (a + b) / 2; ;
            Console.WriteLine(s);
        }
        static void Begin9()
        {
            int a = 10;int b = 15;
            double s = Math.Sqrt(a * b);
            Console.WriteLine(s);
        }
        static void Begin10()
        {
            double a = 5, b = 7;
            Console.WriteLine(a*a+b*b);
            Console.WriteLine(Math.Abs(a*a-b*b));
            Console.WriteLine(a * a * b * b);
            Console.WriteLine((a * a) /( b * b));
        }
        static void Begin11()
        {
            double a = 9, b = 16;
            a = Math.Sqrt(a);
            b = Math.Sqrt(b);
            Console.WriteLine(a+b);
            Console.WriteLine(Math.Abs(a - b));
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
        static void Begin12()
        {
            double a = 14, b = 29;
            double c = Math.Sqrt(a * a + b * b);
            double p = a + b + c;
            Console.WriteLine(c);
            Console.WriteLine(p);
        }
        static void Begin13()
        {
            double r1 = 21, r2 = 5;
            double s1 = Math.PI * r1 * r1, s2 = Math.PI * r2 * r2;
            double s3 = s1 - s2;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
        static void Begin14()
        {
            double l = 32;
            double r = l / (2 * Math.PI),s=Math.PI*r*r;
            Console.WriteLine(r);
            Console.WriteLine(s);
        }
        static void Begin15()
        {
            double s = 45;
            double d = 2 * Math.Sqrt(s / Math.PI);
            double l = d * Math.PI;
            Console.WriteLine(d);
            Console.WriteLine(l);
        }
        static void Begin16()
        {
            int a = 4, b = 9;
            Console.WriteLine(Math.Abs(a - b));
        }
        static void Begin17()
        {
            int a = 4, b = 9, c = 5;
            Console.WriteLine(Math.Abs(a-c));
            Console.WriteLine(Math.Abs(b-c));
            Console.WriteLine(Math.Abs(a - c) + Math.Abs(b - c));
        }
        static void Begin18()
        {
            int a = 6, c = 9, b = 16;
            Console.WriteLine(Math.Abs(a - c) * Math.Abs(b - c));
        }
        static void Begin19()
        {
            int x1 = 1, y1 = 3, x2 = 4, y2 = 4;
            Console.WriteLine(2 * (Math.Abs(y1 - y2) + Math.Abs(x1 - x2)));
            Console.WriteLine(Math.Abs(y1-y2)*Math.Abs(x1-x2));
        }
        static void Begin20()
        {
            double x1 = 2, y1 = 2, x2 = 4, y2 = 4;
            Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2)));
        }
        static void Begin21()
        {
            double x1 = 3, x2 = 5, x3 = 9, y1 = 1, y2 = 7, y3 = 2;
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y1 - y3) * (y1 - y3));
            double p = a + b + c;
            double s = Math.Sqrt((p / 2) * ((p / 2) - a) * ((p / 2) - b) * ((p / 2) - c));
            Console.WriteLine(p);
            Console.WriteLine(s);
        }
        static void Begin22()
        {
            int a = 1, b = 2, c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Begin23()
        {
            int a = 1, b = 2, c = 3, d = b;
            b = a;
            a = c;
            c = d;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Begin24()
        {
            int a = 1, b = 2, c = 3, d = a;
            a = b;
            b = c;
            c = d;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Begin25()
        {
            int x = 4;
            Console.WriteLine(3 * x * x * x * x * x * x - 6 * x * x + 2);
        }
        static void Begin26()
        {
            int x = 5;
            int a = (x - 3)*(x-3)*(x-3);
            Console.WriteLine(4*a*a-7*a+2);
        }
        static void Begin27()
        {
            int a = 2, b = a * a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = b * b;
            b = a * a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Begin28()
        {
            int a = 2, b=a*a, c=b*a;
            Console.WriteLine(b);
            Console.WriteLine(c);
            a = c * b;
            b = a * a;
            c = b * a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Begin29()
        {
            double a = 90;
            Console.WriteLine(a * (Math.PI / 180));
        }
        static void Begin30()
        {
            double a = 1.5;
            Console.WriteLine(a * (160 / Math.PI));
        }
        static void Begin31()
        {
            double a=90;
            Console.WriteLine((a-32)*(5/9));
        }
        static void Begin32()
        {
            double a = 30;
            Console.WriteLine(a / (5 / 9) + 32);
        }
        static void Begin33()
        {
            double a = 95;
            int x = 2, y = 3;
            double s = a / x;
            Console.WriteLine(s);
            Console.WriteLine(s * y);
        }
        static void Begin34()
        {
            int x = 3, y = 2;
            double a = 125, b = 65;
            double s1 = a / x, s2 = b / y;
            Console.WriteLine(s1 / s2);
        }
        static void Begin35()
        {

        }
        static void Begin36()
        {

        }
        static void Begin37()
        {

        }
        static void Begin38()
        {

        }
        static void Begin39()
        {

        }
        static void Begin40()
        {

        }
    }
}

