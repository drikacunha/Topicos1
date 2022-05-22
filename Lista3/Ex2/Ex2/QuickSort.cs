﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
	class QuickSort : Sort
	{
		public int[] SortArray(int[] a)
		{
			int inicio = 0;
			int fim = a.Length - 1;

			quickSort(a, inicio, fim);

			return a;
		}

		private static void quickSort(int[] vetor, int inicio, int fim)
		{
			if (inicio < fim)
			{
				int p = vetor[inicio];
				int i = inicio + 1;
				int f = fim;

				while (i <= f)
				{
					if (vetor[i] <= p)
					{
						i++;
					}
					else if (p < vetor[f])
					{
						f--;
					}
					else
					{
						int troca = vetor[i];
						vetor[i] = vetor[f];
						vetor[f] = troca;
						i++;
						f--;
					}
				}

				vetor[inicio] = vetor[f];
				vetor[f] = p;

				quickSort(vetor, inicio, f - 1);
				quickSort(vetor, f + 1, fim);
			}
		}

	}
}
