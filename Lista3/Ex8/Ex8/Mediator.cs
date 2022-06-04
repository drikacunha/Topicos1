using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public interface Mediator
    {
        void enviar(String mensagem, Colleague colleague);
    }
}
