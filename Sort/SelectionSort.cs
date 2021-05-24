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

            int idmin;
            int idmax;
            
            int temp;
            for (int i = 0; i < a.Length-1; i++)
            {
                idmax = i;
                idmin = i;
                for (int j = 0; j < a.Length-j; j++)
                {
                    if (a[j]>a[idmax])
                    {
                        
                        idmax = j;
                        
                    }
                }
                if (idmax != i)
                {


                    temp = a[a.Length - i];
                    a[a.Length - i] = a[idmax];
                    a[idmax] = temp;
                    
                }
                    
            }
        }
    }
}
