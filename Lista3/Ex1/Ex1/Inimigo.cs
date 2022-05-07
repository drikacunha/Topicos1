using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Inimigo 
    {
        Estrategia acao;

        public void definirEstrategia()
        {
            if (inimigo.exercito() > 10000)
            {
                acao = new AliançaVizinho();

            }
            else if (inimigo.Nuclear())
            {
                acao = new Diplomacia();

            }
            else if (inimigo.Fragil())
            {
                acao = new AtacarSozinho();
            }
        }

        public void iniciarGuerra()
        {
            acao.iniciar();
        }

        public void encerrarGuerra()
        {
            acao.concluir();
        }
    }
} 
