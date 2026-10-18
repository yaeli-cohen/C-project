using DO;
using DalApi;

namespace Dal;

internal class TestImplementation : ITest
{
    public int Create(Test item)
    {
        Test newTest = item with { TestId = DataSource.Config.InitialTest };
        DataSource.Tests.Add(newTest);
        return newTest.TestId;

    }

    public void Delete(int id)
    {
        var test = DataSource.Tests.FirstOrDefault(t => t.TestId == id);
        if (test != null)
        {
            DataSource.Tests.Remove(test);
        }
        throw new KeyNotFoundException($"test is not found");
    }

    public Test? Read(int id)
    {
        return DataSource.Tests.FirstOrDefault(t => t.TestId == id);
    }

    public List<Test> ReadAll()
    {
        return new List<Test>(DataSource.Tests.ToList());
    }

    public void Update(Test item)
    {
        var test = DataSource.Tests.FirstOrDefault(t => t.TestId == item.TestId);
        if (test != null)
        {
            DataSource.Tests.Remove(test);
            DataSource.Tests.Add(item);
        }
        throw new KeyNotFoundException($"test is not found");
    }
}
