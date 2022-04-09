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
        public int Sorteio { get; set; }
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