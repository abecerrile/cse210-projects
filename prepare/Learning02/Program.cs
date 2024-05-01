using System;

class Program
{
    static void Main()
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        // Displaying job details individually
        job1.Display();
        job2.Display();

        // Creating resume
        Resume myResume = new Resume("Allison Rose");

        // Adding jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Displaying resume details
        myResume.Display();
    }
}
