namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer livros = new BooksCollection();
            for (BookIterator it = livros.criarIterator(); !it.isDone(); it.next())
            {
                Console.WriteLine(it.currentItem().nome);
            }
        }
    }
}