namespace Ex2
{
    internal class Motorola : Celular
    {
        public Motorola()
        {
            Descricao = "MOTOROLA";
            Bateria = new BateriaMotorola();
            Camera = new CameraMotorola();
            Gps = new GpsMotorola();
            Visor = new VisorMotorola();
    }
    }
}
