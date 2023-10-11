using System;
using System.Collections;

namespace Assigment11Oct
{
    internal class stackMainDemo
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push("Hi");
            s1.Push(2);
            s1.Push("Hello");
            s1.Push(4);
            Console.WriteLine("The Stack Elements :");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            object s=s1.Peek();
            Console.WriteLine("Peek Element : {0}",s);
            Console.WriteLine("---------------");
            object p=s1.Pop();
            Console.WriteLine("PoP Element : {0}", p);
            Console.WriteLine("---------------");
            Console.WriteLine("After Popping the elements:");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            Stack s2 = new Stack(s1.Count);
            s2= (Stack)s1.Clone();
            Console.WriteLine("The Copied Stack");
            foreach (var i in s2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            s1.Clear();
            Console.ReadLine();

        }
    }
}
