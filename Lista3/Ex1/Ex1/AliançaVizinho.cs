using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class AliançaVizinho : Estrategia
    { 
        public void iniciar()
        {
            iniciarPeloNorte();
            iniciarPeloSul();
        }

        public void concluir()
        {
            dividirBeneficios();
            dividirReconstruçao();
        }
    }
}
