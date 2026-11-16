using Domain.Entities;

namespace Domain.Interfaces;

public interface IDepartmentRepository
{
    Task<bool> AddDepartmentAsync(Department department);
    Task<bool> UpdateDepartmentAsync(Department department);
    Task<bool> DeleteDepartmentAsync(int id);
    Task<Department> GetDepartmentAsync(int id);
    Task<List<Department>> GetDepartmentsAsync();
}
