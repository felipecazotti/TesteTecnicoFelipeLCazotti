using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Classes
{
    public class Leitor
    {
        public string nome;
        public Livro livroFavorito; 
        public List<Livro> estanteLivros = new List<Livro>();

        public Leitor(string nome, Livro livroFavorito)
        {
            this.nome = nome;
            this.livroFavorito = livroFavorito;
            estanteLivros.Add(livroFavorito);
        }

        public void adicionarLivro(Livro livro)
        {
            estanteLivros.Add(livro);
        }

        public void removerLivro(Livro livro)
        {
            livro.paginasLidas = 0;
            estanteLivros.Remove(livro);
        }
    }
}
