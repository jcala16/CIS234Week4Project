using System.Collections.Generic;                  
namespace CH04.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    
    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
