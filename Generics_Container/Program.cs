using System;

namespace Generics_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            StringContainer stringContainer = new StringContainer();
            stringContainer.Add("привет");
            stringContainer.Add("мир");

            Console.WriteLine("StringContainer с [\"привет\", \"мир\"], PrintAllUpper():");
            stringContainer.PrintAllUpper();

            Console.WriteLine();
            CountingContainer<int> intCounter = new CountingContainer<int>();
            intCounter.Add(10);
            intCounter.Add(20);
            intCounter.Add(30);
            Console.WriteLine($"CountingContainer<int>, три вызова Add -> Count == {intCounter.Count}, TotalAdded == {intCounter.TotalAdded}");

            CountingContainer<string> stringCounter = new CountingContainer<string>();
            stringCounter.Add("тест1");
            stringCounter.Add("тест2");
            Console.WriteLine($"CountingContainer<string>, два вызова Add -> Count == {stringCounter.Count}, TotalAdded == {stringCounter.TotalAdded} (независимо от предыдущего экземпляра)");

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим работы с контейнером строк ===");

            StringContainer userContainer = new StringContainer();

            while (true)
            {
                try
                {
                    Console.Write("Введите строку для добавления (или 'stop' для завершения): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "stop")
                    {
                        break;
                    }

                    userContainer.Add(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (userContainer.Count > 0)
            {
                Console.WriteLine("\n--- Вывод всех добавленных строк в верхнем регистре ---");
                userContainer.PrintAllUpper();
            }
            else
            {
                Console.WriteLine("Контейнер остался пустым.");
            }
        }
    }
}