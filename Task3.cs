using System;

class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area
    {
        get { return Width * Height; }
    }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Ширина: {Width}, Висота: {Height}, Площа: {Area}");
    }
}
class Task3
{
    public static void Run()
    {
        Rectangle rect = new Rectangle(10, 5);
        rect.PrintInfo();
        rect.Width = 7;
        rect.Height = 3;
        rect.PrintInfo();

        Console.ReadKey();
    }
}
