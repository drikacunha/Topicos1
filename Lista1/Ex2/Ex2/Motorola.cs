namespace Ex2
{
    internal class Motorola : Celular
    {
        public Motorola()
        {
            Bateria = new BateriaMotorola();
            Camera = new CameraMotorola();
            Gps = new GpsMotorola();
        }
    }
}
