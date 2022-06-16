using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
       public abstract class DietInfo 
    {

        protected String NomeDietista;
        protected String DiaDieta;
        protected String Peso;

        public DietInfo(String NomeDietista, String DiaDieta, String Peso)
        {
            this.NomeDietista = NomeDietista;
            this.DiaDieta = DiaDieta;
            this.Peso = Peso;

        }
        public String NomeDietista()
        {
            return this.NomeDietista;
        }

        public String DiaDieta()
        {
            return this.DiaDieta;
        }

        public String Peso()
        {
            return this.Peso;
        }
    }
}
