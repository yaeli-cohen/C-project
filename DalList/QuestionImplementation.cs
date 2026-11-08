using DO;//לא תקין
using DalApi;

namespace Dal;

internal class QuestionImplementation : IQuestion
{
    public int Create(Question item)
    {
        Question newQuestion = item with { QuestionId = DataSource.Config.QuestionId };
        DataSource.questions.Add(newQuestion);
        return newQuestion.QuestionId;

    }

    public void Delete(int id)
    {
        var question = DataSource.questions.FirstOrDefault(t => t.QuestionId == id);
        if (question != null)
        {
            DataSource.questions.Remove(question);
        }
        throw new KeyNotFoundException($"question is not found");
    }

    public Question? Read(int id)
    {
        return DataSource.questions.FirstOrDefault(q => q.QuestionId == id);
    }

    public List<Question> ReadAll()
    {
        return new List<Question>(DataSource.questions.ToList());
    }

    public void Update(Question item)
    {
        var question = DataSource.questions.FirstOrDefault(t => t.QuestionId == item.QuestionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
            DataSource.questions.Add(item);
        }
        throw new KeyNotFoundException($"question is not found");
    }
}
