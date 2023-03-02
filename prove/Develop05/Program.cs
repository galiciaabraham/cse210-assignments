using System;

class Program
{
    static void Main(string[] args)
    {
        Menu testmenu1 = new Menu();

        testmenu1.DisplayMenu();
        testmenu1.SetOption(Console.ReadLine());
        Console.WriteLine(testmenu1.GetOption());
    }
}