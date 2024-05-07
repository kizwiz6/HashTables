using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    /// <summary>
    /// Abstraction for student
    /// </summary>
    internal interface IStudent
    {
        int Id { get; }
        string Name { get; }
    }
}
