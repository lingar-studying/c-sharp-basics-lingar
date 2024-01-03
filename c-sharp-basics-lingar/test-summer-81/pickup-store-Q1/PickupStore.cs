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

        public override string ToString()
        {
            return string.Format("Tablet = [name = {0} | kind = {1} | system = {2}\n" +
                "size = {3}| price = {4}]", name, kind, system, size, price);
        }
    }
}

/**
 * המחלקה Tablet המייצגת מחשב הלוח. תכונות המחלקה:
name  – שם חברה המייצרת, מסוג מחרוזת, stringkind  – דגם, מסוג מחרוזת, stringsystem  – מערכת הפעלה מסוג תו, char '( W ' – ווינדוס, ' A ' – אנדרואיד, ' I – ' iOS )
size  – גודל, מסוג מספר ממשי, doubleprice  – מחיר, מסוג מספר ממשי, double
אפשר להניח שבמחלקה הוגדר בנאי ) constructor ( המקבל פרמטרים לכל התכונות, פעולות get/set
ופעולת tostring . אין צורך לממש את הפעולות.
 * 
 * 
 * 
 * 
 * 
 * */
