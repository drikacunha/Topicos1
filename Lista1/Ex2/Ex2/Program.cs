namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular motorola = new Motorola();
            Celular nokia = new Nokia();
            Celular apple = new Apple();

            List<Celular> lista = new() { motorola};
            lista.ForEach(c =>
            {
                Console.WriteLine(" Celular da Motorola: ");
               

                Console.WriteLine($"  {c.Bateria.Descricao},  {c.Gps.Descricao},  {c.Visor.Descricao},  {c.Camera.Descricao}  ");
            });
            Console.WriteLine("");
            List<Celular> lista1 = new() { apple};
            lista1.ForEach(c =>
            {
                Console.WriteLine(" Celular da Apple: ");


                Console.WriteLine($"  {c.Bateria.Descricao},  {c.Gps.Descricao},  {c.Visor.Descricao},  {c.Camera.Descricao}  ");
            });
            Console.WriteLine("");
            List<Celular> lista2 = new() { nokia };
            lista2.ForEach(c =>
            {
                Console.WriteLine(" Celular da Nokia: ");


                Console.WriteLine($"  {c.Bateria.Descricao},  {c.Gps.Descricao},  {c.Visor.Descricao},  {c.Camera.Descricao}  ");
            });

        }
    }
}
