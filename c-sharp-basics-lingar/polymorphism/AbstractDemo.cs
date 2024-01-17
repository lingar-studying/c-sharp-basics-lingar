﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.polymorphism
{
    public class AbstractDemo
    {
        public static void demoAbstractClass()
        {
            //U cannot use it directly
            //complie error - "Cannot create an instance of the abstract class or interface 'interface' " 
            //AbstractClass1 a = new AbstractClass1();

        }
    }

    //Combine of interface and sub-class utilities
    public abstract class AbstractClass1
    {
        public int field1, field2;//will be exist on the child too.

        //Compile error - "The modifier 'abstract' is not valid for this item"
        //U cannot implement (=define, write code) abstract method
        //public abstract void method1NotCompile()
        //{

        //}

        //Each child must implement this method
        public abstract void AbstractMethod1();

        public abstract int AbstractMethod2(String s);

        //we can also have the regular types of methods: 
        public virtual double ConcreteVirtualMethod1()
        {
            Console.WriteLine("ConcreteMethod1 - from abstract class");
            return 0;
        }
        public short ConcreteNotVirtualMethod1() { return 9; }

        public byte ConcreteNotVirtualMethod2() {
            //return 9222; //it's too much for byte - compile error
            return 255;//maximum bye
        }

        public short ConcreteNotVirtualMethod3() { return 19; }


    }

    public class AbstractClass1Implementation1 : AbstractClass1
    {
        //U must use "override" key word for override things. 
        public override void AbstractMethod1()
        {

        }

        public override int AbstractMethod2(string s)
        {
            //throw new NotImplementedException();
            return 3;
        }
    }

    public class AbstractImplementationHideThings : AbstractClass1
    {

        //warning about hiding
        public int field1 = 16;

        //with new there is no warning
        new public int field2 = 16;
        //U must use "override" key word for override things. 
        public override void AbstractMethod1()
        {
            Console.WriteLine("AbstractImplementationHideThings.AbstractMethod1()");
        }

        public override int AbstractMethod2(string s)
        {
            //throw new NotImplementedException();
            return 33;
        }
        //we can override the virtual too - if we want. 
        public override double ConcreteVirtualMethod1()
        {

            Console.WriteLine("ConcreteVirtualMethod1 overrided ");
            return 9.33;

        }

        //here we'll hide the method like not should be done 
        public short ConcreteNotVirtualMethod1()
        {

            return 9;
        }

        //use the new : 
        public new short ConcreteNotVirtualMethod2()
        {

            return 19;
        }

        //we cannot override not virtual method 
        //compile error - "'function1' : cannot override inherited member 'function2' because it is not marked "virtual", "abstract", or "override""
        
        //public override short ConcreteNotVirtualMethod3()
        //{

        //    return 19;
        //}
    }

}
//the difference between virtual to abstract
//https://stackoverflow.com/questions/14728761/difference-between-virtual-and-abstract-methods