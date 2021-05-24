using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class InsertionSort : ISort
    {
        int[] a;
        public InsertionSort(int[] a)
        {
            this.a = a;

        }
        public void Print()
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        public void Sort()
        {
            int temp;
            for (int i = 1; i < a.Length; i++)
            {
                for (int j =i; (j>0) && (a[j-1]>a[j]) ; j--)
                {
                    temp = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = temp;
                    
                }

                
                
            }
        }
    }
}
