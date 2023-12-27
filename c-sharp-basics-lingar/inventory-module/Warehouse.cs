using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Warehouse: Structure
    {
        private bool lightOn = false;

        private string[] keepers;

        public bool LightOn { get { return lightOn; } set { lightOn = value; } }    

        public void addGuards(string guard)
        {
            keepers = new string[] { guard };
        }
        //Method overloading 
        public void addGuards(string[] guards)
        {
            keepers = guards;
        }


        public override void  Clean()
        {
            Dirt = 20;
        }

        public override string ToString()
        {
            string keepersString = "keepers= ";
            for (int i = 0; i < keepers.Length; i++)
            {
                keepersString += keepers[i] + ",";
            }
            return base.ToString() +"| lightOn = "+ lightOn + "|" +keepersString;
        }
    }
}
