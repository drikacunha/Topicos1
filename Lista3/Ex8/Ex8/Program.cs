using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {

            MensagemMeditator mediador = new MensagemMeditator();

            ParticipanteSimples simples = new ParticipanteSimples(mediador);
            ParticipanteVip vip = new ParticipanteVip(mediador);

            mediador.adicionarColleague(simples);
            mediador.adicionarColleague(vip);

            simples.enviarMensagem("Oi eu sou participante simples");
            simples.enviarMensagem("Tudo bem?");
            simples.enviarMensagem("XD");
            vip.enviarMensagem("Olá eu sou parcipante Vip");
            vip.enviarMensagem("Tudo e vc?");
            vip.enviarMensagem("XD");
        }
    }
}
