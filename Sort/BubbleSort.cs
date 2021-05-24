using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class BubbleSort
    {
        int[] a;
        public BubbleSort(int[] a)
        {
            this.a = a;
        }

        public void Sort()
        {
            
            int temp;
            int CountOfChange = 0;

            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a.Length-1-i; j++)
                {


                    if (a[j+1] < a[j])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        CountOfChange++;
                    }
                }
                Console.WriteLine($"{i} заход");
                Print();
                Console.WriteLine($"{i} конец");

                if (CountOfChange==0)
                {
                    break;

                }

                CountOfChange = 0;
            }


            
        }
        
        public void Print()
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
