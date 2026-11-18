namespace Domain.Entities;

public class Department
{
    public int Id {get; set;}
    public string Name {get; set;}=null!;
    public string? Description {get; set;}
    public DateTime CreatedAt {get; set;}=DateTime.UtcNow;

    public List<Employee> Employees {get; set;}=[];
}
