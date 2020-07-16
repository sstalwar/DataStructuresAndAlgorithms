using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            var yes = 'y';
            while (yes != 'n' && yes !='N')
            {
                Console.WriteLine("\nplease select one of the options below:");
                Console.WriteLine("1. Add element to the beginning: ");
                Console.WriteLine("2. Add element to the end: ");
                Console.WriteLine("3. Add element at nth position:");
                Console.WriteLine("4. Delete element at nth position:");
                Console.WriteLine("Please enter you choice: ");
                var choice = Int32.Parse(Console.ReadLine());
                string input, location;
                int data;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("please enter data to be added to the beginning of Linked List:");
                        input = Console.ReadLine();
                        if (Int32.TryParse(input, out data))
                        {
                            linkedList.AddToBegining(data);
                            linkedList.PrintLinkedList();
                        }
                        else
                        {
                            Console.WriteLine("Please enter numerical data only");
                        }
                        break;
                    case 2:
                        Console.WriteLine("please enter data to be added to the end of Linked List:");
                        input = Console.ReadLine();
                        if (Int32.TryParse(input, out data))
                        {
                            linkedList.AddToEnd(data);
                            linkedList.PrintLinkedList();
                        }
                        else
                        {
                            Console.WriteLine("Please enter numerical data only");
                        }
                        break;
                    case 3:
                        Console.WriteLine("please enter data to be added to the Linked List:");
                        input = Console.ReadLine();
                        if (Int32.TryParse(input, out data))
                        {
                            Console.WriteLine("please enter location to be added to the Linked List:");
                            location = Console.ReadLine();
                            if (Int32.TryParse(location, out int pos))
                            {
                                linkedList.AddToNthPosition(data, pos);
                                linkedList.PrintLinkedList();
                            }
                            else
                            {
                                Console.WriteLine("Please enter numerical data only");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter numerical data only");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please element position to be removed");
                        location = Console.ReadLine();
                        if (Int32.TryParse(location, out int loc))
                        {
                            linkedList.DeleteNodeAtNthPosition(loc);
                            linkedList.PrintLinkedList();
                        }
                        break;
                    default: break;

                }
                Console.WriteLine("\nDo you want to continue?: ");
                Console.WriteLine("\nPress n to terminate or y to continue: ");
                yes = (char)Console.ReadKey().Key;

            }

            //linkedList.AddToBegining(1);
            //linkedList.AddToBegining(2);
            //linkedList.AddToBegining(3);
            //linkedList.AddToBegining(4);
            //linkedList.AddToBegining(5);
            //linkedList.AddToEnd(5);
            //linkedList.AddToEnd(1);
            //linkedList.AddToEnd(2);
            //linkedList.AddToNthPosition(6, 3);
            //linkedList.PrintLinkedList();
        }
    }
}
