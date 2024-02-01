using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace c_sharp_basics_lingar.test_solution
{
    public class SubjectsSystem
    {
        public static void TestSubjectSystem()
        {
            Subject algorithmicA = new Subject(3, 8, 70);
            Subject algorithmicB = new Subject(3, 9, 75);
            Subject oop = new Subject(4, 4, 60);

            Console.WriteLine(algorithmicA.GetPoints(3, 75));//0
            Console.WriteLine(algorithmicA.GetPoints(4, 75));//3
            Console.WriteLine(algorithmicA.GetPoints(7, 75));//3
            Console.WriteLine(algorithmicA.GetPoints(7, 65));//0
            Console.WriteLine(oop.GetPoints(7, 65));//4



            algorithmicB.GetPoints(4, 90);//0

            algorithmicA.SetActualGrade(80);
            algorithmicA.SetHandedAssignments(5);
            oop.SetHandedAssignments(5);
            oop.SetActualGrade(65);

            Result(new Subject[] { algorithmicA, oop });//7

        }

        public static void Result(Subject[] subjects)
        {
            int sum = 0;
            for(int i=0; i<subjects.Length; i++)
            {
                sum += subjects[i].GetPoints(subjects[0].GetHandedAssingments(), subjects[0].GetActualGrade());
            }
            Console.WriteLine("Result = " + sum);
        }


    }

    public class Subject
    {
        private int creditPoints;
        private int assignments;
        private int passingGrade;


        private int handedAssignments;
        private int actualGrade;


        public int GetCreditPoints() { return creditPoints; }

        public int GetAssignments() { return assignments; }

        public int GetPassingGrade() { return passingGrade; }

        public int GetHandedAssingments()
        {
            return handedAssignments;
        }

        public int GetActualGrade()
        {
            return actualGrade;
        }

        public void SetHandedAssignments(int handedAssignments)
        {
            this.handedAssignments = handedAssignments;
        }

        public void SetActualGrade(int actualGrade)
        {
            this.actualGrade = actualGrade;
        }

        public Subject(int creditPoints, int assignments, int passingGrade)
        {
            this.creditPoints = creditPoints;
            this.assignments = assignments;
            this.passingGrade = passingGrade;
        }

        //success condition - half of assignments + passing grade
        public int GetPoints(int numOfWorks, int grade)
        {
            int requestedAssignments = assignments % 2 == 0 ? assignments / 2 : assignments / 2 + 1;

            if (numOfWorks >= requestedAssignments && grade >= passingGrade)
            {
                return creditPoints;
            }
            return 0;
        }
    }
}
