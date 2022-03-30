using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Peças : Celular
    {
        public Peças(string fabrica) : base ()
        {
            Descricao = " Marca do Celular " + fabrica;
        }
        public Peças(string fabrica, TipoCelular tipoCelular, TipoBateria tipoBateria, TipoCamera tipoCamera, TipoGps tipoGps, TipoVisor tipoVisor)
        {
            Descricao = "Marca do Celular" + fabrica;          
        }
    }
}
