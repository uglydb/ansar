using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

[Table("people")]
public class TodoItem
{
    public long id { get; set; }
    public string? name { get; set; }
    public int age { get; set; }
    public string? city { get; set; }
}
