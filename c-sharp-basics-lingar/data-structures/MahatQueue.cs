using System;

namespace c_sharp_basics_lingar.data_structures
{


    public class MahatQueue<T>
        {
            private Node<T> first;
            private Node<T> last;

            public MahatQueue()
            {
                first = null;
                last = null;
            }
            public bool IsEmpty()
            {
                return first == null;
            }
            public void Insert(T x)
            {
                if (last == null)
                {
                    first = new Node<T>(x);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<T>(x));
                    last = last.GetNext();
                }
            }
            public T Remove()
            {
                T t = first.GetValue();

                if (first != last)
                {
                    first = first.GetNext();
                }
                else
                {
                    first = null;
                    last = null;
                }
                return t;
            }
            public T Head()
            {
                return first.GetValue();
            }

            public override string ToString()
            {
                Node<T> temp = first;
                string st = "[";

                while (temp != null)
                {
                    st += temp.GetValue() + ",";
                    temp = temp.GetNext();
                }
                st += "]";
                return st;
            }
            public static int countSorted(MahatQueue<MahatQueue<int>> q)
            {
                int count = 0;
                MahatQueue<int> currentQueue;

                while (!q.IsEmpty())
                {
                    currentQueue = q.Remove();

                    if (IsAscending(currentQueue) == true)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"number of ascending Queues: {count}");
                return count;
            }
            public static bool IsAscending(MahatQueue<int> queue)
            {
                int prev = queue.Remove();
                int next = queue.Remove();

                while (!queue.IsEmpty())
                {
                    if (prev < next)
                    {
                        prev = next;
                        next = queue.Remove();
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            public static void MaxElemnts(MahatQueue<int>[] arrQueue)
            {
                string str = "";
                int max = 0;
                for (int i = 0; i < arrQueue.Length; i++)
                {
                    max = MaxQueue(arrQueue[i]);
                    str += $"biggest number in queue{i}: {max}\n";
                }
                Console.WriteLine(str);
            }
            public static int MaxQueue(MahatQueue<int> queue)
            {
                MahatQueue<int> temp = new MahatQueue<int>();
                int max = 0;

                while (!queue.IsEmpty())
                {
                    if (queue.Head() > max)
                    {
                        max = queue.Head();
                    }
                    else
                    {
                        temp.Insert(queue.Remove());
                    }
                }
                while (!temp.IsEmpty())
                {
                    queue.Insert(temp.Remove());
                }
                return max;
            }
            public static int Crow(int a, int b)
            {
                if (b == 0)
                    return 0;
                if (b % 2 == 0)
                    return Crow(a + a, b / 2);
                return Crow(a + a, b / 2) + a;
            }
            public static MahatQueue<int> Sort(MahatQueue<int> queue)
            {
                MahatQueue<int> resultQueue = new MahatQueue<int>();

                while (!queue.IsEmpty())
                {
                    int current = queue.Remove();
                    int count = 1;

                    while (!queue.IsEmpty() && queue.Head() == current)
                    {
                        queue.Remove();
                        count++;
                    }

                    if (count > 2)
                    {
                        if (!resultQueue.Equals(current))
                        {
                            resultQueue.Insert(current);
                        }
                    }
                }

                return resultQueue;
            }
            public static bool CommonDivisor(int a, int b)
            {
                if (a == 1 || b == 2)
                {
                    Console.WriteLine("commmon devisor is 1");
                    return true;
                }

                int smallerNumber = Math.Min(a, b);

                for (int i = 2; i <= smallerNumber; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine($"found Common divisor: {a}, {b} are divided by {i}");
                        return true;
                    }
                }
                Console.WriteLine("Common divisor is not found");
                return false;
            }
            public static void Sod(MahatQueue<int> q)
            {
                Console.WriteLine(q.ToString());

                q.Insert(0);
                What(q);
                q.Remove();
                Console.WriteLine(q.ToString());

            }
            public static void What(MahatQueue<int> q)
            {
                if (q.Head() != 0)
                {
                    int x = q.Remove();
                    if (x > 0)
                        q.Insert(x);

                    What(q);
                    if (x < 0)
                        q.Insert(x);

                }
            }
        }
    
}
