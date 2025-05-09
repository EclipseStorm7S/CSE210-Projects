using System;
class Resume{
    public string name;
    public List<Job> jobs = new List<Job>();
    
    public void Display(){
        Console.WriteLine($"Name: {name}\nJobs:");
        foreach(Job i in jobs){
            i.Display();
        }
    }
}