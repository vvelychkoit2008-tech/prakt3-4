using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть завдання (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1.Run();
                break;
            case 2:
                Task2.Run();
                break;
            case 3:
                Task3.Run();
                break;
            default:
                Console.WriteLine("Невірний вибір!");
                break;
        }

        Console.ReadKey();
    }
}
