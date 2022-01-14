using System;

namespace AgendaContatos
{
    public class Controller
    {

        static ContatoRepositorio repositorio = new ContatoRepositorio();
        // Métodos --------------------------------------------> Excluir
        public static void ExcluirContato()
        {
            Console.Write("     Digite o id do contato: ");
            int indiceContato = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceContato);
        }

        // Métodos --------------------------------------------> Visualizar
        public static void VisualizarContato()
        {
            Console.Write("");
            Console.Write("     Código do Contato: ");
            int indiceContato = int.Parse(Console.ReadLine());

            var contato = repositorio.RetornaPorId(indiceContato);

            Console.WriteLine(contato);
        }

        // Métodos --------------------------------------------> Atualizar
        public static void AtualizarContato()
        {
            Console.Write("     Código do contato: ");
            int indiceContato = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Grupo)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Grupo), i));
            }
            Console.Write("     Escolha o grupo entre as opções acima: ");
            int entradaGrupo = int.Parse(Console.ReadLine());

            Console.Write("     Nome do contato: ");
            string entradaNome = Console.ReadLine();

            Console.Write("     Fone do contato: ");
            string entradaFone = Console.ReadLine();

            Console.Write("     E-mail Contato: ");
            string entradaEmail = Console.ReadLine();

            Console.Write("     Web Contato: ");
            string entradaLink = Console.ReadLine();

            Contato atualizaContato = new Contato(id: indiceContato,
                                        grupo: (Grupo)entradaGrupo,
                                        nome: entradaNome,
                                        fone: entradaFone,
                                        email: entradaEmail,
                                        link: entradaLink);

            repositorio.Atualiza(indiceContato, atualizaContato);
        }

        // Métodos --------------------------------------------> Listar
        public static void ListarContato()
        {
            Console.WriteLine("     Listar contatos");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("     Nenhum contato cadastrado.");
                return;
            }

            foreach (var contato in lista)
            {
                var excluido = contato.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", contato.retornaId(), contato.retornaNome(), (excluido ? "*Excluído*" : ""));
            }
        }

        // Métodos --------------------------------------------> Insere
        public static void InserirContato()
        {
            Console.WriteLine("     Inserir novo contato");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Grupo)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Grupo), i));
            }
            Console.Write("     Escolha um Grupo entre as Opções: ");
            int entradaGrupo = int.Parse(Console.ReadLine());

            Console.Write("     Nome do contato: ");
            string entradaNome = Console.ReadLine();

            Console.Write("     Fone do contato: ");
            string entradaFone = Console.ReadLine();

            Console.Write("     E-mail Contato: ");
            string entradaEmail = Console.ReadLine();

            Console.Write("     Web Contato: ");
            string entradaLink = Console.ReadLine();

            Contato novoContato = new Contato(id: repositorio.ProximoId(),
                                        grupo: (Grupo)entradaGrupo,
                                        nome: entradaNome,
                                        fone: entradaFone,
                                        email: entradaEmail,
                                        link: entradaLink);

            repositorio.Insere(novoContato);
        }
    }
}
