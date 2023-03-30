using System;

class Program
{
    static void Main(string[] args)
    {
        Running bolt1 = new Running("03 Nov 2022",60,"Running",10.0f);
        Running guevara2 = new Running("15 Dec 2022",30,"Running",15.0f);

        Bicycle freddy1 = new Bicycle("08 Nov 2022",30,"Bicycling",15.0f);
        Bicycle robert2 = new Bicycle("30 Jan 2023", 55,"Bicycling",9.0f);

        Swimming phelps1 = new Swimming("10 Nov 2022",60,"Swimming",10);
        Swimming dressel2 = new Swimming("04 Mar 2022",90,"Swimming",30);

        List<Activity> activities = new List<Activity>{bolt1, guevara2,freddy1, robert2, phelps1, dressel2};

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }
        
    }
}