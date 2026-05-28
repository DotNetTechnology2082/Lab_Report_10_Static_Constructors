using System;

// Static class
static class Utility
{
    // Utility method
    public static void ShowMessage()
    {
        Console.WriteLine("Welcome to C# Programming");
    }
}

class Student
{
    // Private fields
    private string name;
    private int[] marks = new int[3];

    // Static field
    static int studentCount;

    // Static constructor
    static Student()
    {
        studentCount = 0;
        Console.WriteLine("Static Constructor Called");
    }

    // Normal constructor
    public Student(string name)
    {
        this.name = name;
        studentCount++;
    }

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

    // Display method
    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);

        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }

        Console.WriteLine("Total Students: " + studentCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Calling static class method
        Utility.ShowMessage();

        // Creating object
        Student s1 = new Student("swastika");

        // Using property
        s1.Name = "Sushma";

        // Using indexer
        s1[0] = 80;
        s1[1] = 85;
        s1[2] = 90;

        // Display data
        s1.Display();

        Console.ReadLine();
    }
}