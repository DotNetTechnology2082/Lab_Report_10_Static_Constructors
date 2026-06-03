using System;

// Student Class
class Student
{
    // Private Fields
    private string name;
    private int[] marks = new int[3];

    // Static Constructor
    static Student()
    {
        Console.WriteLine("Static Constructor Called");
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

    // Display Method
    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);

        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}

// Static Class
static class Utility
{
    public static void Message()
    {
        Console.WriteLine("This is a static class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Calling Static Class Method
        Utility.Message();

        // Creating Object
        Student s1 = new Student();

        // Using Property
        s1.Name = "Rajesh damai";

        // Using Indexer
        s1[0] = 80;
        s1[1] = 85;
        s1[2] = 90;

        // Display Data
        s1.Display();

        Console.ReadLine();
    }
}