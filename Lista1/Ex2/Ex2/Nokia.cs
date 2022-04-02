namespace Ex2
{
    public class Nokia : Celular
    {
        public Nokia()
        {
            Bateria = new BateriaMotorola();
            Camera = new CameraMotorola();
            Gps = new GpsMotorola();
            Visor = new VisorMotorola();

        }
        
    }
}
