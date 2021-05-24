using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] a = { 9,8,7,6,5,4,3,2,1,0,9,8,7,6,5,4,3,2,1 };
            BubbleSort b = new BubbleSort(a);
            SelectionSort s = new SelectionSort(a);
            
            s.Sort();
            s.Print();

            //b.Sort();
            //b.Print();
        }
    }
}
