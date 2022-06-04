using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class EscavarCommand : RoboCommand
    {
        public bool ColherMaterial { get; set; }
        public EscavarCommand(Robo robo) : base(robo) { }

        public override void Desfazer()
        {
            _robo.Escavar(!ColherMaterial);
        }

        public override void Executar()
        {
            _robo.Escavar(ColherMaterial);
        }
    }
}