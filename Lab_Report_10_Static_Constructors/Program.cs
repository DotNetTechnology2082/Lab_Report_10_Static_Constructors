using System;

// Static Class
static class Utility
{
    class Student
    {
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            // Using Property
            s1.Name = "Rahul";

            // Using Indexer
            s1[0] = 80;
            s1[1] = 85;
            s1[2] = 55;

            Console.WriteLine("Student Name: " + s1.Name);

            Console.WriteLine("Marks:");
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1[1]);
            Console.WriteLine(s1[2]);

            // Calling Static Class Method
        }
    }
}