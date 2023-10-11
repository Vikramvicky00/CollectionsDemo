using System;
using System.Collections;


namespace Assigment11Oct
{
    class ArrayListMain
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("V");
            arrayList.Add(4.5);
            arrayList.Add("I");
            arrayList.Add(6.76);
            arrayList.Add("K");
            arrayList.Add(8);
            arrayList.Add("A");
            arrayList.Add(10);
            Console.WriteLine("Original Array :");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            int i =arrayList.BinarySearch("I");
            arrayList.RemoveAt(i);
            Console.WriteLine("After Removing..");
            Console.WriteLine("------------------------");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Coping arraylist to array");
            object[] copyArr = new object[arrayList.Count];
            arrayList.CopyTo(copyArr);
            foreach(var item in copyArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Removing the elements which are not Ints");
            int c=0;
            foreach (object item in copyArr)
            {
                if (item.GetType() != typeof(int))
                { 
                    copyArr[c] = 0;
                }
                c++;
            }
            foreach (var item in copyArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");
            Array.Sort(copyArr);
            Console.WriteLine("The Sorted Array : ");
            foreach (var item in copyArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("The Reverse Array :");
            Array.Reverse(copyArr);
            foreach (var item in copyArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
