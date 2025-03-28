using System;

namespace ProjetoTarefas
{
    public class Menu
    {
        private TarefaService tarefaService = new TarefaService();

        public void Mostrar()
        {
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Deletar Tarefa");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        tarefaService.CriarTarefa(descricao);
                        break;
                    case "2":
                        tarefaService.ListarTarefas();
                        break;
                    case "3":
                        Console.Write("Digite o ID da tarefa: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                            tarefaService.DeletarTarefa(id);
                        else
                            Console.WriteLine("ID inválido.");
                        break;
                    case "0":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
