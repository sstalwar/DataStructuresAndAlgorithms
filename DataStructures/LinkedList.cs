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
            node.next = head;
            head = node;
            return node;
        }

        public Node AddToEnd(int data)
        {
            var node = new Node(data);

            if (head == null)
            {
                head = node;
                return node;
            }

            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            
            return node;
        }

        public Node AddToNthPosition(int data, int position)
        {
            if (position == 0 || (head == null & position > 1))
            {
                Console.WriteLine("\n Error: Please provide correct position");
                return null;
            }
            if (position == 1)
            {
                var node = AddToBegining(data);
                return node;                
            }

            var temp = head;
            int i = 1;
            for (; i < position-1; i++)
            {
                if (temp.next == null)
                {
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }

            if (temp.next == null && (i < position - 1))
            {
                Console.WriteLine("\n Error: Please provide correct position");
                return null;
            }
            else if (i == position - 1)
            {
                var node = new Node(data);
                node.next = temp.next;
                temp.next = node;
                return node;
            }

            return null;
        }

        public Node DeleteNodeAtNthPosition(int position)
        {
            if (head == null)
            {
                return null;
            }
            if (position == 0 || (head == null & position > 1))
            {
                Console.WriteLine("\n Error: Please provide correct position");
                return null;
            }

            if (position == 1)
            {
                var temp = head;
                head = temp.next;
                temp.next = null;
            }

            return null;
        }

        public void PrintLinkedList()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");                
            }
            else
            {
                Console.WriteLine("\nLinked List:");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
