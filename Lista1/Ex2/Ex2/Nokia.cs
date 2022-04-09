namespace Ex2
{
    public class Nokia : Celular
    {
        public Nokia()
        {
            Descricao = "NOKIA";
            Bateria = new BateriaNokia();
            Camera = new CameraNokia();
            Gps = new GpsNokia();
            Visor = new VisorNokia();

        }
        
    }
}
