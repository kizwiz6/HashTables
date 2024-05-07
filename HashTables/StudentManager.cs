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

    }
}
