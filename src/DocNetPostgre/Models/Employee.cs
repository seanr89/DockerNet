
namespace DocNetPostgre.Models;

/// <summary>
/// More example / test data for employee
/// </summary>
/// <value></value>
public record Employee
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Active { get; set; }
}