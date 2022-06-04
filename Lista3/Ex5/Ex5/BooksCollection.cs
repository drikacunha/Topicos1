using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class BooksCollection : IContainer
    {
        protected List<Livro> livros;

        public BooksCollection()
        {
            livros = new List<Livro>
            {
                new Livro("\n LISTA DE LIVROS \n"),
                new Livro("\n A Saga Crepúsculo"),
                new Livro("\n 50 tons de cinza"),
                new Livro("\n Harry potter")
            };
        }

        public BookIterator criarIterator()
        {
            return new BookIterator(livros);
        }
    }
}
