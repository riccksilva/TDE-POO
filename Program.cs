using System;
using TDEPOO;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        int opcao = 0;

        do
        {
            Console.Clear();
            opcao = MenuLib();

            switch (opcao)
            {
                case 1:
                    biblioteca.RegistrarLivro();
                    Pausar();
                    break;
                case 2:
                    biblioteca.ListaLivros();
                    Pausar();
                    break;
                case 3:
                    biblioteca.RemoverLivro();
                    Pausar();
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, por favor tente novamente.");
                    Pausar();
                    break;
            }

        } while (opcao != 4);
    }

    static int MenuLib()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Bem-vindo ao Sistema de Cadastro de Livros");
        Console.WriteLine("-------------------------------------------------\n");
        Console.WriteLine("1 - Cadastrar Livro");
        Console.WriteLine("2 - Exibir Todos os Livros");
        Console.WriteLine("3 - Remover Livro");
        Console.WriteLine("4 - Sair\n");
        Console.WriteLine("-------------------------------------------------");
        Console.Write("Digite sua opção: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            return opcao;
        }

        return -1;
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }
}
