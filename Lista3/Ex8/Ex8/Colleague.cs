using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator m)
        {
            mediator = m;
        }

        public void enviarMensagem(String mensagem)
        {
            mediator.enviar(mensagem, this);
        }

        public abstract void receberMensagem(String mensagem);
    }
}
