using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public interface Iterator
    {
        void first();
        void next();
        Boolean isDone();
        Livro currentItem();
    }
}
