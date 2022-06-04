using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Robo
    {
        public void Mover(int ParaFrente)
        {
            if (ParaFrente > 0)
                Console.WriteLine("O Robo foi movimentado para frente {0}mm.", ParaFrente);
            else
                Console.WriteLine("O Robo foi movimentado para trás {0}mm.", -ParaFrente);
        }

        public void RotacionarParaEsquerda(double rotacionarParaEsquerda)
        {
            if (rotacionarParaEsquerda > 0)
                Console.WriteLine("O Robo foi rotacionado para esquerda {0} graus", rotacionarParaEsquerda);
            else
                Console.WriteLine("O Robo foi rotacionado para direita {0} graus", -rotacionarParaEsquerda);
        }

        public void Escavar(bool paraCima)
        {
            if (paraCima)
                Console.WriteLine("O Robo colheu material do solo");
            else
                Console.WriteLine("O Robo despejou o material colhido");
        }
    }
}