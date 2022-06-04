using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class RoboControle
    {
        public Queue<RoboCommand> Comandos;
        private Stack<RoboCommand> _desfazerPilha;

        public RoboControle()
        {
            Comandos = new Queue<RoboCommand>();
            _desfazerPilha = new Stack<RoboCommand>();
        }

        public void ExecutarComandos()
        {
            Console.WriteLine("EXTECUTANDO COMANDO(S).");

            while (Comandos.Count > 0)
            {
                RoboCommand comando = Comandos.Dequeue();
                comando.Executar();
                _desfazerPilha.Push(comando);

            }
        }

        public void DesfazerComandos(int numComandosDesfazer)
        {
            Console.WriteLine("DESFAZENDO {0} COMANDO(S).", numComandosDesfazer);

            while (numComandosDesfazer > 0 && _desfazerPilha.Count > 0)
            {
                RoboCommand comand = _desfazerPilha.Pop();
                comand.Desfazer();
                numComandosDesfazer--;
            }
        }
    }
}
