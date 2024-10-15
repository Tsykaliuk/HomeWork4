using HomeWork4._2;
using System;
using System.Text;

namespace HomeWork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть курс долара до гривні:");
            decimal usdToUah = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введіть курс євро до гривні:");
            decimal eurToUah = decimal.Parse(Console.ReadLine());

            Converter converter = new Converter(usdToUah, eurToUah);

            while (true)
            {
                Console.WriteLine("\nОберіть операцію:");
                Console.WriteLine("1 - Конвертувати гривні в долари");
                Console.WriteLine("2 - Конвертувати гривні в євро");
                Console.WriteLine("3 - Конвертувати долари в гривні");
                Console.WriteLine("4 - Конвертувати євро в гривні");
                Console.WriteLine("5 - Вийти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть суму в гривнях: ");
                        decimal amountInUah = decimal.Parse(Console.ReadLine());
                        decimal usd = converter.ConvertHrnToDollar(amountInUah);
                        decimal value = Math.Round(usd, 2);
                        Console.WriteLine($"{amountInUah} грн = {value} доларів");
                        break;

                    case "2":
                        Console.Write("Введіть суму в гривнях: ");
                        amountInUah = decimal.Parse(Console.ReadLine());
                        decimal eur = converter.ConvertHrnToEuro(amountInUah);
                        value = Math.Round(eur, 2);
                        Console.WriteLine($"{amountInUah} грн = {value} євро");
                        break;

                    case "3":
                        Console.Write("Введіть суму в доларах: ");
                        decimal amountInUsd = decimal.Parse(Console.ReadLine());
                        decimal uahFromUsd = converter.ConvertDollarToHrn(amountInUsd);
                        value = Math.Round(uahFromUsd, 2);
                        Console.WriteLine($"{amountInUsd} доларів = {value} грн");
                        break;

                    case "4":
                        Console.Write("Введіть суму в євро: ");
                        decimal amountInEur = decimal.Parse(Console.ReadLine());
                        decimal uahFromEur = converter.ConvertEuroToHrn(amountInEur);
                        value = Math.Round(uahFromEur, 2);
                        Console.WriteLine($"{amountInEur} євро = {value} грн");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}