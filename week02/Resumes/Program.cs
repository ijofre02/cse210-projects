using System;

class Program
{
    static void Main(string[] args) 
    {
        Job job1 = new Job(); //create object to use Job
        job1._company = "Tecnocom S.A";
        job1._jobTitle = "Production Administrator";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Grido Helados";
        job2._jobTitle = "Employee";
        job2._startYear = 2019;
        job2._endYear = 2020;

        //job1.DisplayJobInformation();
        //job2.DisplayJobInformation();

        Resume myResume = new Resume(); //create object to use Resume
        myResume._name = "Ignacio Jofre";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        //Console.WriteLine(myResume._Jobs[0]._jobTitle);
        myResume.DisplayResume();
    }
}