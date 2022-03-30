using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal abstract class CelularFactory
    {
        public Celular MontarCelular(TipoCelular tipoCelular)
        {
            Celular celular = null;
            celular = CreateCelular(tipoCelular);
            if (celular != null)
            {
                Console.WriteLine(celular.MontarCelular());
            }

            return celular;

        }

        public abstract Celular CreateCelular(TipoCelular tipoCelular);
    }
}
