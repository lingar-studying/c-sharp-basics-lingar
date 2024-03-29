﻿using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.some_test_01
{
    public class RadioAds
    {
    }
    public class Advert
    {
        private int length;//seconds
        private string product;
        private string company;
        private double price;

        public int GetLength() { return length; }
        public double GetPrice() { return price; }

    }


    public class AdvertHour
    {

        // הפרסומות בשעת שידור
        //ההנחה שהמערך כולל את כל הפרסומות ששודרו ללא ריקים
        private Advert[] adverts = new Advert[0];

        public Advert[] GetAdverts() { return adverts; }    

        //שעת השידור הספציפית בין 0 ל-23, ברירת מחדל -1
        private int currentHour = -1;

        //סכום השניות הכולל שניתן לפרסם - סופי
        public const int TOTAL_SECONDS = 5 * 60;

        //non-args constructor
        public AdvertHour() { }
        //All args constructor
        public AdvertHour(Advert[] adverts, int currentHour)
        {
            this.adverts = adverts;
            this.currentHour = currentHour;
        }

        //naorcohen13@gmail.com
        //yimprogramming@gmail.com

        //מקבל את הזמן החופשי שאפשר עדיין לפרסם
        public int FreeTime()
        {
            int seconds = 0;

            for (int i = 0; i < adverts.Length; i++)
            {
                //מניחים שאין null
                seconds += adverts[i].GetLength();


            }
            return TOTAL_SECONDS - seconds;

        }

        public bool IsPossible(Advert advert)
        {
            //Checking if there are less then 15 ads 
            //and there is enough time
            if (adverts.Length < 15 &&
                FreeTime() >= advert.GetLength()
                )
            {
                return true;
            }
            return false;
        }

        public void AddAdvert(Advert advert)
        {
            //if possible - add the advert to the Hour
            if (IsPossible(advert))
            {

                //creating a new array for the new value
                Advert[] temp = new Advert[adverts.Length+1];

                for(int i = 0; i < adverts.Length; i++)
                {
                    temp[i] = advert;
                }

                temp[temp.Length - 1] = advert;

                this.adverts = temp;
            }

        }







    }

    public class ManageDay
    {
        //the adverts of this day (one advert can be passed to many hours ) 
        private Advert[] adverts = new Advert[0];


        //the adverts hours of this day 
        //Assuning no null
        private AdvertHour[] advertHours = new AdvertHour[0];

        public double BenefitDay()
        {

            double sum = 0;
            for(int i =0; i < advertHours.Length; i++)
            {

                for(int j =0; j < advertHours[i].GetAdverts().Length; j++)
                {
                    sum += advertHours[i].GetAdverts()[j].GetPrice();

                }
            }

            return sum;
        }
    }

}
