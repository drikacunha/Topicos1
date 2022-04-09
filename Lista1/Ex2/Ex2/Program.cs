namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular motorola = new Motorola();
            Celular nokia = new Nokia();
            Celular apple = new Apple();

            List<Celular> lista = new() { motorola, apple, nokia};

            lista.ForEach(c =>
            {
                Console.WriteLine("Celular Motorola");
               

                Console.WriteLine($"  {c.Bateria.Descricao}:  {c.Gps.Descricao}:  {c.Visor.Descricao}:  {c.Camera.Descricao}  ");
            });



        }
    }
}
