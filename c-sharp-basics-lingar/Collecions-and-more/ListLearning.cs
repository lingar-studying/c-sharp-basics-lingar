using c_sharp_basics_lingar.hospital;
using System;
using System.Collections.Generic;
using System.Text;

//interface https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=net-8.0
namespace c_sharp_basics_lingar.Collecions_and_more
{
    public class ListLearning
    {//check

        public static void DemoList()
        {
            Console.WriteLine("hey");

            //List - https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0
            List<string> l = new List<string>();
            l.Add("Avi");
            l.Add("Yossi");
            l.Add("Izik");

            Console.WriteLine("l = " + l);
            Console.WriteLine("Count - " + l.Count);
            l.ForEach(Console.WriteLine);

            l.Reverse();
            l.ForEach(Console.WriteLine);

            Console.WriteLine("second element = " + l[1]);


            //You can do it with other objects too 
            List<Employee> employees = new List<Employee>();

            //use your imagination...

            //linked list - https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0
            //You can change only the first and last, but all the values linked to each other... unlike list that you can 
            //affect indexes. 
            LinkedList<string> linkedStrings = new LinkedList<string>();

            linkedStrings.AddLast("a");
            linkedStrings.AddFirst("b");
            linkedStrings.AddLast("c");
            //linkedStrings.Fo
            //linkedStrings.AddAfter("a","b");
            Console.WriteLine(string.Join("|", linkedStrings));
            //FromDocsLinkedList();

            //Stack is like Havit, that you put things in Last In First Out way (LIFO) (You don't provided with other methods
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-8.0
            Stack<string> stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            //Console.WriteLine(  "Lingar??");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Here we can get the item without remove it
            string item1 = stack.Peek();

            Console.WriteLine("item1 = (stack is still the same " + item1);
            //Console.WriteLine(string.Join("|", stack));

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            item1 = stack.Pop();

            Console.WriteLine("now I took the item1 = (stack will be missing one) " + item1);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Queue is first in first out FIFO
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            Console.WriteLine("Queue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            item1 = queue.Dequeue();
            Console.WriteLine("This item get his queue - " + item1);
            Console.WriteLine("Now Queue");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Dictionary is similar to Map on Java
            //It's for finding element by specific item you provided. 
            //It's also can be an object.
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0
            Dictionary<String, Employee> employeesList = new Dictionary<string, Employee>();

            Employee employeeCeo = new Employee("Jack");
            Employee employeeSecretery = new Employee("Rachel");
            Employee employeeAssistant = new Employee("Dan");

            employeesList.Add("ceo", employeeCeo);
            employeesList.Add("secretary", employeeSecretery);

            Console.WriteLine("get the item - similary to array :" + employeesList["secretary"]);

            //TODO
            //See how it's working with objects. 
            //When we'll use each data structure


        }
        public static void FromDocsLinkedList()
        {
            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            // Move the first node to be the last node.
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");

            // Change the last node to 'yesterday'.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            // Move the last node to be the first node.
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node:");

            // Indicate the last occurence of 'the'.
            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

            // Indicate 'fox' node.
            current = sentence.Find("fox");
            IndicateNode(current, "Test 7: Indicate the 'fox' node:");

            // Add 'quick' and 'brown' before 'fox':
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");

            // Keep a reference to the current node, 'fox',
            // and to the previous node in the list. Indicate the 'dog' node.
            mark1 = current;
            LinkedListNode<string> mark2 = current.Previous;
            current = sentence.Find("dog");
            IndicateNode(current, "Test 9: Indicate the 'dog' node:");

            // The AddBefore method throws an InvalidOperationException
            // if you try to add a node that already belongs to a list.
            Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");
            try
            {
                sentence.AddBefore(current, mark1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }
            Console.WriteLine();

            // Remove the node referred to by mark1, and then add it
            // before the node referred to by current.
            // Indicate the node referred to by current.
            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog):");

            // Remove the node referred to by current.
            sentence.Remove(current);
            IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it:");

            // Add the node after the node referred to by mark2.
            sentence.AddAfter(mark2, current);
            IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");

            // The Remove method finds and removes the
            // first node that that has the specified value.
            sentence.Remove("old");
            Display(sentence, "Test 14: Remove node that has the value 'old':");

            // When the linked list is cast to ICollection(Of String),
            // the Add method adds a node to the end of the list.
            sentence.RemoveLast();
            ICollection<string> icoll = sentence;
            icoll.Add("rhinoceros");
            Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

            Console.WriteLine("Test 16: Copy the list to an array:");
            // Create an array with the same number of
            // elements as the linked list.
            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Test 17: linked list Contains 'jumps' = {0}",
                sentence.Contains("jumps"));

            // Release all the nodes.
            sentence.Clear();

            Console.WriteLine();
            Console.WriteLine("Test 18: Cleared linked list Contains 'jumps' = {0}",
                sentence.Contains("jumps"));

            Console.ReadLine();
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }


    }
}
