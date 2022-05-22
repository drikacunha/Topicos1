using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
	public class BubbleSort : Sort
	{
		public int[] SortArray(int[] a)
		{
			int tamanho = a.Length;
			int comparacoes = 0;
			int trocas;

			for (int i = tamanho - 1; i >= 1; i--)
			{
				trocas = 0;
				for (int j = 0; j < i; j++)
				{
					comparacoes++;
					if (a[j] > a[j + 1])
					{
						int aux = a[j];
						a[j] = a[j + 1];
						a[j + 1] = aux;
						trocas++;
					}
				}

				if (trocas == 0)
				{
					return a;
				}
			}
			return a;
		}
	}
}
