using System;

class Student
{
    public string Name;
    public int Age;
    private int id;

    public Student(string name, int age, int id)
    {
        Name = name;
        Age = age;
        this.id = id;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {id}, Ім'я: {Name}, Вік: {Age}");
    }
}

class Task1
{
    public static void Run()
    {
        Student[] students = new Student[]
        {
            new Student("Владік", 17, 101),
            new Student("Алла", 18, 102),
            new Student("Вона не хоче крем брюле, в неї є олег", 21, 103)
        };

        foreach (Student st in students)
        {
            st.PrintInfo();
            Console.WriteLine("-------------------"); // роздільник
        }

        Console.ReadKey();
    }
}
