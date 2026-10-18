using DO;

namespace Dal
{
    static internal class DataSource
    {
        //רשימה המכילה את הפניות לכל ישות
        static internal List<Student?> Students = new List<Student?>();
        static internal List<Test?> Tests = new List<Test?>();
        static internal List<Quastion?> questions = new List<Quastion?>();
        static internal List<Answer?> answers = new List<Answer?>();
        static internal List<QuestionExaminee?> questionExaminees = new List<QuestionExaminee?>();


        static internal class Config
        {
            //אתחול מספר ראשוני לכל ישות
            internal const int TestId = 100;
            internal const int QuestionId = 1;
            internal const int AnswerId = 1;


            //אתחול מספר רץ לכל ישות במספר הקבוע
            static private int initialTest = TestId;
            static private int initialQuestion = QuestionId;
            static private int initialAnswer = AnswerId;



            //פונקציות קידום למספרים רצים

            internal static int InitialTest
            {
                get
                {
                    return initialTest++;

                }
            }

            internal static int InitialQuestion
            {
                get
                {
                    return initialQuestion += 4;
                }

            }

            internal static int InitialAnswer
            {
                get
                {
                    return initialAnswer++;
                }
            }
        }
    }
}