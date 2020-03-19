using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task => {
                bool parsingSuccesful = float.TryParse(task.City.Population, out float population);
                parsingSuccesful &= float.TryParse(task.City.SickPercentage, out float sickPercentage);
                parsingSuccesful &= float.TryParse(task.Virus.KillProbability, out float killProbability);
                if (!parsingSuccesful) {
                    throw new ArgumentException("Wasn't able to parse all of the string parameters containing floats!");
                }

                float peopleInfected = MathF.Truncate(population * sickPercentage);
                float peopleDead = MathF.Truncate(peopleInfected * killProbability);

                return
                    $"There are {peopleInfected} people sick with {task.Virus.Name} in the city of {task.City.Name}, {peopleDead} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
