using Common.Classes;
using Data.Classes;
using Data.Interfaces;

namespace Business.Classes;

public class BookBusiness
{
    IData _data;

    public BookBusiness(IData data)
    {
        _data = data;
    }

    public void CreateManager(Employee empl)
    {
        _data.AddManager(empl);
    }

    public List<Employee> GetEmployees()
    {
        return _data.GetEmployees();
    }
}
