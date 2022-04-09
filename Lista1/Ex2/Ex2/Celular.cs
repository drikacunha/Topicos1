namespace Ex2
{
    public abstract class Celular
    {

        public string Descricao { get; set; }
        public TipoBateria Bateria { get; set; }
        public TipoCamera Camera { get; set; }
        public TipoGps Gps { get; set; }
        public TipoVisor Visor { get; set; }

        public Celular() { }

        public Celular(string tipoCelular, TipoBateria tipoBateria, TipoCamera tipoCamera, TipoGps tipoGps, TipoVisor tipoVisor)
        {
            Descricao = tipoCelular;
            Bateria = tipoBateria;
            Camera = tipoCamera;
            Gps = tipoGps;
            Visor = tipoVisor;
        }
        public override string ToString()
        {
            return $"{Descricao}: {Bateria}, {Camera}, {Gps}, {Visor}";
        }
    }
}
