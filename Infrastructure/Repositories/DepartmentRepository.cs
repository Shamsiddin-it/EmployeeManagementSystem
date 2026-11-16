using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DepartmentRepository(ApplicationDbContext appDbContext): IDepartmentRepository
{
    private readonly ApplicationDbContext _context = appDbContext;

    public async Task<bool> AddDepartmentAsync(Department department)
    {
        _context.Departments.Add(department);
        var res = await _context.SaveChangesAsync();
        return res>0;
    }

    public async Task<bool> DeleteDepartmentAsync(int id)
    {
        var department = await _context.Departments.FirstOrDefaultAsync(x=>x.Id==id);
        if (department != null)
        {
            _context.Departments.Remove(department);
        }
        var res = await _context.SaveChangesAsync();
        return res>0;
    }

    public async Task<Department> GetDepartmentAsync(int id)
    {
        var department = await _context.Departments.FirstOrDefaultAsync(x=>x.Id==id);
        return department??new(); 
    }

    public async Task<List<Department>> GetDepartmentsAsync()
    {
        return await _context.Departments.ToListAsync();
    }

    public async Task<bool> UpdateDepartmentAsync(Department department)
    {
        var dep = await _context.Departments.FirstOrDefaultAsync(x=>x.Id==department.Id);
        if (dep != null)
        {
            dep.Name=department.Name;
            dep.Description = department.Description;
        }
        var res = await _context.SaveChangesAsync();
        return res>0;
    }

}
