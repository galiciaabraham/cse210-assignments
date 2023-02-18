using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        Activity test1 = new Activity();
        test1.DisplayInitialMessage();
        test1.GetSeconds();
    }
}