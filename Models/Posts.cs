
using Microsoft.Extensions.Hosting;

namespace RareGroup_BE.Models;

public class Posts
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public string ImageUrl { get; set; }
    public string Content { get; set; }
    public bool Approved { get; set; }
    public List<Tags> Tags { get; set; } 
    public Users User { get; set; }
    public Categories Category { get; set; }

}