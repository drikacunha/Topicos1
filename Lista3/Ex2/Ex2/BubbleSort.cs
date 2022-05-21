using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class BubbleSort : InsertionSort
    {
        public void sort(double[] a)
        {
            bubbleSort(a, a.Length);
        }

        public void bubbleSort(double[] a, int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    if (a[j] > a[j + 1])
                    {
                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            }
        }0
    }
}
