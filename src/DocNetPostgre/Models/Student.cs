

namespace DocNetPostgre.Models;

public record Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Active { get; set; }
}