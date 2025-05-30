using Asana.Library.Models;
using Asana.Library.Services;
using System;

namespace Asana
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var toDoSvc = ToDoServiceProxy.Current;
            int choiceInt;
            do
            {
                Console.WriteLine("Choose a menu option:");
                Console.WriteLine("1. Create a ToDo");
                Console.WriteLine("2. List all ToDos");
                Console.WriteLine("3. List all outstanding ToDos");
                Console.WriteLine("4. Delete a ToDo");
                Console.WriteLine("5. Update a ToDo");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine() ?? "6";

                if (int.TryParse(choice, out choiceInt))
                {
                    switch (choiceInt)
                    {
                        case 1:
                            Console.Write("Name:");
                            var name = Console.ReadLine();
                            Console.Write("Description:");
                            var description = Console.ReadLine();

                            toDoSvc.CreateToDo(new ToDo
                            {
                                Name = name,
                                Description = description,
                                IsCompleted = false,
                                Id = 0
                            });
                            break;
                        case 2:
                            toDoSvc.DisplayToDos(true);
                            break;
                        case 3:
                            toDoSvc.DisplayToDos();
                            break;
                        case 4:
                            toDoSvc.DeleteToDo();
                            break;
                        case 5:
                            toDoSvc.UpdateToDo();
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("ERROR: Unknown menu selection");
                            break;
                    }
                } else
                {
                    Console.WriteLine($"ERROR: {choice} is not a valid menu selection");
                }

            } while (choiceInt != 6);

        }
    }
}