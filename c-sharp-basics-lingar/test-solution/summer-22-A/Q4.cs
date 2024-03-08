using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution
{
    public class Class1
    {
        /**
         * 
         * בתוך C 
         * יש דריסה
         * ובתוך D
         * יש העמסה של EQUALS
         * בגלל שסוג הפאראמטר שונה. 
         * 
         * */
        public static void Demo()
        {
            B b = new B(1);//{B: num = 1
            C c = new C(1);//{C: num = 1
            D d = new D(1);//{D: num = 2
            B b1 = new D(1);//{D: num =2
            Object c1 = new C(1);//{C: num = 1
            Object d1 = new D(1);//{D: num =2
            Console.WriteLine(b1.Equals(b));//equals D - false - wrong // it will call to object.Equals . False
            Console.WriteLine(c1.Equals(c));//equals C - true
            Console.WriteLine(d1.Equals(d));//equals object - false

            Console.WriteLine(d.Equals((D)d1));//equal D - true
            //(******)
        }
        /*
         * Console.WriteLine(b1.Equals(b));
2) Console.WriteLine (c1.Equals(c));
3) Console.WriteLine (d1.Equals(d));
4) Console.WriteLine (d.Equals((D)d1));
*/

    }

    public class B
    {
        protected int num;
        public B(int num)
        {
            this.num = num;
        }
    } // end of B
    public class C : B
    {
        public C(int num) : base(num)
        {
        }
        public override bool Equals(Object other)
        {

            Console.WriteLine("Equals C");
            return ((other != null) && (other is C) &&
            (num == ((C)other).num));
        }
    } // end of C
    public class D : B
    {
        public D(int num) : base(num + 1)
        {
        }
        public bool Equals(D other)
        {
            Console.WriteLine("Equals D");

            return ((other != null) && (num == other.num));
        }
    } // end of D
}
