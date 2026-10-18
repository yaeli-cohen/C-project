using DO;
using DalApi;

namespace Dal;

internal class StudentImplementation : IStudent
{
    public int Create(Student item)
    {
        foreach (var i in DataSource.Students)
        {
            if (i.StudentId == item.StudentId)
                throw new Exception($"this id already exsist");
        }
        DataSource.Students.Add(item);
        return item.StudentId;
    }

    public void Delete(int id)
    {
        var student = DataSource.Students.FirstOrDefault(a => a.StudentId == id);
        if (student != null)
        {
            DataSource.Students.Remove(student);
        }
        throw new KeyNotFoundException($"student is not found");
    }

    public Student? Read(int id)
    {

        return DataSource.Students.FirstOrDefault(a => a.StudentId == id);
    }

    public List<Student> ReadAll()
    {
        return new List<Student>(DataSource.Students.ToList());
    }

    public void Update(Student item)
    {
        var student = DataSource.Students.FirstOrDefault(a => a.StudentId == item.StudentId);
        if (student != null)
        {
            DataSource.Students.Remove(student);
            DataSource.Students.Add(item);
        }
        throw new KeyNotFoundException($"student is not found");

    }
}
