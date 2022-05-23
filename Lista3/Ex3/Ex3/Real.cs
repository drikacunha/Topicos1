using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Real : MoedaChain
    {
        public Real() : base(IDMoedas.Real) { }
        protected override void converteMoeda(double valor)
        {
            double resultado = valor * 6.6;
            Console.WriteLine(valor + " em Euro para Real é R$ " + resultado.ToString("00.00"));
        }
    }
}
