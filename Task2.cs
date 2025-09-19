using System;

class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Баланс не може бути від'ємним!");
        }
    }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"На рахунок додано {amount}. Поточний баланс: {balance}");
        }
        else
        {
            Console.WriteLine("Сума поповнення має бути більшою за 0!");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Поточний баланс: {balance}");
    }
}

class Task2
{
    public static void Run()
    {
        BankAccount acc = new BankAccount(1000);

        acc.PrintInfo();
        acc.Deposit(500);
        acc.Deposit(-50);

        acc.Balance = 2000;
        acc.PrintInfo();

        acc.Balance = -100; // тут буде попередження

        Console.ReadKey();
    }
}
