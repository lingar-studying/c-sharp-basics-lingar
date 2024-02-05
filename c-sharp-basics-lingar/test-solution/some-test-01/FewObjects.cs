using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.some_test_01
{
    internal class FewObjects
    {

        public static void DemoFewObjects()
        {
            MultiOne container = new MultiOne();
            SingleOne s1 = new SingleOne(11, 35);
            container.Add(s1);
            s1 = new SingleOne(47, 22);
            container.Add(s1);
            s1 = new SingleOne(8, 17);
            container.Add(s1);
            MultiOne subContainer = new MultiOne();
            s1 = new SingleOne(53, 40);
            subContainer.Add(s1);
            s1 = new SingleOne(21, 13);
            subContainer.Add(s1);
            s1 = new SingleOne(39, 62);
            subContainer.Add(s1);
            container.Add(subContainer);
            container.Print();
        }
    }
    class Basis
    {
        protected int num1;
        public Basis()
        {
        }
        public Basis(int n)
        {
            this.num1 = n;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.num1);
        }
    }
    class SingleOne : Basis
    {
        protected int num2;
        public SingleOne(int n1, int n2) : base(n1)
        {
            this.num2 = n2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.num2);
        }
    }
    class MultiOne : Basis
    {
        private int count = 0;
        private Basis[] arr;
        public MultiOne()
        {
            this.arr = new Basis[5];
        }
        public override void Print()
        {
            for (int i = 0; i < count; i++)
                arr[i].Print();
        }
        public void Add(Basis b)
        {
            if (count < arr.Length)
            {
                arr[count] = b;
                count++;
            }
        }
    }
}
