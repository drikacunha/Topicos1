using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Diplomacia : Estrategia
    {
        public void atacar()
        {
            recuarTropas();
            proporCooperaçao();
        }

        private void proporCooperaçao()
        {
            throw new NotImplementedException();
        }

        private void recuarTropas()
        {
            throw new NotImplementedException();
        }

        public void concluir()
        {
            desarmarInimigo();
        }

        private void desarmarInimigo()
        {
            throw new NotImplementedException();
        }

        public void iniciar()
        {
            throw new NotImplementedException();
        }
    }
}
