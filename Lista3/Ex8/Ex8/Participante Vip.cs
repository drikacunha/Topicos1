using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public class ParticipanteVip : Colleague
    {
        public ParticipanteVip(Mediator m): base(m) { }
        int count = 0;

        public override void receberMensagem(string mensagem)
        {

            if (count < 2)
            {
                Console.WriteLine("Chat -  " + mensagem);
                count++;
            }
            else
            {
                Console.WriteLine("Chat - Parcipante Simples: Não pode mais enviar Mensagem");
                count = 0;
            }


        }
    }
}
