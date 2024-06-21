using System;
using System.Collections.Generic;
using System.Text;
//HOME WORK
namespace c_sharp_basics_lingar.object_basics
{

    public class StockHolders
    {

        public static int staticInt = 9;
        private string name = "";
        private Stock stock = null;
        private const int YEAR = 2020;

        private readonly int YEAR2;// = 2020;


        private int amount;//כמות המניות

        private double balance = 100_000.00; //כמות כסף


        //public void SetYear(int year2)
        //{
        //    year = year2;
        //}


        public void GetStatic()
        {
            Console.WriteLine("static field = " + staticInt);
        }

        public void SetStatic(int x)
        {

            staticInt = x;
            //Console.WriteLine("static field = " + staticInt);
        }
        public StockHolders(string name, Stock stock)
        {
            this.name = name;
            this.stock = stock;
            YEAR2 = 2024;
            //year = 2020;
        }

        public string GetName()
        {

            //YEAR2 = 320;
            return name;
        }

        public Stock GetStock()
        {
            return this.stock;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetStock(Stock stock)
        {
            this.stock = stock;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{name} has {amount} of {stock.sign}, balance = {balance}");
        }

        public void BuyStocks(int amount)
        {
            //check if there is enough money
            if(amount * stock.price > balance)
            {
                Console.WriteLine("You don't have enough money");
                return;
            }

            //multiple price * amount - and substract from the balance
            balance -= (stock.price * amount);

            // add the amount to the balance
            this.amount += amount;
        }


        public void SellAll()
        {
            //Price * amount - add to the balance 
            balance += (stock.price * this.amount);

            //Reset amount // לאפס כמות
            this.amount = 0;

        }
    }

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

            int x = 10;

            int y = x;

            x = 20;

            Console.WriteLine("y = " + y);
            stock.DisplayStock();//296
            Stock stock2 = stock;

            stock.price = 360;

            stock2.DisplayStock();

            Console.WriteLine(stock2.Equals(stock));
            StockHolders holder1 = new StockHolders("Avi", stock);
            Stock coke = new Stock("coke cola", 20.05, "COKE");
            StockHolders holder2 = new StockHolders("Moshe", coke);

            holder2.DisplayDetails();

            holder2.BuyStocks(7000);

            holder2.DisplayDetails();

            holder2.BuyStocks(100);

            holder2.DisplayDetails();

            coke.price = 25;

            holder2.SellAll();
            holder2.DisplayDetails();

            holder1.GetStatic();
            holder2.SetStatic(100);
            holder1.GetStatic();


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
