using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2005;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Blume";
        job2._jobTitle = "CEO";
        job2._startYear = 1998;
        job2._endYear = 2005;

        Resume myResume = new Resume();
        myResume._name = "Raymond Kenney";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}