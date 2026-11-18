using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    private readonly IEmployeeRepository repository = employeeRepository;

    public Task<List<Employee>> GetEmployeesAsync()
    {
        return repository.GetEmployeesAsync();
    }

}
