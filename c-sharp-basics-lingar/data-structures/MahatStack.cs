using System;

namespace c_sharp_basics_lingar.data_structures
{


    public class MahatStack<T>
        {
            private Node<T> head;

            public MahatStack()
            {
                this.head = null;
            }

            public void Push(T x)
            {
                Node<T> newNode = new Node<T>(x);
                newNode.SetNext(head);
                head = newNode;
            }

            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty. Cannot pop.");
                }

                T value = head.GetValue();
                head = head.GetNext();
                return value;
            }

            public T Top()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty. Cannot get top element.");
                }

                return head.GetValue();
            }

            public bool IsEmpty()
            {
                return head == null;
            }

            public override string ToString()
            {
                Node<T> current = head;
                string stackString = "Stack[";

                while (current != null)
                {
                    stackString += current.ToString();
                    current = current.GetNext();

                    if (current != null)
                    {
                        stackString += ",";
                    }
                }

                stackString += "]";
                return stackString;
            }
            public static bool IsPalindrome(MahatStack<int> stack)
            {
                MahatStack<int> tempStack = new MahatStack<int>();
                MahatStack<int> reversedStack = new MahatStack<int>();

                while (!stack.IsEmpty())
                {
                    int item = stack.Pop();
                    tempStack.Push(item);
                    reversedStack.Push(item);
                }

                while (!tempStack.IsEmpty())
                {
                    stack.Push(tempStack.Pop());
                }

                while (!stack.IsEmpty() && !reversedStack.IsEmpty())
                {
                    int topOriginal = stack.Pop();
                    int topReversed = reversedStack.Pop();

                    if (topOriginal != topReversed)
                    {
                        Console.WriteLine("The stk does not contain a palindrome.");
                        return false;
                    }
                }

                Console.WriteLine("The stk contains a palindrome.");
                return true;
            }

            public static bool IsDoublePalindrome(MahatStack<int> stack)
            {
                MahatStack<int> tempStack = new MahatStack<int>();
                MahatStack<int> reversedStack = new MahatStack<int>();
                MahatStack<int> reversedStack2 = new MahatStack<int>();

                bool firstPalindromeFound = false;
                bool secondPalindromeFound = false;

                while (!stack.IsEmpty())
                {
                    int item = stack.Pop();

                    if (item < 0)
                    {
                        Console.WriteLine("Numbers in the stk cannot be below 0.");
                        return false;
                    }

                    tempStack.Push(item);
                    reversedStack.Push(item);
                }

                while (!tempStack.IsEmpty())
                {
                    int item = tempStack.Pop();
                    reversedStack2.Push(item);
                }

                firstPalindromeFound = IsPalindrome(reversedStack);

                secondPalindromeFound = IsPalindrome(reversedStack2);

                if (firstPalindromeFound && secondPalindromeFound)
                {
                    Console.WriteLine("The stk contains two palindromes.");
                    return true;
                }
                else
                {
                    Console.WriteLine("The stk does not contain two palindromes.");
                    return false;
                }
            }
            public static int FirstPlace(MahatStack<int> stk, int num)
            {
                int placeOfNum = -1;
                MahatStack<int> temp = new MahatStack<int>();

                int i = 0;
                bool found = false;

                while (!stk.IsEmpty())
                {
                    int current = stk.Pop();
                    i++;

                    if (!found && current == num)
                    {
                        placeOfNum = i;
                        found = true;
                    }

                    temp.Push(current);
                }

                while (!temp.IsEmpty())
                {
                    stk.Push(temp.Pop());
                }

                return placeOfNum;
            }

            public static int LastPlace(MahatStack<int> stk, int num)
            {
                int placeOfNum = -1;
                MahatStack<int> temp = new MahatStack<int>();

                int i = 0;

                while (!stk.IsEmpty())
                {
                    int current = stk.Pop();
                    i++;

                    if (current == num)
                    {
                        placeOfNum = i;
                    }

                    temp.Push(current);
                }

                while (!temp.IsEmpty())
                {
                    stk.Push(temp.Pop());
                }

                return placeOfNum;
            }
            public static int FindDistance(MahatStack<int> stk)
            {
                int first = 0, last = 0;
                int prev = 0, next = 0;
                bool foundFirst = false;
                int i = 0;
                MahatStack<int> temp = new MahatStack<int>();
                MahatStack<int> temp2 = new MahatStack<int>();

                while (!stk.IsEmpty())
                {
                    i++;
                    next = stk.Pop();
                    prev = next;

                    temp.Push(prev);

                    next = stk.Pop();

                    while (!temp.IsEmpty())
                    {

                        if (temp.Top() == next && !foundFirst)
                        {
                            first = i;
                            foundFirst = true;
                            temp2.Push(temp.Pop());
                        }
                        else if (temp.Top() == next && foundFirst)
                        {
                            last = i;
                            temp2.Push(temp.Pop());
                        }
                        else
                        {
                            temp2.Push(temp.Pop());
                        }
                    }
                    temp.Push(prev);
                    while (!temp2.IsEmpty())
                    {
                        temp.Push(temp2.Pop());
                    }
                }
                while (!temp.IsEmpty())
                {
                    stk.Push(temp.Pop());
                }

                Console.WriteLine(first - last - 1);
                return first - last - 1;
            }
        }
    
}
