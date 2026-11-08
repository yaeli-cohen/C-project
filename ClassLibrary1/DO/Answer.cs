using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Answer(
     int AnswerId,
     int QuestionId,
     string AnswerContent
 )
    {
        public Answer() : this(0, 0, string.Empty) { }
    }
}
