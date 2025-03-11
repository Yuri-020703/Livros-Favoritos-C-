using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros_Favoritos
{
    internal class Livros
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Ano { get; private set; }
        public int Páginas { get; private set; }

        public void SetTitulo(string x)
        {
            Titulo = x;
        }

        public void SetAutor(string x)
        {
            Autor = x;
        }

        public void SetAno(int x)
        {
            Ano = x;
        }

        public void SetPaginas(int x)
        {
            Páginas = x;
        }

        public override string ToString()
        {
            return "Título: " + Titulo + ", Autor: " + Autor + ", Ano de lançamento: " + Ano + ", Número de páginas: " + Páginas;
        }
    }
}
