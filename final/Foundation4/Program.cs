using System;

class Program
{
    static void Main(string[] args)
    {
        Running race1 = new Running("03 Nov 2022",60,"Running",10.0f);
        Console.WriteLine($"{race1.CalculateSpeed()} KM per hour");
    }
}