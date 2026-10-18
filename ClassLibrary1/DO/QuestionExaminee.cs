namespace DO;

public record QuestionExaminee(
 int StudentId,
 int TestId,
 int QuastionId,
 int? ChosenQuestion
)
{
    public QuestionExaminee() : this(0, 0, 0, null) { }
}
