using System;
using System.Collections.Generic;

namespace MonolithicTodoApp
{
    class Program
    {
        // Lista que armazenará as tarefas
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
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

        static void AddTask()
        {
            Console.Write("Enter task description: ");
            var description = Console.ReadLine();
            tasks.Add(description);
            Console.WriteLine("Task added.");
        }

        static void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void RemoveTask()
        {
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
