
namespace DocNetPostgre.Models;

public record TodoItem
{
    public Guid Id { get; set; }
    public string? Title { get; set; }

    public string? Note { get; set; }
    public DateTime? Reminder { get; set; }
    public string Email { get; set; }
}