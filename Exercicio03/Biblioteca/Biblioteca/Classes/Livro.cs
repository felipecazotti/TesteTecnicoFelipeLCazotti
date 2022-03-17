using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Classes
{
    public class Livro
    {
        public string titulo;
        public int qtdPaginas;
        public int paginasLidas;

        public Livro(string titulo, int qtdPaginas, int paginasLidas = 0)
        {
            this.titulo = titulo;
            this.qtdPaginas = qtdPaginas;
            this.paginasLidas = paginasLidas;
        }

        public double verificarProgresso()
        {
            double progresso = (double)paginasLidas / qtdPaginas * 100;
            return Math.Round(progresso);
        }

        public int adicionarPaginasLidas(int paginasLidas)
        {
            this.paginasLidas += paginasLidas;
            return paginasLidas;
        }
    }
}
