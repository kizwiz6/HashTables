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

            // Add sample students
            AddSampleStudents(studentManager);

            // Retrieve and display a student
            Console.WriteLine(studentManager.GetStudent(1).Name); // Output: Kieran
            Console.WriteLine(studentManager.GetStudent(2).Name); // Output: Kieran

            // Check if a student exists
            Console.WriteLine(studentManager.StudentExists(3)); // Output: False

            // Remove a student
            studentManager.RemoveStudent(2);
            Console.WriteLine(studentManager.StudentExists(2)); // Output: False


            // Demo operations and display results
            DemoOperations(studentManager);

            // Sort and display students
            SortAndDisplayStudents(studentManager);

        }

        // Method to add sample students
        private static void AddSampleStudents(StudentManager studentManager)
        {
            var students = new[]
            {
                new Student { Id = 1, Name = "Kieran" },
                new Student { Id = 2, Name = "Alice" },
                new Student { Id = 3, Name = "James" },
                new Student { Id = 4, Name = "Peter" },
                new Student { Id = 5, Name = "Andy" }
            };

            foreach (var student in students)
            {
                studentManager.AddStudent(student);
            }
        }

        // Method to demonstrate operations and display results
        private static void DemoOperations(StudentManager studentManager)
        {
            // Retrieve and display a student
            Console.WriteLine($"Student with ID 1: {studentManager.GetStudent(1).Name}");

            // Check if a student exists
            Console.WriteLine($"Student with ID 3 exists: {studentManager.StudentExists(3)}");

            // Remove a student
            studentManager.RemoveStudent(2);
            Console.WriteLine($"Student with ID 2 removed. Exists: {studentManager.StudentExists(2)}");
        }

        // Method to sort and display students
        private static void SortAndDisplayStudents(StudentManager studentManager)
        {
            // Sort students by ID in ascending order
            Console.WriteLine("\nSorted by ID (ascending):");
            foreach (var student in studentManager.SortStudentsById())
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }

            // Sort students by name in descending order
            Console.WriteLine("\nSorted by name (descending):");
            foreach (var student in studentManager.SortStudentsByName(false))
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }

    }
}
