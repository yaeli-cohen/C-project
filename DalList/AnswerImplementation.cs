using DO;
using DalApi;

namespace Dal;

internal class AnswerImplementation : IAnswer
{
    public int Create(Answer item)
    {
        Answer newAnswer = item with { AnswerId = DataSource.Config.InitialAnswer };
        DataSource.answers.Add(newAnswer);
        return newAnswer.AnswerId;

    }

    public void Delete(int id)
    {
        var answer = DataSource.answers.FirstOrDefault(a => a.AnswerId == id);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
        }
        throw new KeyNotFoundException($"answer is not found");
    }

    public Answer? Read(int id)
    {

        return DataSource.answers.FirstOrDefault(a => a.AnswerId == id);
    }

    public List<Answer> ReadAll()
    {
        return new List<Answer>(DataSource.answers.ToList());
    }

    public void Update(Answer item)
    {
        var answer = DataSource.answers.FirstOrDefault(a => a.AnswerId == item.AnswerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            DataSource.answers.Add(item);
        }
        throw new KeyNotFoundException($"answer is not found");
    }
}
