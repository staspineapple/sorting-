using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] a = { 6,5,4,3,2,1,1,0,0,1,2,3,4,5,6,1,2,3,4,5,6 };
            BubbleSort b = new BubbleSort(a);
            InsertionSort i = new InsertionSort(a);
            SelectionSort s = new SelectionSort(a);

            s.Sort();
            s.Print();
            
            //i.Sort();
            //i.Print();

            //b.Sort();
            //b.Print();
        }
    }
}
