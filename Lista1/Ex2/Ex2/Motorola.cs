using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Motorola : CelularFactory
    {
        public override Celular CreateCelular(TipoCelular tipoCelular)
        {
            Celular celular = null;
            if (tipoCelular == tipoCelular.Celular)
            {

                celular = new Peças("Nokia", TipoBateria.Motorola, TipoCamera.Motorola, TipoGps.Motorola, TipoVisor.Motorola);
            }

            return celular;
        }
    }
}
