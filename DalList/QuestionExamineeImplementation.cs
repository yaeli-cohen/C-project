using DO;
using DalApi;

namespace Dal;

internal class QuestionExamineeImplementation : IQuestionExaminee
{
    public int Create(QuestionExaminee item)
    {
        var searchQuestionExaminee = DataSource.questionExaminees.FirstOrDefault(qe =>
            qe.StudentId == item.StudentId &&
            qe.TestId == item.TestId &&
            qe.QuastionId == item.QuastionId);

        if (searchQuestionExaminee != null)
        {
            throw new Exception($"QuestionExaminee already exists.");
        }
        else
        {
            QuestionExaminee newQuestionExaminee = new QuestionExaminee(
                item.StudentId,
                item.TestId,
                item.QuastionId,
                item.ChosenQuestion
            );

            DataSource.questionExaminees.Add(newQuestionExaminee);
            return newQuestionExaminee.TestId;
        }
    }

    public void Delete(int studentId, int testId, int questionId)
    {
        var existingQuestionExaminee = DataSource.questionExaminees.FirstOrDefault(qe =>
            qe.StudentId == studentId &&
            qe.TestId == testId &&
            qe.QuastionId == questionId);

        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminees.Remove(existingQuestionExaminee);
        }
        else
        {
            throw new KeyNotFoundException($"QuestionExaminee with Student ID {studentId}, Test ID {testId}, and Question ID {questionId} not found.");
        }
    }

    // מימוש עבור חתימת ה-ICrud המקורית במידת הצורך (מקבל אובייקט או מזהה יחיד)
    public void Delete(int id)
    {
        throw new NotImplementedException("Use the composite key Delete overload.");
    }

    public QuestionExaminee? Read(int studentId, int testId, int questionId)
    {
        return DataSource.questionExaminees.FirstOrDefault(qe =>
            qe.TestId == testId &&
            qe.StudentId == studentId &&
            qe.QuastionId == questionId);
    }

    // מימוש עבור חתימת ה-ICrud המקורית
    public QuestionExaminee? Read(int id)
    {
        throw new NotImplementedException("Use the composite key Read overload.");
    }

    public List<QuestionExaminee> ReadAll()
    {
        return new List<QuestionExaminee>(DataSource.questionExaminees);
    }

    public void Update(QuestionExaminee item)
    {
        var existingQuestionExaminee = DataSource.questionExaminees.FirstOrDefault(qe =>
            qe.StudentId == item.StudentId &&
            qe.TestId == item.TestId &&
            qe.QuastionId == item.QuastionId);

        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminees.Remove(existingQuestionExaminee);
            DataSource.questionExaminees.Add(item);
        }
        else
        {
            throw new KeyNotFoundException($"QuestionExaminee with Student ID {item.StudentId}, Test ID {item.TestId}, and Question ID {item.QuastionId} not found.");
        }
    }
}