using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the hashtable
            IHashtable<int, IStudent> studentHashtable = new Hashtable<int, IStudent>();

            // Create an instance of the student manager
            StudentManager studentManager = new StudentManager(studentHashtable);

            IStudent student1 = new Student { Id = 1, Name = "Kieran" };
            IStudent student2 = new Student { Id = 2, Name = "Alice" };

            // Add students to the hashtable
            studentManager.AddStudent(student1);
            studentManager.AddStudent(student2);

            // Retrieve and display a student
            Console.WriteLine(studentManager.GetStudent(1).Name); // Output: Kieran

            // Check if a student exists
            Console.WriteLine(studentManager.StudentExists(3)); // Output: False

            // Remove a student
            studentManager.RemoveStudent(2);
            Console.WriteLine(studentManager.StudentExists(2)); // Output: False


            foreach (var entry in studentHashtable.GetAllEntries())
            {
                var entryKey = entry.Key;
                var student = entry.Value;
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }

        }
    }
}
