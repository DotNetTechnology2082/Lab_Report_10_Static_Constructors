using System;

class Student
{
    private string name;
    private string[] subjects = new string[3];

    // Static Data Member
    public static string CollegeName;

    // Static Constructor
    static Student()
    {
        CollegeName = "Orchid International College";
        Console.WriteLine("Static Constructor Executed");
    }

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Indexer
    public string this[int index]
    {
        get { return subjects[index]; }
        set { subjects[index] = value; }
    }
}

// Static Class
static class Utility
{
    public static void DisplayMessage()
    {
        Console.WriteLine("Welcome to C# Programming");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        // Using Property
        s.Name = "Annie";

        // Using Indexer
        s[0] = "C#";
        s[1] = "Java";
        s[2] = "Python";

        Console.WriteLine("Student Name: " + s.Name);
        Console.WriteLine("College Name: " + Student.CollegeName);

        Console.WriteLine("Subjects:");
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);

        Utility.DisplayMessage();

        Console.ReadLine();
    }
}
