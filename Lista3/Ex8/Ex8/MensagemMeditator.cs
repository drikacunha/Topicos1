using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class MensagemMeditator : Mediator
    {

        protected List<Colleague> contatos;

        public MensagemMeditator()
        {
            contatos = new List<Colleague>(); 
        }

        public void adicionarColleague(Colleague colleague)
        {
            contatos.Add(colleague);
        }

        public void enviar(string mensagem, Colleague colleague)
        {
            foreach(Colleague contato in contatos)
            {
                if(contato != colleague)
                {
                    definirProtocolo(contato);
                    contato.receberMensagem(mensagem);
                }
            }
        }

        private void definirProtocolo(Colleague contato)
        {
            if(contato.GetType() == typeof(ParticipanteVip))
            {
                Console.WriteLine("*Simples*");
            } 
            else if(contato.GetType() == typeof(ParticipanteSimples))
            {
                Console.WriteLine("*VIP*");
            }
        }
    }
}
