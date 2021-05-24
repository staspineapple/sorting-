using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectionSort : ISort
    {
        int[] a;

        public SelectionSort(int[] a)
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

            int min;
            int idmax;
            
            int temp, j,i;

            for (i = 0; i < a.Length ; i++)
            {
                idmax = 0;

                for (j   = 0; j < a.Length-i; j++)
                {
                    if (a[j]>a[idmax])
                    {
                        idmax = j;
                    }
                }

                temp = a[a.Length - i - 1];
                a[a.Length - i - 1] = a[idmax];
                a[idmax] = temp;
            }
            
            
           
        }
    }
}
