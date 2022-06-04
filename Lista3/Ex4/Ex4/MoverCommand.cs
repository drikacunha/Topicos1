using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class MoverCommand : RoboCommand
    {
        public int ParaFrente { get; set; }
        public MoverCommand(Robo robo) : base(robo) { }

        public override void Desfazer()
        {
            _robo.Mover(-ParaFrente);
        }

        public override void Executar()
        {
            _robo.Mover(ParaFrente);
        }


    }
}
