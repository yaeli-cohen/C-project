using DO;

namespace Dal
{
    static internal class DataSource
    {

        static internal List<Student?> Students = new List<Student>();
        static internal List<Test?> Tests = new List<Test>();
        static internal List<Quastion?> quastions = new List<Quastion>();

        static internal class Config    
        {
            internal const int TestId = 100;
            internal const int StudentId = 1000;
            internal const int QuestionId = 1;

            static private int initialTest = TestId;
            static private int initialStudent = StudentId;
            static private int initialQuestion = QuestionId;

            internal static int InitialTest
            {
                get
                {
                    return initialTest++;

                }
            }
            internal static int InitialStudent
            {
                get
                {
                    return initialStudent++;
                }
            }

            internal static int InitialQuestion
            {
                get
                {
                    return initialQuestion++;
                }

            }
        }
    }
}