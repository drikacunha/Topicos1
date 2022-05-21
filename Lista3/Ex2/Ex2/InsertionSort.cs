using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class InsertionSort : ShellSort
    {
        public void sort(double[] a)
        {
            insertionSort(a);
        }

        public void insertionSort(double[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
                for (int j = i; j > 0; j--)
                    if (a[j] < a[j - 1])
                        exch(a, j, j - 1);
                    else
                        break;
        }

        private void exch(double[] a, int i, int j)
        {
            double swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
    }
}
