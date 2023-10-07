using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    

      Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Tsitsi Mutsvedu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
// Read all entries from the file
    string path = @"C:\Entries\entry.txt";
    List<Entry> entries = new List<Entry>();
    using (StreamReader reader = new StreamReader(path)) {
    string line;
    while ((line = reader.ReadLine()) != null) {
      entries.Add(Entry.FromString(line));
    }
}

// Iterate through each entry and print its contents
foreach (Entry entry in entries) {
    Console.WriteLine("Prompt: " + entry.Prompt);
    Console.WriteLine("Response: " + entry.Response);
    Console.WriteLine("Date: " + entry.Date);
    Console.WriteLine();
}

    }

    


    
    
    