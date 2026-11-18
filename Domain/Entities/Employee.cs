namespace Domain.Entities;

public class Employee
{
    public int Id {get; set;}
    public string FirstName {get; set;}=null!;
    public string LastName {get; set;}=null!;
    public string Email {get; set;}=null!;
    public string? Phone {get; set;}
    public DateTime HireDate {get; set;}
    public decimal Salary {get; set;}
    public bool IsActive {get; set;}=true;

    public int DepartmentId {get; set;}
    public Department Department {get; set;}=null!;
}
