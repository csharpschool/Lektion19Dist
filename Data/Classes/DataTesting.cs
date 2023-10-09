using Common.Classes;
using Data.Interfaces;

namespace Data.Classes;

public class DataTesting : IData
{
    List<Employee> _employees = new()
    {
        new Employee() { Id = 1 },
        new Employee() { Id = 2 }
    };

    public List<Employee> GetEmployees() => _employees;

    public void AddManager(Employee empl)
    {
        throw new NotImplementedException();
    }
}
