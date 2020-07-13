using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructures
{

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    class LinkedList
    {
        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public Node AddToBegining(int data)
        {
            Node node = new Node(data);

            if (head != null)
            {
                node.next = head;
            }

            head = node;
            return node;
        }


        public void PrintLinkedList()
        {
            Node t = head;
            if (t == null)
            {
                Console.WriteLine("LinkedList is empty");                
            }
            else
            {
                while (t != null)
                {
                    Console.WriteLine(t.data);
                    t = t.next;
                }
            }
            Console.ReadLine();
        }
    }
}
