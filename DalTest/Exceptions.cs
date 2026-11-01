namespace DalTest;

public class IdNotFoundExeception : Exception
{
    public IdNotFoundExeception(string message) 
        : base(message){}

    public IdNotFoundExeception(string message, Exception innerException)
        :base (message,innerException){ }
}

public class IdExistsExeception : Exception
{
    public IdExistsExeception(string message)
    : base(message) { }

    public IdExistsExeception(string message, Exception innerException) : base(message,innerException) { }
}

public class InvalidFieldsExeception : Exception
{
    public InvalidFieldsExeception(string message)
    : base(message) { }

    public InvalidFieldsExeception (string message, Exception innerException) : base(message, innerException) { }
}
