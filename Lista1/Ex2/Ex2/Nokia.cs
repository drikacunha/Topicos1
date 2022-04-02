namespace Ex2
{
    public class Nokia : Celular
    {
        public Nokia()
        {
            Bateria = new BateriaNokia();
            Camera = new CameraNokia();
            Gps = new GpsMotorola();

        }
        
    }
}
