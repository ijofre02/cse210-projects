using System;
public class Resume
{
    public string _name;
    public List<Job> _Jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _Jobs)  //the tipe is not "string" but "Job" 
        {                           //and iterate trhougt _Job, not Job
            job.DisplayJobInformation();
        }
    }
}