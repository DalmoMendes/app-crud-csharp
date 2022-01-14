using System;
using static AgendaContatos.Controller;

namespace AgendaContatos
{
    class Program
    {
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContato();
                        break;
                    case "2":
                        InserirContato();
                        Console.Clear();
                        break;
                    case "3":
                        AtualizarContato();
                        Console.Clear();
                        break;
                    case "4":
                        ExcluirContato();
                        Console.Clear();
                        break;
                    case "5":
                        VisualizarContato();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("     Até logo!");
            Console.ReadLine();
    
        }

        // Métodos --------------------------------------------> Ações do Usuário na Tela
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Agenda de Contatos!!!");
            Console.WriteLine("     Menu de Opções:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     1- Listar");
            Console.WriteLine("     2- Novo");
            Console.WriteLine("     3- Atualizar");
            Console.WriteLine("     4- Excluir");
            Console.WriteLine("     5- Visualizar");
            Console.WriteLine("     C- Limpar Tela");
            Console.WriteLine("     X- Sair");
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("     Agenda de Contatos - 1.0");
            Console.WriteLine("     by Dalmo Mendes - dalmomendes.github.io");
            Console.WriteLine("-----------------<><>-------------------");
            Console.WriteLine("     Digite aqui: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
