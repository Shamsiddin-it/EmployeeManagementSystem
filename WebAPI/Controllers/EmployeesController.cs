using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController(IEmployeeService employeeService) : ControllerBase
{
    private readonly IEmployeeService service = employeeService;

    [HttpGet]
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await service.GetEmployeesAsync();
    }
}
