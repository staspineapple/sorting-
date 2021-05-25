using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] a = { 3,2,1,0,1,2,3,2,1,2,3,2,1,0};
            BubbleSort b = new BubbleSort(a);
            InsertionSort i = new InsertionSort(a);
            SelectionSort s = new SelectionSort(a);
            DoubleSelectionSort d = new DoubleSelectionSort(a);

        

            d.Sort();
            
            d.Print();

            //s.Sort();
            //s.Print();

            //i.Sort();
            //i.Print();

            //b.Sort();
            //b.Print();
        }
    }
}
