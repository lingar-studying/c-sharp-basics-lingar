using System;
using System.Collections.Generic;
using System.Text;
//HOME WORK
namespace c_sharp_basics_lingar.object_basics
{
    public class ExchangeDemoHomeWork
    {

        public static void AddN(Stock stock, int n)
        {
            stock.price = stock.price + n;

        }

        public static void AddN(double d,double  n)
        {
            d += n;
            Console.WriteLine("D in the method = " + d);
        }

        public static void AddN(ref double d, double n)
        {
            d += n;
            Console.WriteLine("D in the method = " + d);
        }
        public static void Demo()
        {
            Stock stock = new Stock("Apple Inc. Common Stock", 190.96 , "AAPL");

            stock.DisplayStock();
            ExchangeDemoHomeWork.AddN(stock, 10);
            double dPrice = 20.5;
            AddN(dPrice, 10);

            stock.DisplayStock();
            Console.WriteLine("dPrice = " + dPrice);

            AddN(ref dPrice, 10);
            Console.WriteLine("dPrice = " + dPrice);
            //AddN(ref 2, 10);



        }
        //TODO - 
        //Do demo method for 3 stocks ( =מנייה)
        //Show start day price, close day price, percent change (=אחוזי שינוי)

        //work on the details of the date: 05/21/2024	
        //those are the details: 
        //https://www.nasdaq.com/market-activity/stocks/aapl/historical
        //https://www.nasdaq.com/market-activity/stocks/tsla/historical
        //https://www.nasdaq.com/market-activity/stocks/coke/historical


        //On each  stock:

        //Do start day (according to the real time above) 
        //Show details
        //Set the price of the stock that was the higher on this day
        //Show details
        //Try to get the percent change and get rejected
        //close the day
        //Show details
        //get the percent change
    }


    public class Stock
    {

        public string officialName = "";
        public double price = 0;
        public string sign = "";

        public Stock(string officialName, double price, string sign)
        {
            this.officialName = officialName;
            this.price = price;
            this.sign = sign;
        }

        public void DisplayStock()
        {
            Console.WriteLine($"Official Name = {officialName}, price = {price}, sign = {sign}");
        }


        //create properties : 
        //Official Name, price, sign (=סמליל) ,starting price , closing price, industry(=תעשייה), exchange (=בורסה)
        // is day active 

        //create methods (פעולות ) 
        //start day - setting the current price and the starting price and day is active
        //finish day - setting the current price and the closing price
        //set price - setting the price
        //Print changes percentage (if the day is still  active it's not return nothing) 
        //Display Price - printing the Sign with the current price. 

    }

   

}
