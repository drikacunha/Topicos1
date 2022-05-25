using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class FiboCollection : IContainer
    {
        protected List<Fibonacci> fibonaccis;

        public FiboCollection()
        {
            fibonaccis = new List<Fibonacci> {
                new Fibonacci(0),
                new Fibonacci(1),
                new Fibonacci(1),
                new Fibonacci(2),
                new Fibonacci(3),
                new Fibonacci(5)
            };
        }

        public FiboIterator criarIterator()
        {
            return new FiboIterator(fibonaccis);
        }
    }
}
