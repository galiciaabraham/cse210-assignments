using System;

class Program
{
    static void Main(string[] args)
    {
        Running race1 = new Running("03 Nov 2022",60,"Running",10.0f);
        race1.CalculateSpeed();
        race1.CalculatePace();
        race1.DisplaySummary();
        Bicycle freddy1 = new Bicycle("08 Nov 2022",30,"Bicycling",5.0f);
        freddy1.CalculateDistance();
        freddy1.CalculatePace();
        freddy1.DisplaySummary();
        Swimming phelps1 = new Swimming("10 Nov 2022",60,"Swimming",10);
        phelps1.CalculateDistance();
        phelps1.CalculateSpeed();
        phelps1.DisplaySummary();
        
    }
}