
using System;

class Student
{
    private string name;
    private int[] marks = new int[3];

    // Property
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

    // Static Constructor
    static Student()
    {
        Console.WriteLine("Static Constructor Called");
    }

    // Instance Constructor
    public Student()
    {
        Console.WriteLine("Instance Constructor Called");
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine(marks[i]);
        }
    }
}

// Static Class
static class Helper
{
    public static void ShowMessage()
    {
        Console.WriteLine("This is a static class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        // Using property
        s1.Name = "Pradip";

        // Using indexer
        s1[0] = 70;
        s1[1] = 95;
        s1[2] = 80;

        s1.Display();

        // Static class call
        Helper.ShowMessage();

        Console.ReadLine();
    }
}