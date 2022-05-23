using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Dollar : MoedaChain
    {
        public Dollar() : base(IDMoedas.Dollar) { }

        protected override void converteMoeda(double valor)
        {
            double resultado = valor * 1.17;
            Console.WriteLine(valor + " em Euro para dolar é $ " + resultado);
        }
    }
}
