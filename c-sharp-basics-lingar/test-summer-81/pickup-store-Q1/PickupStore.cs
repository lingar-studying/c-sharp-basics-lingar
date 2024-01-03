using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.test_summer_81.pickup_store_Q1
{
    public class Tablet
    {

        private string name = String.Empty;
        private string kind = String.Empty;
        /* W - windows A - android I - ios*/
        private char system;
        private double size ;
        private double price;

        public string Name {  get { return name; } set {  name = value; } }
        public string Kind { get { return kind; } set { kind = value; } }

        public char System { get { return system; } set { system = value; } }

        public double Size { get { return size; } set { size = value; } }   
        public double Price { get { return price; } set { price = value; } }

        public Tablet(string name, string kind, char system, double size, double price)
        {
            Name = name;
            Kind = kind;
            System = system;
            Size = size;
            Price = price;
           
        }

        public bool IsSame(Tablet other)
        {

            //if name, kind, size equals - true
            if (this.name.Equals( other.name) && this.kind.Equals(other.kind) && this.size == other.Size
                
                && this.System == other.System)//I assume it's checking also system... 
                
                return true;

            return false;
        }

       

        public override string ToString()
        {
            return string.Format("Tablet = [name = {0} | kind = {1} | system = {2}\n" +
                "size = {3}| price = {4}]", name, kind, system, size, price);
        }
    }

    public class Store
    {
        private Tablet[] tablets;
        // 0 - W , 1-A, 2-I (W - windows A - android I - ios)

        private int[] systems;
        public Store()
        {
            tablets = new Tablet[4];
            systems = new int[3];
        }

        public bool AddTablet(Tablet tab)
        {
            //bool storageFull = true;
            int freeIndex = -1;
            for(int i = 0; i < tablets.Length; i++)
            {

                //if no more room - return false;
                //null should be on the end so the other condition should be catch before 
                if (tablets[i] == null)
                {
                    //storageFull = false;
                    freeIndex = i;
                    break;
                }
                
                //if exists update to the higher price
                else if (tablets[i].IsSame(tab))
                {
                    tablets[i].Price = Math.Max(tablets[i].Price, tab.Price);
                    return true;
                }
               
                
            }
            //if you reach here this says it's a new item
            if (freeIndex < 0) return false;

            else{
                tablets[freeIndex] = tab;
                switch (tablets[freeIndex].System)
                {
                    case 'W':
                        systems[0]++;
                        break;
                    case 'A':
                        systems[1]++;
                        break;
                    case 'I':
                        systems[2]++;
                        break;

                }
                return true;
            }




        }
        public override string ToString()
        {
            return "Store = [Tablets:\n" + string.Join("| ", (object[]) tablets) 
                + "\nSystems = W - " + systems[0] + " | A - " + systems[1] + " | I = " + systems[2] + "]"; //- the way to print array easily

        }
        //some code come here
    }
}

