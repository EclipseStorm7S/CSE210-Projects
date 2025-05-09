using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        Job job1 = new Job();
        job1.company = "Apple";
        job1.jobTitle = "Executive Janitor";
        job1.startYear = 2012;
        job1.endYear = 2012;

        //job1.Display();

        Job job2 = new Job();
        job2.company = "Bob and Joel's discount mattresses";
        job2.jobTitle = "Assistant to Intern Janitor";
        job2.startYear = 2012;
        job2.endYear = 2023;

        //job2.Display();

        resume1.name = "Bilbo Swaggins";
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);

        resume1.Display();
    }
}