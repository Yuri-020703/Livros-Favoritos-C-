using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros_Favoritos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos livros favoritos você tem ? ");
            int n = int.Parse(Console.ReadLine());

            Livros[] vect =  new Livros[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = new Livros();

                Console.WriteLine("Digite os dados do Livro " + (i + 1));

                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                vect[i].SetTitulo(titulo);
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                vect[i].SetAutor(autor);
                Console.Write("Ano de lançamento: ");
                int ano = int.Parse(Console.ReadLine());
                vect[i].SetAno(ano);
                Console.Write("Número de páginas: ");
                int pag = int.Parse(Console.ReadLine());
                vect[i].SetPaginas(pag);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Veja os dados dos seus livros favoritos: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
