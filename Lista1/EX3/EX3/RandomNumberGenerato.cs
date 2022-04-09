namespace Ex3
{
    public class RandomNumberGenerato
    {
        static RandomNumberGenerato instance;
        List<string> jogos = new List<string>();
        Random random = new Random();

        private static object locker = new object();
        protected RandomNumberGenerato()
        {
            jogos.Add("Roleta");
            jogos.Add("Pôquer");
            jogos.Add("Blackjack");
            jogos.Add("Bingo");
        }

        public static RandomNumberGenerato GetRandomNumberGenerato()
        {
            if (instance == null)
            {

                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RandomNumberGenerato();
                    }
                }
            }

            return instance;
        }

        public string Jogos 
        {
            get 
            {
              int r = random.Next(jogos.Count);
                return jogos[r].ToString();
            
            }
        
        }
    }
}
