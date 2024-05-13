using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.polymorphism
{
    public class SomeInterfaceExamples
    {
    }

    public interface Interface1
    {
        public void Do1();
    }

    public class Parent11 {
        
        public void Do1()
        {

        }
    }


    //See here how we are implementing interface by parent. 
    public class Child11 : Parent11, Interface1
    {

    }
}
