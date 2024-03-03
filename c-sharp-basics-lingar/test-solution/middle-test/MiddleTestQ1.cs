﻿using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.middle_test
{
    public class MiddleTestQ1
    {
        public static void Demo()
        {
            SpeedCamera sc1 = new SpeedCamera(02, 06, 100);
            SpeedCamera sc2 = new SpeedCamera(03, 20, 120);
            SpeedCamera sc3 = new SpeedCamera(35, 30, 80);
            sc3.AddCar(2033345, 50);
            sc3.AddCar(1133355, 450);
            sc3.AddCar(5533345, 250);
            sc3.AddCar(9533345, 240);


            SpeedCamera[] tests = { sc1, sc2, sc3 };

            foreach (SpeedCamera test in tests)
            {
                Console.WriteLine(test);
            }
            Console.WriteLine(sc3);

            SpeedCameraNetwork speedCameraNetwor = new SpeedCameraNetwork();

            speedCameraNetwor.AddSpeedCamera(sc3);
            Console.WriteLine("Speed network = " + speedCameraNetwor);

           

        }

    }

    public class SpeedCamera
    {
        //code of the camera 
        private int code = 0;

        private int roadNum = 0;

        private Stack<int> vehicleNums = new Stack<int>();

        public Stack<int> VehicleNums
        {
            get => vehicleNums;
            set => vehicleNums = value;
        }


        private int maxSpeed = 0;

        public SpeedCamera(int code, int roadNum, int maxSpeed)
        {
            this.code = code;
            this.roadNum = roadNum;
            this.maxSpeed = maxSpeed;
        }

        public void AddCar(int carNum, int speed)
        {
            if (speed > maxSpeed)
            {
                vehicleNums.Push(carNum);
            }
        }

        public override string ToString()
        {
            return "[SpeedCamera: code = " + code + ", roadNum=" +roadNum + ",maxSpeed=" + maxSpeed
                +",vehicleNums = "+ string.Join(",",vehicleNums) +  "]";
        }

        //getters and setters come here... 
    }

    public class SpeedCameraNetwork
    {

        // private Stack<SpeedCamera> cameras = new Stack<SpeedCamera>();
        private SpeedCamera[] cameras = new SpeedCamera[0];
        private const int MAX_CAMERAS = 100;

        private int dayDate = 0;

        public override string ToString()
        {
            return "[SpeedCamerNetwork: cameras = " +string.Join<SpeedCamera>(",", cameras) + " ]";
        }
        //constructors and getters come here... 

        public void AddSpeedCamera(SpeedCamera sc)
        {
            if (cameras.Length < MAX_CAMERAS)
            {
                SpeedCamera[] tempCameras = new SpeedCamera[cameras.Length + 1];
                Array.Copy(cameras, tempCameras, cameras.Length);
                tempCameras[cameras.Length + 1] = sc;
                cameras = tempCameras;
            }

        }

        public bool IsCaught(int carNum)
        {
            bool found = false;

            bool firstPrint = true;

            //assume the camera code is less then zero
            int lastCode = -1;

            for (int i = 0; i < cameras.Length; i++)
            {
                //for (int j = 0; j < cameras[i].VehicleNums.Count; i++)
                while(cameras[i].VehicleNums.Count > 0)
                {
                    int currCarNum = cameras[i].VehicleNums.Pop();
                    if(currCarNum == carNum)
                    {
                        if (!found)
                        {
                            found = true;
                        }
                        else
                        {
                            if (firstPrint)
                            {
                                Console.WriteLine(lastCode);
                                firstPrint = false;
                            }
                        }
                        lastCode = currCarNum;
                        Console.WriteLine(lastCode );
                    }
                }
                

                
            }

            return true;
        }

    }
}
