using System;
using System.Collections.Generic;

// Define um namespace chamado MonolithicTodoApp para organizar o código
namespace MonolithicTodoApp
{
    //classe principal que contém o método Main (ponto de entrada do programa), onde a execução da aplicação começa.
    class Program
    {
        // Lista que armazenará as tarefas
        static List<string> tasks = new List<string>();

        //Método principal e ponto de entrada do programa, executado quando inicia a aplicação.
        static void Main(string[] args)
        {
            /* Este é um loop infinito, o que significa que a aplicação continuará rodando 
            * até que a opção de sair (Exit) seja escolhida. Dentro desse loop, o programa 
            * exibe o menu principal repetidamente e processa a entrada do usuário.
            */
            while (true)
            {
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        //Este método adiciona uma nova tarefa à lista de tarefas.
        static void AddTask()
        {
            Console.Write("Enter task description: ");
            var description = Console.ReadLine();
            tasks.Add(description);
            Console.WriteLine("Task added.");
        }

        //Lista todas as tarefas atualmente armazenadas na lista.
        static void ListTasks()
        {
            /*Se a lista estiver vazia (tasks.Count == 0), 
             * o método exibe uma mensagem informando que não há tarefas disponíveis e retorna sem fazer mais nada.*/
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            /* Itera por todas as tarefas na lista, exibindo cada uma com seu número correspondente. 
            * Isso facilita ao usuário identificar qual tarefa ele deseja remover.*/
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        //Remove uma tarefa da lista com base em seu número.
        static void RemoveTask()
        {
            /* Solicita ao usuário que insira o número da tarefa que deseja remover.
             * Tenta converter a entrada do usuário para um número inteiro.
             * Verifica se o número é válido (dentro do intervalo das tarefas disponíveis).
             * Se for válido, remove a tarefa correspondente da lista e confirma a remoção ao usuário.
             * Se não for válido, exibe uma mensagem de erro, indicando que a entrada foi inválida.*/
            Console.Write("Enter task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
