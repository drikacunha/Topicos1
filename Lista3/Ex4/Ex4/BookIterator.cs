using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class BookIterator : Iterator
    {
        protected List<Livro> lista;
        protected int contador;

        public BookIterator(List<Livro> lista)
        {
            this.lista = lista;
            contador = 0;
        }

        public Livro currentItem()
        {
            if (isDone())
            {
                contador = lista.Count - 1;
            }
            else if (contador < 0)
            {
                contador = 0;
            }
            return lista.ElementAt(contador);
        }

        public void first()
        {
            contador = 0;
        }

        public bool isDone()
        {
            return contador == lista.Count;
        }

        public void next()
        {
            contador++;
        }
    }
}
