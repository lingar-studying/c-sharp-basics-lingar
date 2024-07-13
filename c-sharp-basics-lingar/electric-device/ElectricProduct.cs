using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class ElectricProduct
    {
        private string name;
        protected double watt;
        private int height;
        private int width;
        public double weight;
        public static int serialNum;


        public ElectricProduct() { }
        public ElectricProduct(string name, double watt, int height, int width, double weight)
        {
            this.name = name;
            this.watt = watt;
            this.height = height;
            this.width = width;
            this.weight = weight;
        }
        public void SetWatt(int watt)
        {
            if(watt>150)
            {
                return;
            }
            this.watt=watt;
        }
        public void DisplayD()
        {
            Console.WriteLine($"name is {name}, watt is {watt}, height is {height}, width is {width},weight is {weight}  ");
        }
    }
}
