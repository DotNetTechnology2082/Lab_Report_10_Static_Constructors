using System;


static class Utility
{
    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}


class Student
{
    //Private fields
    private string name;
    private int age;

    //Array for indexer
    private int[] marks = new int[3];

    //Static field
    private static string collegeName;

    // Static constructor
    static Student()
    {
        collegeName = "Orchid International College";
        Console.WriteLine("Static Constructor Called!");
    }

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

    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }

    public void Display()
    {
        Console.WriteLine("\nStudent Details");
        Console.WriteLine("College Name: " + collegeName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);

        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.Name = "Suvam";
        s1.Age = 21;

        s1[0] = 85;
        s1[1] = 90;
        s1[2] = 88;
       
        s1.Display();

        Utility.ShowMessage("\nProgram Executed Successfully!");

        Console.ReadLine();
    }
}