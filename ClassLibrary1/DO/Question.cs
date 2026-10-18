using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    public record Quastion(
        int QuastionId,
        QuestionSubject Subject,
        string QuestionContent,
        int RightAns
    )
    {
        public Quastion() : this(0, default, string.Empty, 0) { }
    }

}
