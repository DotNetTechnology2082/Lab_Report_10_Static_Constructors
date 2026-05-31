using System;

// Static class
static class Utility
{
    // Utility method
    public static void ShowMessage()
    {
        Console.WriteLine("This is a static class method.");
    }
}

class Student
{
    // Private fields
    private string name;
    private int age;

    // Array for indexer
    private string[] subjects = new string[3];

    // Static variable
    static int count;

    // Static constructor
    static Student()
    {
        count = 0;
        Console.WriteLine("Static Constructor Called.");
    }

    // Constructor
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        count++;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Indexer
    public string this[int index]
    {
        get { return subjects[index]; }
        set { subjects[index] = value; }
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student Age: " + Age);

        Console.WriteLine("Subjects:");
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Calling static class method
        Utility.ShowMessage();

        // Creating object
        Student s1 = new Student("Sandesh", 27);

        // Using properties
        s1.Name = "Sandesh";
        s1.Age = 27;

        // Using indexer
        s1[0] = "Math";
        s1[1] = "Computer";
        s1[2] = "English";

        // Display result
        s1.Display();

        Console.ReadLine();
    }
}