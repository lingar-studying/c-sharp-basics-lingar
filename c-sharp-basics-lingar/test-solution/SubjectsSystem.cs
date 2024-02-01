using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution
{
    public class SubjectsSystem
    {
    }

    public class Subject
    {
        private int creditPoints;
        private int assignments;
        private int passingGrade;

        public int GetCreditPoints() { return creditPoints; }

        public int GetAssignments() { return assignments; }

        public int GetPassingGrade() { return passingGrade; }

        public Subject(int creditPoints, int assignments, int passingGrade)
        {
            this.creditPoints = creditPoints;
            this.assignments = assignments;
            this.passingGrade = passingGrade;
        }
    }
}
