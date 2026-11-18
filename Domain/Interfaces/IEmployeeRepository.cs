using Domain.Entities;

namespace Domain.Interfaces;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetEmployeesAsync();
}
