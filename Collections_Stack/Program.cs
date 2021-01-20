using System;
using System.Collections.Generic;

namespace Collections_Stack
{
    class Program
    {
        static void display(Stack<string> arr)
        {
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void display(Stack<int> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };

            var myStack1 = new Stack<string>(city);
            var myStack2 = new Stack<int>(arr);

            myStack1.Push("wamik");
            myStack1.Push("afaq");
            myStack1.Push("umair");
            myStack1.Push("askari");
            myStack1.Push("ihtisham");
            myStack1.Push("ihtisham");

            myStack2.Push(89);
            myStack2.Push(69);
            myStack2.Push(100);
            myStack2.Push(77);
            myStack2.Push(444);
            myStack2.Push(393);

            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myStack1);
            Console.WriteLine("Displaying Numbers");
            display(myStack2);

            Console.WriteLine("--------------------------------------------------Searching--------------------------------------------------");
            Console.WriteLine(myStack1.Peek());
            Console.WriteLine(myStack2.Peek());

            myStack1.Pop();
            myStack1.Pop();
            myStack2.Pop();

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myStack1);
            Console.WriteLine("Displaying Numbers");
            display(myStack2);

            Console.WriteLine("--------------------------------------------------Info--------------------------------------------------");
            Console.WriteLine($"Stack 1 count: {myStack1.Count}");
            Console.WriteLine($"Stack 2 count: {myStack2.Count}");
            Console.WriteLine(myStack1.Contains("wamik"));
        }
    }
}
