using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal = null!;

    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        CreateStudents();
        CreateTests();
        CreateQuestions();
        CreateAnswers();
        CreateQuestionExaminees();
    }

    private static void CreateStudents()
    {
        // מבחן מזהה 1
        s_dal.Student.Create(new Student(312345678, "אברהם כהן", 1, 92));
        s_dal.Student.Create(new Student(312345679, "יצחק לוי", 1, 88));
        s_dal.Student.Create(new Student(312345680, "יעקב ישראלי", 1, 95));
        s_dal.Student.Create(new Student(312345681, "שרה מזרחי", 1, 90));
        s_dal.Student.Create(new Student(312345682, "רבקה פרץ", 1, 85));

        // מבחן מזהה 2
        s_dal.Student.Create(new Student(323456789, "דוד אברהמי", 2, 87));
        s_dal.Student.Create(new Student(323456790, "רחל אמתי", 2, 91));
        s_dal.Student.Create(new Student(323456791, "לאה גולדשטיין", 2, 78));
        s_dal.Student.Create(new Student(323456792, "משה שפירא", 2, 94));
        s_dal.Student.Create(new Student(323456793, "אהרון סגל", 2, 89));

        // מבחן מזהה 3
        s_dal.Student.Create(new Student(334567890, "שלמה קליין", 3, 83));
        s_dal.Student.Create(new Student(334567891, "מרים כץ", 3, 96));
        s_dal.Student.Create(new Student(334567892, "חנה פרידמן", 3, 88));
        s_dal.Student.Create(new Student(334567893, "יוסף בורשטיין", 3, 90));
        s_dal.Student.Create(new Student(334567894, "בנימין שטרן", 3, 84));
    }

    private static void CreateTests()
    {
        s_dal.Test.Create(new Test(0, TestSubject.MATH, new DateTime(2027, 5, 10), 10));
        s_dal.Test.Create(new Test(0, TestSubject.ENGLISH, new DateTime(2027, 6, 15), 10));
        s_dal.Test.Create(new Test(0, TestSubject.GEOGRAPHY, new DateTime(2027, 7, 20), 10));
        s_dal.Test.Create(new Test(0, TestSubject.GRAMMAR, new DateTime(2027, 8, 25), 10));
        s_dal.Test.Create(new Test(0, TestSubject.TECHNOLOGY, new DateTime(2027, 9, 30), 10));
    }

    private static void CreateQuestions()
    {
        // מתמטיקה (שאלות 1-4)
        s_dal.Question.Create(new Quastion(1, QuestionSubject.MATH, "מה תוצאת התרגיל: 12 כפול 12?", 1));
        s_dal.Question.Create(new Quastion(2, QuestionSubject.MATH, "חשב את ההיקף של ריבוע שצלעו 5 סמ.", 2));
        s_dal.Question.Create(new Quastion(3, QuestionSubject.MATH, "מהו המספר הראשוני הראשון?", 3));
        s_dal.Question.Create(new Quastion(4, QuestionSubject.MATH, "כמה מעלות יש בסכום זוויות של משולש?", 4));

        // אנגלית (שאלות 5-6)
        s_dal.Question.Create(new Quastion(5, QuestionSubject.ENGLISH, "Translate to Hebrew: Book", 5));
        s_dal.Question.Create(new Quastion(6, QuestionSubject.ENGLISH, "What is the plural form of Child?", 6));

        // טכנולוגיה (שאלות 7-8)
        s_dal.Question.Create(new Quastion(7, QuestionSubject.TECHNOLOGY, "מה תפקידו של זיכרון ה-RAM במחשב?", 7));
        s_dal.Question.Create(new Quastion(8, QuestionSubject.TECHNOLOGY, "איזו שפת תכנות מנוהלת על ידי סביבת .NET?", 8));
    }

    private static void CreateAnswers()
    {
        // תשובות לשאלה 1 (מתמטיקה)
        s_dal.Answer.Create(new Answer(0, 1, "144"));
        s_dal.Answer.Create(new Answer(0, 1, "120"));
        s_dal.Answer.Create(new Answer(0, 1, "100"));

        // תשובות לשאלה 2 (מתמטיקה)
        s_dal.Answer.Create(new Answer(0, 2, "20 סמ"));
        s_dal.Answer.Create(new Answer(0, 2, "25 סמ"));
        s_dal.Answer.Create(new Answer(0, 2, "10 סמ"));

        // תשובות לשאלה 3 (מתמטיקה)
        s_dal.Answer.Create(new Answer(0, 3, "2"));
        s_dal.Answer.Create(new Answer(0, 3, "1"));
        s_dal.Answer.Create(new Answer(0, 3, "3"));

        // תשובות לשאלה 4 (מתמטיקה)
        s_dal.Answer.Create(new Answer(0, 4, "180 מעלות"));
        s_dal.Answer.Create(new Answer(0, 4, "360 מעלות"));
        s_dal.Answer.Create(new Answer(0, 4, "90 מעלות"));

        // תשובות לשאלה 5 (אנגלית)
        s_dal.Answer.Create(new Answer(0, 5, "ספר"));
        s_dal.Answer.Create(new Answer(0, 5, "מחברת"));
        s_dal.Answer.Create(new Answer(0, 5, "עט"));

        // תשובות לשאלה 6 (אנגלית)
        s_dal.Answer.Create(new Answer(0, 6, "Children"));
        s_dal.Answer.Create(new Answer(0, 6, "Childs"));
        s_dal.Answer.Create(new Answer(0, 6, "Childes"));

        // תשובות לשאלה 7 (טכנולוגיה)
        s_dal.Answer.Create(new Answer(0, 7, "אחסון נתונים לטווח קצר וגישה מהירה למעבד"));
        s_dal.Answer.Create(new Answer(0, 7, "אחסון קבצים לטווח ארוך בדיסק קשיח"));
        s_dal.Answer.Create(new Answer(0, 7, "עיבוד גרפי בלבד"));

        // תשובות לשאלה 8 (טכנולוגיה)
        s_dal.Answer.Create(new Answer(0, 8, "C#"));
        s_dal.Answer.Create(new Answer(0, 8, "Python"));
        s_dal.Answer.Create(new Answer(0, 8, "Java"));
    }
    private static void CreateQuestionExaminees()
    {
        s_dal.QuestionExaminee.Create(new QuestionExaminee(312345678, 1, 1, 1));
        s_dal.QuestionExaminee.Create(new QuestionExaminee(312345678, 1, 2, 1));
        s_dal.QuestionExaminee.Create(new QuestionExaminee(312345679, 1, 1, 2));
        s_dal.QuestionExaminee.Create(new QuestionExaminee(312345679, 1, 2, 2));
    }
}