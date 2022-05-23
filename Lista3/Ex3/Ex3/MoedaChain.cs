using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public abstract class MoedaChain
    {
        protected MoedaChain next;
        protected IDMoedas indentificadorDaMoeda;

        public MoedaChain(IDMoedas id)
        {
            next = null;
            indentificadorDaMoeda = id;
        }

        public void setNext(MoedaChain forma)
        {
            if (next == null)
                next = forma;
            else
                next.setNext(forma);
        }

        public void converterMoeda(IDMoedas id, int valor)
        {
            if (podeConverter(id))
                converteMoeda(valor);
            else
            {
                if (next == null)
                {
                    throw new Exception("Moeda não registrada");
                }
                next.converterMoeda(id, valor);
            }
        }

        protected abstract void converteMoeda(double valor);

        private Boolean podeConverter(IDMoedas id)
        {
            if (indentificadorDaMoeda == id)
            {
                return true;
            }
            else
                return false;
        }
    }
}
