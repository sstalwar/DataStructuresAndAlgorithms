using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddToBegining(1);
            linkedList.AddToBegining(2);
            linkedList.AddToBegining(3);
            linkedList.AddToBegining(4);
            linkedList.AddToBegining(5);
            linkedList.PrintLinkedList();
        }
    }
}
