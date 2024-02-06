using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.some_test_01
{
    public class PaymentsSystem
    {
        public static void DemoPaymentsSystem()
        {
            Console.WriteLine("DemoPayementsSystem");


            /*
             *  לשלם את כל הסכום באמצעי תשלום אחד: מזומן, המחאה או כרטיס אשראי.
 לשלם 200 ש"ח במזומן ו- 800 ש"ח בכרטיס אשראי בארבעה תשלומים שווים )כל חודש יחויב סכום של 200 ש"ח(.
 לשלם 100 ₪ במזומן, 500 ₪ באמצעות שתי המחאות: הראשונה על סך 200 ₪ והשנייה על סך 300 ₪
ו- 400 ₪ בכרטיס אשראי.
            */
            /*
            Buy buy = new Buy();
            Payment[] payments = new Payment[2];

            Credit c = new Credit();
            c.sum = 10;
            c.serialNumber = "1000";

            payments[0] = c;

            c = new Credit();

            c.sum = 100;
            c.serialNumber = "1000";

            payments[1] = c;

            buy.payments = payments;

            buy.total = 110;

            Console.WriteLine("check() = true " + buy.Check());

            buy.total = 100;

            Console.WriteLine("check() = false " + buy.Check());

            Buy buy2 = new Buy();



            payments = new Payment[1];

            payments[0] = new Cash();
            payments[0].sum = 20;
            buy2.payments = payments;

            Store store = new Store();
            store.buys = new Buy[]{buy, buy2 };
            store.Print("1000");

            Console.WriteLine("store cash count = " + store.CashPayments());


            */


        }
    }

    public class Store
    {
        //הקניות שבוצעות בחנות, ההנחה שלא כולם בוצעו בהצלחה לכן עוקבים גם אחרי הכמות הנכונה
        //buys has no nulls
        private Buy[] buys = new Buy[0];

        //כמות הקניות האמיתית.
        private int buysAmount = 0;


        public void Print(string creditNum)
        {
            for (int i = 0; i < buys.Length; i++)
            {
                //represent if this buy contains is Credit
                bool isCredit = false;
                for (int j = 0; j < buys[i].GetPayments().Length; j++)
                {
                    //for code clearence 
                    Payment pay = buys[i].GetPayments()[j];
                    if (pay is Credit && pay.GetSerialNumber().Equals(creditNum))
                    {
                        isCredit = true; break;
                    }

                }
                if (isCredit)
                {
                    Console.WriteLine(buys[i]);
                }
            }
        }


        public int CashPayments()
        {

            int counter = 0;
            for (int i = 0; i < buys.Length; i++)
            {
                bool isCash = true;
                for (int j = 0; j < buys[i].GetPayments().Length; j++)
                {
                    //for code clearence 
                    Payment pay = buys[i].GetPayments()[j];

                    //Checking that it's cash
                    if (!(pay is  Cash) )
                    {
                        counter++;
                        isCash = false; 
                        break;
                    }

                }
                if (isCash)
                {
                    counter++;
                }
            }
            return counter;
        }


    }



    public class Buy
    {

        //תאריך הקניה, הסכום לתשלום בעבור הקנייה, פירוט שילוב אמצעי התשלום ומספר אמצעי התשלום
        // שבאמצעותם נערכה הקנייה.

        //תאריך הקנייה
        private Date buyDate = null;

        //סכום הקנייה
        private double total = 0;
        //שילוב אמצעי התשלום- מניחים שייתכנו תשלומים שיידחו ולא שולמה הקנייה באמצעותם
        private Payment[] payments = new Payment[0];

        //הכמות הנכונה של מס' האמצעים ששימשו לתשלום הקנייה
        private int paymentsAmount = 0;
        //For testing
        public Payment[] GetPayments() { return payments; }


        public bool Check()
        {
            double sum = 0;
            for (int i = 0; i < payments.Length; i++)
            {
                //assuming that payments has no null 
                sum += payments[i].GetSum();
            }

            return sum == total;
        }

        //for testing
        //public override string ToString()
        //{

        //    return string.Format("buy total  = {0}", total);
        //}

    }

    public class Payment
    {
        //the sum of the payment
        private double sum;



        public double GetSum()
        {

            return sum;
        }


        //the serial number of the payment. Cash will be -1
        private string serialNumber = "-1";

        public string GetSerialNumber() { return serialNumber; }

       
    }

    public class Cash : Payment { }

    public class Cheque : Payment
    {

        //the name of the bank
        private string bankName = "";

        //התאריך הרשום על ההמחאה
        private Date chequeDate = null;


    }

    public class Credit : Payment
    {

        //בעבור תשלום בכרטיס אשראי – הסכום לתשלום, מספר כרטיס האשראי, תוקף הכרטיס והתאריך שבו יחויב

        //expirationDate in format of mm/yy
        private string expirationDate = "";

        //התאריך שבו יחויב
        private Date dueDate = null;

    }


    public class Date { }
}
