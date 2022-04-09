namespace Ex3
{ 

{
        static void Main(string[] args)
    {
        // Colocando em prática
        Sonteio _cadeira1 = Sorteio.Instance;
        _cadeira1.Quantidade = 1;

        Cadeira _cadeira2 = Sorteio.Instance;
        _cadeira2.Quantidade = 5;

        Console.WriteLine(_cadeira1.Quantidade.ToString());
        Console.WriteLine(_cadeira2.Quantidade.ToString());
        Console.ReadLine();
    }
}


