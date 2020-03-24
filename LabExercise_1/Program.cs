using System;
using System.Linq;

namespace LabExercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author matija = new Author("Matija", "Biškup");
            Author andrej = new Author("Andrej", "Plenković");

            Note error = new Note();
            Note report = new Note(matija);
            Note warning = new Note("Stay home!", andrej, 2);
            Console.WriteLine(error.ToString());
            Console.WriteLine(report.ToString());
            Console.WriteLine(warning.ToString());

            TimedNote directive = new TimedNote("Stay positive!", matija, 3);
            TimedNote forecast = new TimedNote();
            Console.WriteLine(directive.ToString());
            Console.WriteLine(forecast.ToString());

            ToDo ToDo = new ToDo();
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            String surname = Console.ReadLine();
            Author user = new Author(name, surname);
            bool taskAdded = true;
            while (taskAdded)
            {
                Console.WriteLine("Enter task text (no letter input stops adding tasks): ");
                String input = Console.ReadLine();
                bool containsLetter = input.Any(x => char.IsLetter(x));
                if (containsLetter)
                {                    
                    String taskText = input;                    
                    int taskImportance;
                    do
                    {
                        Console.WriteLine("Enter task importance (number): ");
                        input = Console.ReadLine();
                    }
                    while (!Int32.TryParse(input, out taskImportance));
                    Note task = new Note(taskText, user, taskImportance);
                    ToDo.Add(task);
                }
                else
                {
                    taskAdded = false;
                }
            }
            Console.WriteLine(ToDo.ToString());
            ToDo.CompleteHighestPriority();
            Console.WriteLine(ToDo.ToString());
        }
    }
}
