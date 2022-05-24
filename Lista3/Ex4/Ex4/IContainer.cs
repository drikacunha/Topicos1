using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public interface IContainer
    {
        public BookIterator criarIterator();
    }
}
