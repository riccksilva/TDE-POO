using System;
using System.Collections.Generic;
using TDEPOO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDEPOO 
{ 
    public class Biblioteca
{
    private List<Livros> livros = new List<Livros>();

    public void RegistrarLivro()
    {
        Console.Clear();
        Console.WriteLine("--- Cadastro de Novo Livro ---");

        string titulo = LerEntradaString("Digite o título do livro:");
        string autor = LerEntradaString("Digite o autor do livro:");
        string dataPub = LerEntradaString("Digite a data de publicação do livro (ex: DD/MM/AAAA):");
        string categoria = LerEntradaString("Digite a categoria do livro:");
        int paginas = LerEntradaInt("Digite o número de páginas do livro:");

        Livros novoLivro = new Livros(titulo, autor, dataPub, categoria, paginas);
        livros.Add(novoLivro);

        Console.WriteLine("\nLivro registrado com sucesso!");
    }

    public void ListaLivros()
    {
        Console.Clear();
        Console.WriteLine("--- Lista de Livros Cadastrados ---");

        if (livros.Count == 0)
        {
            Console.WriteLine("\nNenhum livro cadastrado ainda.");
            return;
        }

        foreach (var livro in livros)
        {
            livro.ExibirLivro();
            Console.WriteLine("-----------------------------------");
        }
    }

    public void RemoverLivro()
    {
        Console.Clear();
        Console.WriteLine("--- Remover Livro ---");

        if (livros.Count == 0)
        {
            Console.WriteLine("\nNenhum livro para remover.");
            return;
        }

        Console.WriteLine("\nSelecione o número do livro que deseja remover:");

        for (int i = 0; i < livros.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {livros[i].Titulo}");
        }
        Console.WriteLine("-----------------------------------");
        Console.Write("Digite sua opção: ");

        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= livros.Count)
        {
            string tituloRemovido = livros[indice - 1].Titulo;
            livros.RemoveAt(indice - 1);
            Console.WriteLine($"\nO livro '{tituloRemovido}' foi removido com sucesso!");
        }
        else
        {
            Console.WriteLine("\nOpção inválida. Nenhum livro foi removido.");
        }
    }

    private string LerEntradaString(string mensagem)
    {
        string entrada;
        do
        {
            Console.WriteLine(mensagem);
            entrada = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um valor.");
            }
        } while (string.IsNullOrWhiteSpace(entrada));
        return entrada;
    }

    private int LerEntradaInt(string mensagem)
    {
        int numero;
        Console.WriteLine(mensagem);
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, digite um número inteiro positivo:");
        }
        return numero;
    }
}
}
