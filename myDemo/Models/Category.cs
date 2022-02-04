using System.ComponentModel.DataAnnotations;

namespace myDemo.Models;

public class Category
{

    [Key] //makes Id a key and and identifier
    public int Id { get; set; }
    [Required] //makes the name a required property
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}