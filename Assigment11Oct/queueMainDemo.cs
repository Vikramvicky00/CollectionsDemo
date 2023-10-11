using System;
using System.Collections;

namespace Assigment11Oct
{
    internal class queueMainDemo
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue("Hello");
            q1.Enqueue("Bye");
            q1.Enqueue(3);
            Console.WriteLine("The Original Queue :");
            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");
            object ele = q1.Peek();
            Console.WriteLine("Peek Element : {0}", ele);
            Console.WriteLine("-----------------------");
            object q = q1.Dequeue();
            Console.WriteLine($"The Removed Element : {q}");
            Console.WriteLine("After Popping the element, The Queue is : ");
            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            Queue q2 = new Queue(q1.Count);
            q2 = (Queue)q1.Clone();
            Console.WriteLine("The Copied Queue :");
            foreach (var i in q2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            q1.Clear();
            Console.ReadLine();
        }
    }
}
