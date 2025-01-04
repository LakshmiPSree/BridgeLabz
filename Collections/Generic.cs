using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generic
    {
        public static void ListProblem()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        public static void DictionaryProblem()
        {
            Dictionary<int,int> hashTable = new Dictionary<int,int>();
            hashTable.Add(1, 123);
            hashTable.Add(2,124);
            Console.WriteLine("dictionary");
            foreach (KeyValuePair<int,int> item in hashTable)
            {
                Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            }
        }

        public static void SortedListProblem()
        {
            SortedList<string,string> sortList = new SortedList<string,string>();

            sortList.Add("ac", "bc");
            sortList.Add("dc", "bc"); // only one data type is supported
            //sortList.Add(1, 1.23);
            //sortList.Add("srt", 1.23);
            // sortList.Add(null, null);
            //sortList.Add(DateTime.Now, null); any field cannot be null
            Console.WriteLine("sortedlist");
            foreach (KeyValuePair<string,string> item in sortList)
            {
                Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            }
        }

        public static void QueueProblem()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Peek();
            Console.WriteLine("queue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public static void StackPrblem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            Console.WriteLine("stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
