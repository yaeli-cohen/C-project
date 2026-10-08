using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    public record Test(
        int TestId,
        TestSubject Subject,
        DateTime TestDate,
        int AmountQuestion
    )
    {
        public Test() : this(0, default, default, 0) { }
    }
}
