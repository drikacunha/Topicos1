namespace Ex5
{
    public class FiboIterator : Iterator
    {
        protected List<Fibonacci> lista;
        protected int contador;

        public FiboIterator(List<Fibonacci> lista)
        {
            this.lista = lista;
            contador = 0;
        }

        public Fibonacci currentItem()
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
