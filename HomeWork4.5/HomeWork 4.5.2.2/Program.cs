using HomeWork_4;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        List<Team> teams = new List<Team>();
        Console.OutputEncoding = UTF8Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1 - Додати нову команду");
            Console.WriteLine("2 - Додати співробітника до команди");
            Console.WriteLine("3 - Вивести інформацію про команду");
            Console.WriteLine("4 - Вивести детальну інформацію про команду");
            Console.WriteLine("5 - Вийти");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Уведіть назву нової команди: ");
                    string teamName = Console.ReadLine();
                    teams.Add(new Team(teamName));
                    Console.WriteLine($"Команда {teamName} додана.\n");
                    break;

                case "2":
                    if (teams.Count == 0)
                    {
                        Console.WriteLine("Спочатку створіть команду.\n");
                        break;
                    }
                    Console.Write("Оберіть команду: ");
                    for (int i = 0; i < teams.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {teams[i].TeamName}");
                    }
                    int teamIndex = int.Parse(Console.ReadLine()) - 1;

                    Console.Write("Уведіть ім'я співробітника: ");
                    string workerName = Console.ReadLine();

                    Console.WriteLine("Оберіть роль співробітника: ");
                    Console.WriteLine("1 - Розробник");
                    Console.WriteLine("2 - Менеджер");
                    string workerType = Console.ReadLine();

                    Worker worker = null;
                    switch (workerType)
                    {
                        case "1":
                            worker = new Developer(workerName);
                            break;
                        case "2":
                            worker = new Manager(workerName);
                            break;
                    }

                    Console.Write("Введіть кількість годин робочого дня: ");
                    worker.WorkDay = int.Parse(Console.ReadLine());

                    teams[teamIndex].AddWorker(worker);
                    Console.WriteLine($"Співробітник {workerName} доданий до команди {teams[teamIndex].TeamName}.\n");
                    break;

                case "3":
                    if (teams.Count == 0)
                    {
                        Console.WriteLine("Спочатку створіть команду.\n");
                        break;
                    }
                    Console.Write("Оберіть команду: ");
                    for (int i = 0; i < teams.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {teams[i].TeamName}");
                    }
                    teamIndex = int.Parse(Console.ReadLine()) - 1;
                    teams[teamIndex].ShowTeamInfo();
                    Console.WriteLine();
                    break;

                case "4":
                    if (teams.Count == 0)
                    {
                        Console.WriteLine("Спочатку створіть команду.\n");
                        break;
                    }
                    for (int i = 0; i < teams.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {teams[i].TeamName}");
                    }
                    teamIndex = int.Parse(Console.ReadLine()) - 1;
                    teams[teamIndex].ShowDetailedTeamInfo();
                    Console.WriteLine();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Невірна команда. Спробуйте ще раз.\n");
                    break;
            }
        }
    }
}