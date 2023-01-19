using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._jobTitle = "Software Engieneer";
        job1._company = "Amazon";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "IT Techinician";
        job2._company = "Computacenter";
        job2._startYear = 2016;
        job2._endYear = 2020;

        job1.Display();
        Console.WriteLine(" ");
        job2.Display();

    }
}