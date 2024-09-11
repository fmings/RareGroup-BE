
namespace RareGroup_BE.Models;

public class Tags
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<Posts> Posts { get; set; }
}