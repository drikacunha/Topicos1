using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class RotacionarCommand : RoboCommand
    {
        public double rotacionarParaEsquerda { get; set; }
        public RotacionarCommand(Robo robo) : base(robo) { }

        public override void Desfazer()
        {
            _robo.RotacionarParaEsquerda(-rotacionarParaEsquerda);
        }

        public override void Executar()
        {
            _robo.RotacionarParaEsquerda(rotacionarParaEsquerda);
        }
    }
}
