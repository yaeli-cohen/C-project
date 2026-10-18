using DO;
using DalApi;

namespace DalApi;

public interface IQuestionExaminee : ICrud<QuestionExaminee>
{
    QuestionExaminee? Read(int studentId, int testId, int questionId);
    void Delete(int studentId, int testId, int questionId);
}