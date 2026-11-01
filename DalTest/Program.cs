using DalApi;
using DO;

namespace DalTest;

public class Program
{
    private static readonly IDal s_dal = new Dal.DalList();
    public static void Main(string[] args)
    {
        //Initialization.Initialize(s_dal);
        MainMenu();

    }

    public static void MainMenu()
    {
        int route;
        do
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Student Menu");
            Console.WriteLine("2. Test Menu");
            Console.WriteLine("3. Question Menu");
            Console.WriteLine("4. Answer Menu");
            Console.WriteLine("5. Question Examinee Menu");
            Console.WriteLine("0. Exit");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    StudentMenu();
                    break;
                case 2:
                    TestMenu();
                    break;
                case 3:
                    QuestionMenu();
                    break;
                case 4:
                    AnswerMenu();
                    break;
                case 5:
                    QuestionExamineeMenu();
                    break;

                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;

            }
        } while (route != 0);
    }
    //========================================
    public static void StudentMenu()
    {
        int route;
        do
        {
            Console.WriteLine("Student Menu");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Read Student by ID");
            Console.WriteLine("4. Read All Students");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("0. Back to Main Menu");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    AddStudent();
                    break;
                case 2:
                    UpdateStudent();
                    break;
                case 3:
                    Read(s_dal.Student);
                    break;
                case 4:
                    ReadAll(s_dal.Student);
                    break;
                case 5:
                    Delete(s_dal.Student);
                    break;
                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;
            }
        } while (route != 0);



    }

    //============================================
    public static void QuestionMenu()
    {
        int route;
        do
        {
            Console.WriteLine("Question Menu");
            Console.WriteLine("1. Add Question");
            Console.WriteLine("2. Update Question");
            Console.WriteLine("3. Read Question by ID");
            Console.WriteLine("4. Read All Questions");
            Console.WriteLine("5. Delete Question");
            Console.WriteLine("0. Back to Main Menu");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    AddQuestion();
                    break;
                case 2:
                    UpdateQuestion();
                    break;
                case 3:
                    Read(s_dal.Question);
                    break;
                case 4:
                    ReadAll(s_dal.Question);
                    break;
                case 5:
                    Delete(s_dal.Question);
                    break;
                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;
            }
        } while (route != 0);



    }


    //=============================================
    public static void AnswerMenu()
    {
        int route;
        do
        {
            Console.WriteLine("Answer Menu");
            Console.WriteLine("1. Add Answer");
            Console.WriteLine("2. Update Answer");
            Console.WriteLine("3. Read Answer by ID");
            Console.WriteLine("4. Read All Answers");
            Console.WriteLine("5. Delete Answer");
            Console.WriteLine("0. Back to Main Menu");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    AddAnswer();
                    break;
                case 2:
                    UpdateAnswer();
                    break;
                case 3: // Read Student by ID
                    try
                    {
                        Read<Student>(s_dal.Student);
                    }
                    catch (IdNotFoundExeception ex)
                    {
                        Console.WriteLine($"שגיאה: {ex.Message}");
                    }
                    catch (InvalidFieldsExeception ex)
                    {
                        Console.WriteLine($"שגיאה: {ex.Message}");
                    }
                    break;

                case 4: // Read All Students
                    try
                    {
                        ReadAll(s_dal.Student);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"שגיאה: {ex.Message}");
                    }
                    break;

                case 5: // Delete Student
                    try
                    {
                        Delete(s_dal.Student);
                    }
                    catch (IdNotFoundExeception ex)
                    {
                        Console.WriteLine($"שגיאה: {ex.Message}");
                    }
                    catch (InvalidFieldsExeception ex)
                    {
                        Console.WriteLine($"שגיאה: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;

            }
        } while (route != 0);

    }
    //===================================================

    public static void TestMenu()
    {
        int route;
        do
        {
            Console.WriteLine("Test Menu");
            Console.WriteLine("1. Add Test");
            Console.WriteLine("2. Update Test");
            Console.WriteLine("3. Read Test by ID");
            Console.WriteLine("4. Read All Tests");
            Console.WriteLine("5. Delete Test");
            Console.WriteLine("0. Back to Main Menu");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    AddTest();
                    break;
                case 2:
                    UpdateTest();
                    break;
                case 3:
                    Read(s_dal.Test);
                    break;
                case 4:
                    ReadAll(s_dal.Test);
                    break;
                case 5:
                    Delete(s_dal.Test);
                    break;
                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;
            }
        } while (route != 0);

    }

    //=================================================
    public static void QuestionExamineeMenu()
    {
        int route;
        do
        {
            Console.WriteLine("QuestionExaminee Menu");
            Console.WriteLine("1. Add QuestionExaminee");
            Console.WriteLine("2. Update QuestionExaminee");
            Console.WriteLine("3. Read QuestionExaminee by ID");
            Console.WriteLine("4. Read All QuestionExaminees");
            Console.WriteLine("5. Delete QuestionExaminee");
            Console.WriteLine("0. Back to Main Menu");
            route = int.Parse(Console.ReadLine());
            switch (route)
            {
                case 0:
                    return;
                case 1:
                    AddQuestionExaminee();
                    break;
                case 2:
                    UpdateQuestionExaminee();
                    break;
                case 3:
                    Read(s_dal.QuestionExaminee);
                    break;
                case 4:
                    ReadAll(s_dal.QuestionExaminee);
                    break;
                case 5:
                    Delete(s_dal.QuestionExaminee);
                    break;
                default:
                    Console.WriteLine("invalid choice, please try again");
                    break;

            }
        } while (route != 0);


    }


    public static T Read<T>(ICrud<T> s_dal) where T : class
    {
        Console.WriteLine("Enter ID to read:");
        int id = int.Parse(Console.ReadLine());
        var item = s_dal.Read(id);
        if (item != null)
        {
            Console.WriteLine(item.ToString());
            return item;
        }
        else
        {
            Console.WriteLine("Item not found.");
            return null;
        }
    }


    public static void ReadAll<T>(ICrud<T> s_dal) where T : class
    {
        var items = s_dal.ReadAll();
        if (items == null)
        {
            Console.WriteLine("No items found.");
            return;
        }

        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void Delete<T>(ICrud<T> s_dal) where T : class
    {
        Console.WriteLine("Enter ID to delete:");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            throw new InvalidFieldsExeception("Invalid ID format entered.");
        }

        s_dal.Delete(id);
        Console.WriteLine("Item deleted successfully.");
    }
    public static void AddStudent()
    { }

    public static void UpdateStudent()
    { }

    public static void AddQuestion()
    { }

    public static void UpdateQuestion()
    { }

    public static void AddAnswer()
    { }
    public static void UpdateAnswer()
    { }
    public static void AddTest()
    { }
    public static void UpdateTest()
    { }
    public static void AddQuestionExaminee()
    { }
    public static void UpdateQuestionExaminee()
    { }

}








