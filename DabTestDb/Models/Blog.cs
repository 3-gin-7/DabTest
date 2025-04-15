using System.ComponentModel.DataAnnotations;

namespace DabDbTestDb.Models;

public class Blog
{
    public int BlogId { get; set; }
    [MaxLength(128)]
    public string Url { get; set; } = null!;
    public List<Post> Posts { get; } = new(); 
}