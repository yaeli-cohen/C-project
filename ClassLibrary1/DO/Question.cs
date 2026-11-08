namespace DO;


public record Question(
    int QuestionId,
    QuestionSubject Subject,
    string QuestionContent,
    int RightAns
)
{
    public Question() : this(0, default, string.Empty, 0) { }
}
