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

        private void iniciarPeloSul()
        {
            throw new NotImplementedException();
        }

        private void iniciarPeloNorte()
        {
            throw new NotImplementedException();
        }

        public void concluir()
        {
            dividirBeneficios();
            dividirReconstruçao();
        }

        private void dividirReconstruçao()
        {
            throw new NotImplementedException();
        }

        private void dividirBeneficios()
        {
            throw new NotImplementedException();
        }
    }
}
