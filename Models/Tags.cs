
namespace RareGroup_BE.Models;

public class Tags
{
  public int Id { get; set; }
  public int PostId { get; set; }
  public int TagId { get; set; }
  public List<Post> Posts { get; set; }
}