using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public sealed class Cassino
    {
        private static readonly Cassino instace = new Cassino();
        
        public string Descricao { get; set; }
        public TipoRoleta Roleta { get; set; }
        public TipoBlackJack BlackJack { get; set; }
        public TipoPôquer Pôquer { get; set; }


        private Cassino() { }
        public static Cassino Instance
        {
            get
            {
                return instace;
            }
        }
     }
 }