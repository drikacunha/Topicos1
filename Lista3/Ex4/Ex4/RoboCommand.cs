using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public abstract class RoboCommand
    {
        protected Robo _robo;

        public RoboCommand(Robo robo)
        {
            _robo = robo;
        }

        public abstract void Executar();
        public abstract void Desfazer();


    }
}

