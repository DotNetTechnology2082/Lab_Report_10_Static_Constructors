using System;

// Class with private fields
class Student
{
    private string name;
    private int[] marks = new int[3];

    // Static constructor
    static Student()
    {
        Console.WriteLine("Static constructor called.");
    }

    // Property using get and set
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Indexer
    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }
}

// Static class
static class Utility
{
    public static void ShowMessage()
    {
        Console.WriteLine("Utility method from static class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        // Using property
        s1.Name = "Pasang Lama";

        // Using indexer
        s1[0] = 65;
        s1[1] = 70;
        s1[2] = 82;

        // Display results
        Console.WriteLine("Student Name: " + s1.Name);
        Console.WriteLine("Marks:");
        Console.WriteLine("Subject 1: " + s1[0]);
        Console.WriteLine("Subject 2: " + s1[1]);
        Console.WriteLine("Subject 3: " + s1[2]);

        // Calling static class method
        Utility.ShowMessage();

        Console.ReadLine();
    }
}