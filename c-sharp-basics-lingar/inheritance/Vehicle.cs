using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.inheritance
{
    public class Vehicle
    {
        private int weight;
        private int id;
        private string color;
        private string manufacture;
        private string model;

        protected int maxSpeed; 

        public void SetMaxSpeed(int maxSpeed)
        {
            if(maxSpeed > 40)
            {
                return;
            }
            this.maxSpeed = maxSpeed;
        }


        public Vehicle(int weight, int id, string color, string manufacture, string model)
        {
            this.weight = weight;
            this.id = id;
            this.color = color;
            this.manufacture = manufacture;
            this.model = model;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"weight = {weight}, id = {id}, manufacture = {manufacture}");
        }


    }




    public class Car : Vehicle//, Machine
    {


        private int wheelRadius;// 



        public void SetMaxCarSpeed(int speed)
        {

            //SetMaxSpeed(speed);
            if(speed <= 150)
            {
                this.maxSpeed = speed;

            }

        }

        //constructor 1
        public Car() : base(0, -1, "no color", "NA", "NA")
        {
            this.wheelRadius = 50;
        }

       

        //constructor 2
        public Car(int id, string manufacture, int wheelRadius) : base(0, id, "no color", manufacture, "NA")
        {

            //this.manufacture = "pp";
            //base.manufacture = "kk";
            //weight = 50;
            this.wheelRadius = wheelRadius;
        }

        public void DisplayCarDetails()
        {
            //base.DisplayDetails();
            DisplayDetails();

            Console.WriteLine("wheel radius = " + wheelRadius);
        }
    }


    public class Machine
    {
        private int weight;
        private int id;
        private string color;
        private string manufacture;
        private string model;

        public Machine(int weight, int id, string color, string manufacture, string model)
        {
            this.weight = weight;
            this.id = id;
            this.color = color;
            this.manufacture = manufacture;
            this.model = model;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"weight = {weight}, id = {id}, manufacture = {manufacture}");
        }


    }
}
