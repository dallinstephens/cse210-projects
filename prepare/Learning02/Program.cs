using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Jackman Music";
        job1._jobTitle = "Technology and Shipping Specialist";
        job1._startYear = 2019;
        job1._endYear = 2023;
        job1.DisplayJobInformation();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2023;
        job2._endYear = 2027;
        job2.DisplayJobInformation();
    }
}