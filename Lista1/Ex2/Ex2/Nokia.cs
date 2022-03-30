using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Nokia : CelularFactory
    {
        public override Celular CreateCelular(TipoCelular tipoCelular)
        {
            Celular celular = null;
            if (tipoCelular == tipoCelular.Celular)
            {

                celular = new Celular("Nokia",tipoCelular.Nokia, tipoBateria.Nokia );
            }
        }
    }
}
