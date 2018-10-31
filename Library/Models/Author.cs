using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
  /// <summary>  
  ///  Author object class 
  /// </summary>  
  public class Author
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    /// <summary>
    /// Useful for adding the author objects directly to a ListBox.
    /// </summary>
    /// <returns>
    /// A string representation of the object
    /// </returns>
    public override string ToString()
    {
      return String.Format("{0}", this.Name);
    }
  }
}
