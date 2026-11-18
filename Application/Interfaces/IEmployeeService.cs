using Domain.Entities;

namespace Application.Interfaces;

public interface IEmployeeService
{
    Task<List<Employee>> GetEmployeesAsync();
}
