using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures
{
    public class SomeDataStructuresProblems
    {

        public static void Demo()
        {
            char[] palindrom3 = {
                'e','c','f','g',
                'g','f','c','e',
                'e','c','f','g'};

            char[] notPalindrom = { 'a', 'b', 'c', 'd'
                    , 'f', 'g', 'g', 'f', 'd' };
            char[] palindrom4 = {
                'a','b','c','d',
                'd','c','b','a',
                'a','b','c','d'};

            Console.WriteLine("true? " + IsThreePali(new Stack<char>(palindrom3)));
            Console.WriteLine("false? " + IsThreePali(new Stack<char>(notPalindrom)));
            Console.WriteLine("true? " + IsThreePali(new Stack<char>(palindrom4)));

            int[] q1Not = { 5, -9, 600, 0, 77 };
            int[] q1Yes = { 5, -9, 6, 0, 10 };
            Console.WriteLine("false = " + PosOrder(q1Not));
            Console.WriteLine("true = " + PosOrder(q1Yes));

            int[] q2 = { 6, 8, 12, 14, 16, 18 };//10 (interval 2)

            int[] q2_2 = {500,505,510,515,525,530,535  };//520 (interval 5)

            Console.WriteLine("10 ?  - " + MissingNum(q2) );

            Console.WriteLine("520 ?  - " +  MissingNum(q2_2));


            LinkedList<int> q3LinkedList = new LinkedList<int>(q2);
            LinkedListNode<int> node1 = new LinkedListNode<int>(3);
            Console.WriteLine("q3Linkedlist  = " + String.Join(" | ", q3LinkedList) );

            LinkedList<int> temp = new LinkedList<int>();
            int count = 0;
           while(q3LinkedList.Count > 0)
            {
                count++;
                if(count == 3)
                {
                    temp.AddLast(node1 );
                }

                //won't work since you need first to remove it, you cannot insert node into two lists
                //temp.AddLast(q3LinkedList.First);
                LinkedListNode<int> node2 = q3LinkedList.First;
                q3LinkedList.RemoveFirst();
                temp.AddLast(node2 );
            }
            q3LinkedList = temp;
            Console.WriteLine("q3Linkedlist after adding 1 = " + String.Join(" | ", q3LinkedList));

            //((ICollection<LinkedListNode<int>>) q3LinkedList).Add(node1);
            // Console.WriteLine("q3Linkedlist after adding 2 = " + String.Join(" | ", q3LinkedList));


            Console.WriteLine("First left = " + FirstLeft(node1).Value);


            Clown c1 = new Clown("Light", 1);
            Clown c2 = new Clown("Medium", 2);
            Clown c3 = new Clown("Heavy", 3);

            Clown[] clownsFalse = { c1, c3, c2 };
            Clown[] clownsTrue = {c1, c2, c3};

            LinkedList<Clown> notStablePyramid = new LinkedList<Clown>(clownsFalse);
            LinkedList<Clown> stablePyramid = new LinkedList<Clown>(clownsTrue);

            Pyramid notStable = new Pyramid(notStablePyramid);
            Pyramid stable = new Pyramid(stablePyramid);
            Console.WriteLine("pyramid = {0} stable ? - {1}", notStable , notStable.IsStable());
            Console.WriteLine("pyramid = {0} stable ? - {1}",stable , stable.IsStable());
            //adding clowns: 
            Clown notC = new Clown("not enough", 2);
            Clown yesC = new Clown("Can added", 5);

            stable.AddClown(notC);
            Console.WriteLine("pyramid after trying adding clown {0} ={1} ", notC, stable );
            stable.AddClown(yesC);
            Console.WriteLine("pyramid after trying adding clown {0} ={1} ", yesC, stable);

        }
        //
        //צריך בדיקה... 
        //הסיבוכיות היא 
        //O(n^n)
        //Because we can call in the wrost scenario n time to count which is n so it comes O(n^n)
        public static bool IsThreePali(Stack<char> data)
        {
            if(data.Count % 3 != 0)
            {
                return false;
            }
            int partialLength = data.Count / 3;
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            for(int i = 0; i < partialLength; i++)
            {
                stack1.Push (data.Pop());

            }
            //Console.WriteLine("data = " + String.Join(",", data));
            //Console.WriteLine("stack1 = " + String.Join(",", stack1));

            while (stack1.Count > 0)
            {
                if(stack1.Pop() != data.Peek())
                {
                    return false;
                }
                stack2.Push (data.Pop());
            }
            //Console.WriteLine("data = " + String.Join(",", data));
            //Console.WriteLine("stack2 = " + String.Join(",", stack2));
            while (stack2.Count > 0)
            {
                if (stack2.Pop() != data.Pop())
                {
                    return false;
                }
            }

            return true;
        }


        //from here - chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://kadman11.wordpress.com/wp-content/uploads/2023/12/t381_2023.pdf
        //the solution is: chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://kadman11.wordpress.com/wp-content/uploads/2023/12/pitaron899381_2023.pdf

        //q1
        public static bool PosOrder(int[] data)
        {
            int last = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] > 0)
                {
                    if (data[i] < last)
                    {
                        return false;
                    }
                    else
                    {
                        last = data[i];
                    }
                }
                
            }

            return true;
        }
        //q2
        //assuming that the data is ok 
        public static int MissingNum(int[] data)
        {

            //we need to find the interval by finding some reccuring interval 

            //and compare it to the missing interval which is twice of it...
           
            //it must be one of those the smaller
            int interval = Math.Min(data[1]- data[0], data[2] - data[1]);
            int missingNum = -1;

            for(int i = 0; i < data.Length-1; i++)
            {
                if(data[i+1] - data[i] > interval)
                {
                    missingNum = data[i] + interval;
                    return missingNum; ;
                }
            }
            return -1;
           

        }
        //here 
        //chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://kadman11.wordpress.com/wp-content/uploads/2023/11/t205_16.pdf
        //q4

        public static LinkedListNode<int> FirstLeft(LinkedListNode<int> pos)
        {

            while (pos.Previous != null)//previos is like GetRight();
                pos = pos.Previous;
            


            return pos;
        }

        //q5 
        public class Clown
        {
            private string name; // שם ליצן
            private int weight; // משקל ליצן

            public Clown(string name, int weight)
            {
                this.name = name;
                this.weight = weight;
            }

            public int Weight { get=>weight; set=>this.weight = value; }

            public override string ToString()
            {
                return string.Format("Clown = [name={0}, weight =  {1}] \n", name, weight);
            }
        }

        public class Pyramid
        {
            private LinkedList<Clown> clowns = null;

            public Pyramid(LinkedList<Clown> clowns)
            {
                this.clowns = clowns;
            }
            public bool IsStable()
            {
                LinkedList<Clown> temp = new LinkedList<Clown>(clowns);

                Clown previous = temp.First.Value;
                temp.RemoveFirst();
                while(temp.Count > 0)
                {
                    if(previous.Weight > temp.First.Value.Weight)
                    {
                        return false;
                    }
                    previous = temp.First.Value;    
                    temp.RemoveFirst();

                }



                return true;
            }

            public bool AddClown(Clown clown)
            {

                if (clown.Weight >= clowns.Last.Value.Weight)
                {
                    clowns.AddLast(clown);
                    return true;
                }
                return false;

            }

            public override string ToString()
            {
                return "Clowns = " + string.Join(",", clowns);
            }
        }
    }
}
