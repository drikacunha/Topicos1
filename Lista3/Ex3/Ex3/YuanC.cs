using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class YuanC : MoedaChain
    {
        public YuanC() : base(IDMoedas.YuanChines) { }

        protected override void converteMoeda(double valor)
        {
            double resultado = valor * 7.47;
            Console.WriteLine(valor + " em Euro para Yuan Chinês é " + resultado + " ¥");
        }
    }
}
