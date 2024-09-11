using System.ComponentModel.DataAnnotations;

namespace RareGroup_BE.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Bio { get; set; }
    public string? ImageUrl { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Active { get; set; }
    public string Uid { get; set; }
    [Required]
    public bool IsStaff { get; set; }
    public List<Post> Posts { get; set; }
}