using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class EmployeeRepository(ApplicationDbContext applicationDbContext): IEmployeeRepository
{
    private readonly ApplicationDbContext context = applicationDbContext;

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var employees = await context.Employees.Include(e=>e.Department).ToListAsync();
        return employees;
    }

}
