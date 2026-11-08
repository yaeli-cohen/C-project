namespace DO;

public record QuestionExaminee(
 int StudentId,
 int TestId,
 int QuestionId,
 int? ChosenQuestion
)
{
    public QuestionExaminee() : this(0, 0, 0, null) { }
}
