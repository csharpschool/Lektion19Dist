using Common.Classes;

namespace Data.Interfaces;

public interface IData
{
    void AddManager(Employee empl);
    List<Employee> GetEmployees();
}
