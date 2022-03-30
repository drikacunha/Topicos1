using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public abstract class Celular
    {
                public string Celular { get; set; }
                public TipoBateria Bateria { get; set; }
                public TipoCamera  Camera { get; set; }
                public TipoGps     Gps { get; set; }
                public TipoVisor   Visor{ get; set; } 
       
       public Celular()
       { 
       }
       public Celular(TipoCelular tipoCelular, TipoBateria tipoBateria, TipoCamera tipoCamera, TipoGps tipoGps, TipoVisor tipoVisor)
         {
         Celular = tipoCelular;
         Bateria = tipoBateria;
         Camera = tipoCamera;
         Gps = tipoGps;
         Visor = tipoVisor;
        }
       public string MontarCelular()
         {
        return "Montar Celular";   
        }
    }
}
