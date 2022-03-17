using Biblioteca.Classes;
using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("A Menina Que Roubava Livros", 500);
            Livro livro2 = new Livro("O Universo Numa Casca de Noz", 200);

            Leitor leitor = new Leitor("Felipe", livro2);
            leitor.adicionarLivro(livro1);

            livro1.adicionarPaginasLidas(27);
            livro2.adicionarPaginasLidas(52);
            exibir();

            Console.WriteLine("Alterando Paginas Lidas ...");
            livro1.adicionarPaginasLidas(37);
            livro2.adicionarPaginasLidas(47);
            exibir();


            Console.WriteLine($"Removendo {livro1.titulo}...");
            leitor.removerLivro(livro1);
            exibir();


            void exibir()
            {
                Console.WriteLine($"Situação dos Livros do Leitor {leitor.nome}");
                Console.WriteLine($"Quantidades de Livros {leitor.estanteLivros.Count}");
                Console.WriteLine($"Progresso {livro1.titulo}: {livro1.verificarProgresso()}%");
                Console.WriteLine($"Progresso {livro2.titulo}: {livro2.verificarProgresso()}%");
                Console.WriteLine();

            }
        }


    }
}
