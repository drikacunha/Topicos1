using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class InsertionSort : Sort
    {
        public int[] SortArray(int[] a)
        {
            int i = 0, j = 0, atual = 0;
            for (i = 1; i < a.Length; i++)
            {
                atual = a[i];
                j = i;
                while ((j > 0) && (a[j - 1] > atual))
                {
                    a[j] = a[j - 1];
                    j = j - 1;
                }
            }
            a[j] = atual;

            return a;
        }
    }
}
