using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
  public class Author
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    /// <summary>
    /// Useful for adding the book objects directly to a ListBox.
    /// </summary>
    public override string ToString()
    {
      return String.Format("{0}", this.Name);
    }
  }
}
