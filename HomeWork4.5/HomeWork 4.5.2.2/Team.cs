using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Team
    {
        public string TeamName { get; set; }
        private List<Worker> workers = new List<Worker>();

        public Team(string name)
        {
            TeamName = name;
        }
        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
        public void ShowTeamInfo()
        {
            Console.WriteLine($"Команда: {TeamName}");
            Console.WriteLine("Співробітники:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Name);
            }
        }
        public void ShowDetailedTeamInfo()
        {
            Console.WriteLine($"Команда: {TeamName}");
            Console.WriteLine("Детальна інформація про співробітників:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay} годин");
            }
        }
    }
}
