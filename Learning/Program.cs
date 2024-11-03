using System;
using static Learning.NewClass;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students do you have: ");
            int amtOfStudents = Convert.ToInt32(Console.ReadLine());

            string[] students = new string[amtOfStudents];

            for (int i = 0; i < students.Length; i++)
            {
                addStudent(Convert.ToString(Console.ReadLine() ?? "Unknown"), students, i);
            }

            Array.Sort(students);
            Console.Clear();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        static void addStudent(string studentName, string[] list, int index) {
            list[index] = studentName;
        }
    }
}