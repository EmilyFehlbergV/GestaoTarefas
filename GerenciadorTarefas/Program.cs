namespace GerenciadorTarefas;

class Program
{
    private static List<string> tarefas = [];
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();
            string opcaoUsuario = Console.ReadLine();

            switch (opcaoUsuario)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    BuscarTarefa();
                    break;
                case "4":
                    Sair();
                   break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
                    
            }

            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void AdicionarTarefa()
    {
        Console.Write("Digite uma tarefa: ");
        string novaTarefa = Console.ReadLine();

        if (string.IsNullOrEmpty(novaTarefa))
        {
            Console.WriteLine("A tarefa não foi adicionada pois está vazia!");
        }
        else
        {
                
            tarefas.Add(novaTarefa);
            Console.WriteLine($"Tarefa cadastrada com sucesso!");
            
        }
      
    }

    private static void ListarTarefas()
    {
        if (tarefas.Count < 1)
        {
            Console.WriteLine("Não há tarefas cadastradas.");
        }
        else
        {
            Console.WriteLine("\n---- Suas tarefas ----");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"{tarefa}");
            }
        }
        Console.WriteLine();
    }

    private static void BuscarTarefa()
    {
        Console.WriteLine("Digite o termo a ser buscado: ");
        
        var palavraChave =  Console.ReadLine();
        bool encontrado = false; // auxiliar pra identificar se o termo foi ou não encontrado
        
        foreach (var tarefa in tarefas)
        {
            if (tarefa.Contains(palavraChave, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"- {tarefa}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Termo não encontrado!");
        }
    }

    private static void Sair()
    {
        Console.WriteLine("Saindo do programa...");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }


    static void ExibirMenu()
    {
        Console.WriteLine("1 - Adicionar nova tarefa");
        Console.WriteLine("2 - Listar todas as tarefas");
        Console.WriteLine("3 - Buscar tarefa por palavra-chave");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("Escolha sua opção: ");
         
        
    }
}

