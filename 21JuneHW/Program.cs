using System;
using System.Collections.Generic;

namespace _21JuneHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ",");


            int[] array = new int[] { 1, 2, 3, 4 };
            Stack<int> yourStack = new Stack<int>(array);

            foreach (var item in yourStack)
                Console.Write(item + ",");
            Console.WriteLine(yourStack.Pop());
            Console.WriteLine(yourStack.Peek());
            Console.WriteLine(yourStack.Pop());
            Console.WriteLine(yourStack.Peek());


            Stack<int> stackino = new Stack<int>();
            stackino.Push(1);
            stackino.Push(2);
            stackino.Push(3);
            stackino.Push(4);

            stackino.Contains(4);
            stackino.Contains(35);

            Queue<string> stringQue = new Queue<string>();
            stringQue.Enqueue("H");
            stringQue.Enqueue("e");
            stringQue.Enqueue("l");
            stringQue.Enqueue("l");
            stringQue.Enqueue("o");

            Console.WriteLine("Total elements: {0}", stringQue.Count); 

            while (stringQue.Count > 0)
                Console.WriteLine(stringQue.Dequeue()); 

            Console.WriteLine("Total elements: {0}", stringQue.Count);


            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); 

            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); 
                Console.WriteLine(strQ.Peek()); 
            }

            Console.WriteLine("Total elements: {0}", strQ.Count);

            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            callerIds.Contains(2); 
            callerIds.Contains(10); 
        }
    }
}
