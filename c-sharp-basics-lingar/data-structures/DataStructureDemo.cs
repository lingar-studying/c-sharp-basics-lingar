using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures
{
    public class DataStructureDemo
    {
        public static int X = 10;
        public static void Demo()
        {
            Console.Write("not break line");
            Console.WriteLine("Data Structure Demo");
            Console.Write("not break line");
            Console.WriteLine( "x= " + DataStructureDemo.X );


            MahatStack<int> stackUnitform = new MahatStack<int>();

            stackUnitform.Push(3);

            stackUnitform.Push(5);
            stackUnitform.Push(7);
            MahatStack<int> stackNotUnitform = new MahatStack<int>();

            stackNotUnitform.Push(8);
            stackNotUnitform.Push(10);
            stackNotUnitform.Push(11);

            Console.WriteLine("is Uniform true " + IsUniform(stackUnitform));

            Console.WriteLine("is Uniform false " + IsUniform(stackNotUnitform));
            MahatQueue<int> queue = new MahatQueue<int>();

            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            queue.Insert(4);

            int removed = RemoveLast2(queue);

            Console.WriteLine("removed = {0},\nupdated queue = {1}", removed, queue.ToString());


            BinNode<int> b1 = new BinNode<int>(10);

            BinNode<int> b2 = new BinNode<int>(2);
            b1.setRight(b2);

            BinNode<int>  b3 = new BinNode<int>(22);
            b3.setRight(new BinNode<int>(3));
            b3.setLeft(new BinNode<int>(4));

            b2.setRight(b3);
            BinNode<int> b4 = new BinNode<int>(5);
            BinNode<int> b5 = new BinNode<int>(14);

            BinNode<int> b6 = new BinNode<int>(6);
            b5.setLeft(b6);
            b4.setRight(b5);
            b1.setLeft(b4);

            Console.WriteLine(b1.toString());
            PrintAllBinaryTree(b1);
            PrintUnderAverage(b1);

        }
        //מניחים שיש במחסנית לפחות מס' 1
        public static bool IsUniform(MahatStack<int> st)
        {
            int value = st.Pop() ;
            bool isEven = value % 2 == 0;

            while (!st.IsEmpty())
            {
                value = st.Pop() ;
                if (isEven)
                {
                    if(value % 2 != 0)
                    {
                        return false;
                    }
                }
                else
                {
                    if(value % 2 == 0)
                    {
                        return false ;
                    }
                }
            }
            return true;
        } 

        public static int RemoveLast(MahatQueue<int> queue)
        {
            MahatQueue<int> temp = new MahatQueue<int>();
            int current = 0;
            while (!queue.IsEmpty())
            {
                current = queue.Head();
                temp.Insert(queue.Remove());

            }
            while (!temp.IsEmpty())
            {
                if(current == temp.Head())
                {
                    temp.Remove();
                }
                queue.Insert(temp.Remove());
            }
            return current;

        }

        public static int RemoveLast2(MahatQueue<int> queue)
        {
            MahatQueue<int> temp = new MahatQueue<int>();
            int current = 0;
            while (!queue.IsEmpty())
            {
                current = queue.Remove();
                if (!queue.IsEmpty())//checking if last
                {
                    temp.Insert(current);
                }
            }

            while (!temp.IsEmpty())
            {
                queue.Insert(temp.Remove());
            }
            return current;

        }


        public static void PrintAllBinaryTree(BinNode<int> bt)
        {
            //base case
            if (bt == null) return;
            
            Console.Write(bt.getValue() + ",");
            PrintAllBinaryTree(bt.getRight());
            PrintAllBinaryTree(bt.getLeft());


        }

        public static void PrintUnderAverage(BinNode<int> bt)
        {
            int[] arr = { 0, 0 };//sum,count
            int[] arr2 = GetSumAndCount(bt, arr);

            Console.WriteLine("\narr2 = " + String.Join("|", arr2));

            double average = (double)arr2[0] / arr2[1];
            Console.WriteLine("average = " + average);
            PrintNode(bt, average);

        }

        public static int[] GetSumAndCount(BinNode<int> bt, int[] arr )
        {
            if (bt == null) return arr;

            arr[0] += bt.getValue();
            arr[1]++;

            arr = GetSumAndCount(bt.getRight(), arr);
            arr = GetSumAndCount(bt.getLeft(), arr);

            return arr;

        }

        public static void PrintNode(BinNode<int> bt, double average)
        {
            //base case
            if (bt == null) return;
            if(bt.getValue() < average) Console.Write(bt.getValue() + ",");
            PrintNode(bt.getRight(), average);
            PrintNode(bt.getLeft(), average);


        }
    }
}
