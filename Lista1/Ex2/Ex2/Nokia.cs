namespace Ex2
{
    public class Nokia : CelularFactory
    {

        public override Celular CreateCelular(TipoCelular tipoCelular)
        {
            Celular celular = null;
            if (tipoCelular == tipoCelular.Celular)
            {

                celular = new Peças("Nokia", TipoBateria.Nokia, TipoCamera.Nokia, TipoGps.Nokia, TipoVisor.Nokia);
            }

            return celular;
        }
    }
}
