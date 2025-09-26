using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDEPOO

    {
        internal class Livros
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string DataPub { get; set; }
            public string Categoria { get; set; }
            public int NumPagina { get; set; }

            public Livros() { }

            public Livros(string titulo, string autor, string dataPub, string categoria, int numPagina)
            {
                Titulo = titulo;
                Autor = autor;
                DataPub = dataPub;
                Categoria = categoria;
                NumPagina = numPagina;
            }

            public void ExibirLivro()
            {
                Console.WriteLine($"Título: {Titulo}");
                Console.WriteLine($"Autor: {Autor}");
                Console.WriteLine($"Data de Publicação: {DataPub}");
                Console.WriteLine($"Categoria: {Categoria}");
                Console.WriteLine($"Número de Páginas: {NumPagina}");
            }
        }
    }