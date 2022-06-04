namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer fibonaccis = new FiboCollection();
            for (FiboIterator it = fibonaccis.criarIterator(); !it.isDone(); it.next())
            {
                Console.WriteLine(it.currentItem().fibo);
            }

        }
    }
}