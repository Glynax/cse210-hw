using System;

class Program
{
    static void Main(string[] args)
    {
       
        Resume myResume = new Resume("Allison Rose");
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.Display();


    }
}