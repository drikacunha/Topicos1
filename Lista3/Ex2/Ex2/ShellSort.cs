using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class ShellSort : Sort
	{
		public int[] SortArray(int[] a)
		{
			int h = 1;
			int n = a.Length;

			while (h < n)
			{
				h = h * 3 + 1;
			}

			h = h / 3;
			int c, j;
			while (h > 0)
			{
				for (int i = h; i < n; i++)
				{
					c = a[i];
					j = i;
					while (j >= h && a[j - h] > c)
					{
						a[j] = a[j - h];
						j = j - h;
					}
					a[j] = c;
				}
				h = h / 2;
			}
			return a;
		}

	}
}
