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
        }
    }

    public class Store
    {
        //הקניות שבוצעות בחנות, ההנחה שלא כולם בוצעו בהצלחה לכן עוקבים גם אחרי הכמות הנכונה
        private Buy[] buys = new Buy[0];

        //כמות הקניות האמיתית.
        private int buysAmount = 0;
    
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
    }

    public class Cash : Payment   {    }
    
    public class Cheque : Payment {

        //the name of the bank
        private string bankName = "";

        //התאריך הרשום על ההמחאה
        private Date chequeDate = null;


    }

    public class Credit : Payment {

        //בעבור תשלום בכרטיס אשראי – הסכום לתשלום, מספר כרטיס האשראי, תוקף הכרטיס והתאריך שבו יחויב

        //expirationDate in format of mm/yy
        private string expirationDate = "";

        //התאריך שבו יחויב
        private Date dueDate = null;

    }


    public class Date { }
}
