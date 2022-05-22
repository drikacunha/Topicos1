using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class ArrayAbstract
    {
        public Sort azar;
        public int[] a = new int[10000];

        public ArrayAbstract()
        {
            for (int i = 9999, j = 0; i != 0; i--, j++)
            {
                a[j] = j;
            }
        }

    }
}
