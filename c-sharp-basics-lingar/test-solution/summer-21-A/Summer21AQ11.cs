using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.summer_21_A
{
    public class Summer21AQ11
    {
        public static void Demo()
        {
            One x1 = new One(4, 'E');
            One x2 = new One(3);
            Two y1 = new Two(x1);
            One x3 = new Two(5);
            Console.WriteLine("x1 before " + x1);
            x1.Inc();
            Console.WriteLine("x1 after " + x1);
            Console.WriteLine("x2 " + x2);
            Console.WriteLine("y1 " + y1);
            Console.WriteLine("x3 " + x3);
            Two y2 = new Two(y1, 1);
            Console.WriteLine("y2 " + y2);
            One x4 = y2.MakeOne();
            Console.WriteLine("x4 " + x4);
        }
    }

    public class One
    {
        private int num;
        private char ch;
        public One() { num = 2; ch = 'G'; }
        public One(int n) { num = n; ch = 'M'; }
        public One(int n, char c) { num = n; ch = c; }
        public One(One other)
        {
            num = other.num;
            ch = other.ch;
        }
        public int GetNum() { return num; }
        public char GetCh() { return ch; }
        public virtual void Inc() { num++; ch++; }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < num; i++)
                s += ch;
            return s;
        }
    }
    // end of a class One
    public class Two : One
    {
        private One first;
        public Two() : base() { first = new One(); }
        public Two(int n) : base(n) { first = new One(); }
        public Two(One other) : base()
        {
            first = new One(other);
        }
        public Two(One other, int n) : base(other)
        {
            first = new One(n);
        }
        public override void Inc() { first.Inc(); }
        private int What(int n, int m)
        {
            if (n > m) return n;
            return m;
        }
        private char What(char ch1, char ch2)
        {
            if (ch1 < ch2) return ch1;
            return ch2;
        }
        public One MakeOne()
        {
            return
            new One(What(first.GetNum(), GetNum()),
            What(first.GetCh(), GetCh()));
        }
        public override string ToString() { return first.ToString(); }
    }// end of a class Two
    public class Driver
    {
        public static void Main(string[] args)
        {
            One x1 = new One(4, 'E');
            One x2 = new One(3);
            Two y1 = new Two(x1);
            One x3 = new Two(5);
            Console.WriteLine("x1 before " + x1);
            x1.Inc();
            Console.WriteLine("x1 after " + x1);
            Console.WriteLine("x2 " + x2);
            Console.WriteLine("y1 " + y1);
            Console.WriteLine("x3 " + x3);
            Two y2 = new Two(y1, 1);
            Console.WriteLine("y2 " + y2);
            One x4 = y2.MakeOne();
            Console.WriteLine("x4 " + x4);
        }
    }// end of a class Driver
}
