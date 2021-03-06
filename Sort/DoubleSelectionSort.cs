using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort
{
    class DoubleSelectionSort : ISort
    {
        int[] a;
        public DoubleSelectionSort(int[] a)
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

            int idmax, idmin;

            int temp, j, i;

            for (i = 0; i < a.Length/2; i++)
            {
                idmax = i;
                idmin = i;
                

                for (j = i; j < a.Length - i; j++)
                {
                    if (a[j] > a[idmax])
                    {
                        idmax = j;
                    }
                    if (a[j]<a[idmin])
                    {
                        idmin = j;
                    }
                }
                

                temp = a[i];
                a[i] = a[idmin];
                a[idmin] = temp;
                //Меняем минимальный с первым неотсортированным
                if (i == idmax)
                {
                    idmax = idmin;
                }
                //Если первый был максимльный, то он переместился на место самого маленького.

                temp = a[a.Length - i - 1];
                a[a.Length - i - 1] = a[idmax];
                a[idmax] = temp;






               
            }

        }

        public async Task SortAsync()
        {
            await Task.Run(() => Sort());
        }
    }
}
