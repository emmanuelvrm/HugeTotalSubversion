using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTarefas
{
    public class TarefaService
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int proximoId = 1;

        public void CriarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa { Id = proximoId++, Descricao = descricao };
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        public void ListarTarefas()
        {
            Console.WriteLine("\n--- Lista de Tarefas ---");
            if (!tarefas.Any())
                Console.WriteLine("Nenhuma tarefa encontrada.");
            else
                tarefas.ForEach(t => Console.WriteLine($"ID: {t.Id} - {t.Descricao}"));
        }

        public void DeletarTarefa(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
}
