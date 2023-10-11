using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assigment11Oct
{
    internal class hashMainDemo
    {
        static void Main(string[] args)
        {
           Hashtable h = new Hashtable();
            h.Add("Name", "Vikram");
            h.Add("Age", 23);
            h.Add("City", "Vizag");

            Console.WriteLine("The Hash Table :");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine();
            h.Remove("Age");
            Console.WriteLine("After Removing, Elements are :");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("The Original Hash Table :");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("The Copied Hash Table :");
            Hashtable h2 = new Hashtable();
            h2 = (Hashtable)h.Clone();
             foreach (DictionaryEntry item in h2)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
             Console.ReadLine();


        }
    }
}
