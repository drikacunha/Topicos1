using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Inimigo
    {
        Nuclear Tipo_guerra;
        GrandeExercito Tipo_exercito;
        Fragil Tipo_fragil;

        public void executarNuclear() {
            Tipo_guerra = new Nuclear();
            Tipo_exercito = new GrandeExercito();
            Tipo_fragil = new Fragil();
         }

        public void executarTipo() {


}
