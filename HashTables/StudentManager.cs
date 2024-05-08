using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class StudentManager
    {
        private readonly IHashtable<int, IStudent> _studentHashtable;

        public StudentManager(IHashtable<int, IStudent> studentHashtable)
        {
            _studentHashtable = studentHashtable;
        }

        public void AddStudent(IStudent student)
        {
            _studentHashtable.Add(student.Id, student);
        }

        public IStudent GetStudent(int id)
        {
            return _studentHashtable.Get(id);
        }

        public bool StudentExists(int id)
        {
            return _studentHashtable.ContainsKey(id);
        }

        public void RemoveStudent(int id)
        {
            _studentHashtable.Remove(id);
        }

        // Method to sort students by ID in ascending or descending order
        public IEnumerable<IStudent> SortStudentsById(bool ascending = true)
        {
            var sortedStudents = _studentHashtable.GetAllEntries()
                .Select(entry => entry.Value)
                .OrderBy(student => student.Id);

            return ascending ? sortedStudents : sortedStudents.Reverse();
        }

        // Method to sort students by name in ascending or descending order
        public IEnumerable<IStudent> SortStudentsByName(bool ascending = true)
        {
            var sortedStudents = _studentHashtable.GetAllEntries()
                .Select(entry => entry.Value)
                .OrderBy(student => student.Name);

            return ascending ? sortedStudents : sortedStudents.Reverse();
        }

    }
}
