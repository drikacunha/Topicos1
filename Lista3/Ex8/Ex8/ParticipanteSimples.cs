using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public class ParticipanteSimples : Colleague
    {   
        public ParticipanteSimples(Mediator m) : base(m) { }

        int count = 0;

        public override void receberMensagem(string mensagem)
        {
       
            Console.WriteLine("Chat -  " + mensagem);
        }
    }
}
