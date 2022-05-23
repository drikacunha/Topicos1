using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Euro : MoedaChain
    {
        public Euro() : base(IDMoedas.Euro) { }

        protected override void converteMoeda(double valor)
        {
            Console.WriteLine(valor + " já está em Euro");
        }
    }
}
