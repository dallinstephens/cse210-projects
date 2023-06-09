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
        // job1.DisplayJobInformation();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2023;
        job2._endYear = 2027;
        // job2.DisplayJobInformation();

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1._name = "Dallin Stephens";
        resume1.DisplayResume();
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html