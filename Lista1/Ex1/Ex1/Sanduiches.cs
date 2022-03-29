using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Sanduiches
    {
        public abstract class Sanduiches : Ingredientes
        {
            public Ingredientes orderIngredientes(string type)
            {
                Ingredientes ingredientes;

                ingredientes = createIngredientes(type);
                ingredientes.prepare(); //preparar
                ingredientes.bake(); //mortar
                ingredientes.cut(); //cortar
                ingredientes.box(); //colocar na caixa
                return ingredientes;
            }

            protected abstract Ingredientes createIngredientes(string type);
        }
    }
}