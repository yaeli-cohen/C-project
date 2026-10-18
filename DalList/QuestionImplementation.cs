using DO;//לא תקין
using DalApi;

namespace Dal;

internal class QuestionImplementation : IQuestion
{
    public int Create(Quastion item)
    {
        Quastion newQuestion = item with { QuastionId = DataSource.Config.QuestionId };
        DataSource.questions.Add(newQuestion);
        return newQuestion.QuastionId;

    }

    public void Delete(int id)
    {
        var question = DataSource.questions.FirstOrDefault(t => t.QuastionId == id);
        if (question != null)
        {
            DataSource.questions.Remove(question);
        }
        throw new KeyNotFoundException($"question is not found");
    }

    public Quastion? Read(int id)
    {
        return DataSource.questions.FirstOrDefault(q => q.QuastionId == id);
    }

    public List<Quastion> ReadAll()
    {
        return new List<Quastion>(DataSource.questions.ToList());
    }

    public void Update(Quastion item)
    {
        var question = DataSource.questions.FirstOrDefault(t => t.QuastionId == item.QuastionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
            DataSource.questions.Add(item);
        }
        throw new KeyNotFoundException($"question is not found");
    }
}
