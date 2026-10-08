using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Student(
     int StudentId,
     string StudentName,
     int TestId,
     int? Mark
 )
    {
        public Student() : this(0, string.Empty, 0, null) { }
    }

}
