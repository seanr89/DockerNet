
namespace DocNetPostgre.Models;

/// <summary>
/// Simple todo list item to show a few items
/// </summary>
public class TodoItem
{
    public Guid Id { get; set; }
    #nullable enable
    public string? Title { get; init; } = default!;
    public string? Note { get; init; } = default!;
    public DateTime? Reminder { get; set; }
    #nullable disable
    public bool Complete { get; set; }

    /// <summary>
    /// Hidden constructor
    /// </summary>
    private TodoItem(){}
    
    public TodoItem(string title, string note)
    {
        Title = title;
        Note = note;
    }

    public TodoItem(string title, string note, DateTime reminderDate) : this(title, note)
    {
        Reminder = reminderDate;
    }

    #region Setters

    public void MarkComplete() => this.Complete = true;

    #endregion
}