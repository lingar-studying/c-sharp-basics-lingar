using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.inheritance
{
    public class PersonBase
    {
        protected int strengh;
        private string name;

        public int GetStrengh()
        {
            return strengh;
        }


        public PersonBase(string name)
        {
            this.name = name;
        }

        public virtual void MaximumStrengh()
        {
            this.strengh = 40;
        }

        public override string ToString()
        {
            return $"Person, Strengh = {strengh}, name = {name}";
        }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
        public void Walk(int meters)
        {
            Console.WriteLine("Walking " + meters  + " meters");
        }

        public string Walk(int meters, double cm)
        {
            return "Walking " + meters + " meters" + cm + "cm";
        }


        //public char Walk(int meters, double cm) { return 'a'; }
        public virtual void OverrideMe()
        {

        }


    }

    public class Hero : PersonBase
    {
        private string specialization;
        public Hero(string name, string specialization) : base(name)
        {
            this.specialization = specialization;
        }
        public override void MaximumStrengh()
        {
            this.strengh = 100;
        }
        public override string ToString()
        {
            return base.ToString() + $", specialization = {specialization}";
        }

        public void DoHero() { }


        /*public override string OverrideMe()//won't working*/

        public override void OverrideMe()
        {
            
        }

        public string Walk(int meters, double cm, char c)
        {
            this.Walk(30);
            return "Walking " + meters + " meters" + cm + "cm";
        }

    }

    public class SuperHero : Hero
    {
        public SuperHero(string name, string specialization) : base(name, specialization)
        {

        }
        public new void MaximumStrengh()
        {
            this.strengh = 1000;
        }

    }

    public class Kid : PersonBase
    {
        private bool inGarden;
        public Kid(string name, bool inGarden) : base(name)
        {
            this.inGarden = inGarden;
        }

        public override void MaximumStrengh()
        {
            if (inGarden)
            {
                this.strengh = 10;
            }
            else
            {
                this.strengh = 20;
            }
        }
    }

    public class Ball
    {
        public string color = "red";

        public override string ToString()
        {
            //return base.ToString() + " some ball in color " + color;
            return " some ball in color " + color;

        }
        public bool Equals(object obj)
        {
            //if(obj.color.Equals())
            return base.Equals(obj);
        }
    }




}
