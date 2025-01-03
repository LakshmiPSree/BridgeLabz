using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class Program
    {   
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public class SingleLinkedList
        {
            public Node head;
            public SingleLinkedList()
            {
                head = null;
            }

            //Insert at the front
            public void InsertFront(int data)
            {
                Node new_node = new Node(data);
                new_node.next = head;
                head = new_node;
            }
            //Insert at the end
            public void InsertEnd(int new_data)
            {
                Node new_node = new Node(new_data);
                if (head == null)
                {
                    head = new_node;
                    return;
                }
                Node i = head;
                for (i = head;i.next != null; i = i.next) { }
                i.next = new_node;
            }
            //Insert in between
            public void InsertInBetween(int new_data)
            {
                Console.WriteLine("Enter the element after which you have to add the new data");
                int previous_data = int.Parse(Console.ReadLine());
                if(head == null)
                {
                    Console.WriteLine("Cannot add the value in middle");
                }
                Node new_node = new Node(new_data);
                Node temp = head;
                while (temp!= null && temp.data != previous_data)
                {
                    temp = temp.next;
                }
                Node AfterTemp = temp.next;
                temp.next = new_node;
                new_node.next = AfterTemp;
            }
            // Display all the elements in the list
            public void Display()
            {
                Node temp = head;
                Console.WriteLine("The elements in the list are: ");
                while (temp != null)
                {
                    Console.Write($"{temp.data} ");
                    temp = temp.next;
                }
            }
            //Delete the element in the linkedlist
            public void Delete()
            { 
                Node temp = head;
                if (temp == null)
                {
                    Console.WriteLine("There is no element in the list");
                    return;
                }
                Console.WriteLine("Enter the element which you have to delete");
                int userData = int.Parse(Console.ReadLine());
                if(head.data == userData)
                {
                    head = head.next;
                    return;
                }
                for (temp = head; temp.next != null && temp.next.data != userData; temp = temp.next) { }
                temp.next = temp.next.next;

            }
        }

        static void Main(string[] args)
        {   
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            while (true)
            {
                Console.WriteLine("******************The menu*******************");
                Console.WriteLine("1.Add an element to the front");
                Console.WriteLine("2.Add an element at the end");
                Console.WriteLine("3.Add an element in between");
                Console.WriteLine("4.Display all the elements");
                Console.WriteLine("5.Delete an Element");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element u want to add at the beginning of the linked list");
                        int element = int.Parse(Console.ReadLine());
                        singleLinkedList.InsertFront(element);
                        break;

                    case 2:
                        Console.WriteLine("Enter the element u want to add at the end of the linked list");
                        int endElement = int.Parse(Console.ReadLine());
                        singleLinkedList.InsertEnd(endElement);
                        break;

                    case 3:
                        Console.WriteLine("Enter the element u want to add in between of the linked list");
                        int betweenElement = int.Parse(Console.ReadLine());
                        singleLinkedList.InsertInBetween(betweenElement);
                        break;

                    case 4:
                        singleLinkedList.Display();
                        break;

                    case 5:
                        singleLinkedList.Delete();
                        break;

                    case 6:
                        Console.WriteLine("Thankyou for using our Software....");
                        return;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }

        }
    }
}
