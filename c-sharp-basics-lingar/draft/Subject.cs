using System;
using System.Collections.Generic;
using System.Text;

namespace College
{
    class Subject
    {
        private int task;
        private int passesGr;
        private int credits;

        public Subject(int Task, int PassesGr, int Credits)
        {
            this.task = Task;
            this.passesGr = PassesGr;
            this.credits = Credits;
        }

        public int getPoints(int numOfWorks,int grade) 
        {
            if((numOfWorks==task)&&(grade>=passesGr))

                   return credits;
            else
                   return 0;
        }
    }
}
