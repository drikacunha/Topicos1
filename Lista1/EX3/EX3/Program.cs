namespace Ex3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomNumberGenerato b1 =  RandomNumberGenerato.GetRandomNumberGenerato();
            RandomNumberGenerato b2 =  RandomNumberGenerato.GetRandomNumberGenerato();
            RandomNumberGenerato b3 =  RandomNumberGenerato.GetRandomNumberGenerato();
            RandomNumberGenerato b4 =  RandomNumberGenerato.GetRandomNumberGenerato();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {

                Console.WriteLine(" Sortei dos Jogos do Cassino sao: \n");
            }

            RandomNumberGenerato balancer = RandomNumberGenerato.GetRandomNumberGenerato();
            for (int i = 0; i < 15; i++)
            {
                string jogos = balancer.Jogos;
                Console.WriteLine("Jogo:" + jogos);
            }

            Console.ReadKey();

        }
    }
}

