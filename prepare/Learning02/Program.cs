using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._jobTitle = "Software Engieneer";
        job1._company = "Amazon";
        Console.WriteLine(job1._jobTitle + " " + job1._company);

        Job job2 = new Job();
        job2._jobTitle = "IT Techinician";
        job2._company = "Computacenter";
        Console.WriteLine(job2._jobTitle + " " + job2._company);

    }
}