
namespace DocNetPostgre.Models;

/// <summary>
/// Simple todo list item to show a few items
/// </summary>
public class TodoItem
{
    public Guid Id { get; set; }
    #nullable enable
    public string? Title { get; private set; } = default!;
    public string? Note { get; private set; } = default!;
    public DateTime? Reminder { get; set; }
    #nullable disable
    public bool Complete { get; set; }
    public Employee Employee { get; set; }

    /// <summary>
    /// Hidden constructor
    /// </summary>
    private TodoItem(){}
    
    public TodoItem(string title, string note, Employee employee)
    {
        Title = title;
        Note = note;
        Employee = employee;
    }

    public TodoItem(string title, string note, Employee employee, DateTime reminderDate) : this(title, note, employee)
    {
        Reminder = reminderDate;
    }

    #region Setters

    public void MarkComplete() => this.Complete = true;

    public void UpdateTitle(string title) => this.Title = title;
    public void UpdateNote(string note) => this.Note = note;

    #endregion
}