using System.ComponentModel.DataAnnotations;

namespace DabDbTestDb.Models;

public class Post
{
    public int PostId { get; set; }
    [MaxLength(128)]
    public string Title { get; set; } = null!;
    public string? Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; } = null!;
}