namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            MoedaChain moedas = new Euro();
            moedas.setNext(new Dollar());
            moedas.setNext(new Real());
            moedas.setNext(new YuanC());

            moedas.converterMoeda(IDMoedas.Dollar, 20);
            moedas.converterMoeda(IDMoedas.Real, 10);
            moedas.converterMoeda(IDMoedas.YuanChines, 25);
        }
    }

}