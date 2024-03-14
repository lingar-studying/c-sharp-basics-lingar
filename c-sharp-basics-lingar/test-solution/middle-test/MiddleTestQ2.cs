using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.middle_test
{
    public class MiddleTestQ2
    {
        public static void Demo()
        {
            A2[] data = new A2[5];
            data[0] = new A2(5);
            data[1] = new B2(5, 10);
            data[2] = new C(5, 10, 15);
            data[3] = data[0];
            data[4] = new B2(5);
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
            for (int i = 0; i < data.Length; i++)
                data[i].Change();
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
        }
    }
    public class A2
    {
        protected int x;
        public A2()
        {
            this.x = 1;
        }
        public A2(int x)
        {
            this.x = x;
        }
        public virtual void Change()
        {
            this.x = this.x * 2;
        }
        public override string ToString()
        {
            return "X=" + this.x;
        }
    }
    public class B2 : A2
    {
        protected int y;
        public B2(int y)
        {
            this.y = -y;
        }
        public B2(int x, int y) : base(x)
        {
            this.y = -y;
        }
        public override string ToString()
        {
            return base.ToString() + " Y=" + this.y;
        }
    }

    public class C : B2
    {
        private int z;
        public C(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public override void Change()
        {
            this.x = 3 * this.x;
            this.y = 3 * this.y;
            this.z = 3 * this.z;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + this.z;
        }
    }
}
