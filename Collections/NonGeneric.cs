using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class NonGeneric
    {   
        public static void ArrayListProblem()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("aarya");
            arrayList.Add(1.23);
            arrayList.Add('c');
            arrayList.Add(null);
            arrayList.Add(DateTime.Now);
            Console.WriteLine("arrayList");
            foreach (var item in arrayList) { 
                Console.WriteLine(item);
            }

        }

        public static void HashedTableProblem()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, 123);
            //hashTable.Add(1,1.23);//this lines throws excepton during run time,keys should not be same
            hashTable.Add("srt",1.23);
            //hashTable.Add(null,null);//key cannot be null
            hashTable.Add(DateTime.Now,null);
            Console.WriteLine("hashedtable");
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            }
        }

        public static void SortedListProblem()
        { 
            SortedList sortList = new SortedList();
            
            sortList.Add("ac", "bc");
            sortList.Add("dc", "bc"); // only one data type is supported
            //sortList.Add(1, 1.23);
            //sortList.Add("srt", 1.23);
            // sortList.Add(null, null);
            //sortList.Add(DateTime.Now, null); any field cannot be null
            Console.WriteLine("sortedlist");
            foreach (DictionaryEntry item in sortList)
            {
                Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            }
        }

        public static void QueueProblem()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("megana");
            queue.Enqueue(3.68);
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
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("mega");
            stack.Push(3.14);
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
