using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    public record Quastion(
        int QuastionId,
        QuastionSubject Subject,
        string QuastionContent,
        int RightAns
    )
    {
        public Quastion() : this(0, default, string.Empty, 0) { }
    }

}
