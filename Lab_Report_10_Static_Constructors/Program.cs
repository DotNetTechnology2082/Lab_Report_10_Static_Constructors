using System;

namespace LabReport10
{
    // Static class (utility class)
    static class Utility
    {
        public static void ShowMessage()
        {
            Console.WriteLine("Utility Static Class Method Called");
        }
    }

    class Student
    {
        // Private fields
        private string name;
        private int age;

        // Static constructor
        static Student()
        {
            Console.WriteLine("Static Constructor Called (Runs Only Once)");
        }

        // Property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Indexer (example: store marks)
        private int[] marks = new int[3];

        public int this[int index]
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
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
            // Calling static class method
            Utility.ShowMessage();

            // Creating object
            Student s1 = new Student();

            // Using properties
            s1.Name = "Suman";
            s1.Age = 20;

            // Using indexer
            s1[0] = 85;
            s1[1] = 90;
            s1[2] = 88;

            // Display data
            s1.Display();

            Console.WriteLine("\nEnd of Program");
        }
    }
}