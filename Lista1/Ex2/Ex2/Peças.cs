namespace Ex2
{
    public class PeçasBuilder 
    {
        public override void buildCelular()
        {
            Celulares.celular = "Celular";
        }

        public override void buildBateria(string bateria)
        {
            Fabrica.bateria = bateria;
        }
        public override void buildCamera(string camera)
        {
            Fabrica.camera = camera;
        }
        public override void buildGps(string gps)
        {
            Fabrica.gps = gps;
        }
        public override void buildVisor(string visor)
        {
            Fabrica.visor = visor;
        }
    }
}
