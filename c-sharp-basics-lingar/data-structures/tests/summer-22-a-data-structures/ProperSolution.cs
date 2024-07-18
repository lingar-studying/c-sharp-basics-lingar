using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures.tests.summer_22_a_data_structures
{
    public class ProperSolution
    {

        //get only node 

        public static void SolveQ1(LinkedListNode<int> node)
        {


            LinkedListNode<int> head = null, last  = null;

            while(node.Next != null)
            {

                int difference = node.Value - node.Next.Value;

                if (head == null)
                {

                    head = new LinkedListNode<int>(difference);
                    last = head;

                    node = node.Next;
                }
                else
                {
                   //last.next = new LinkedListNode<int>(difference);
                }

            }

        }
    }
}
