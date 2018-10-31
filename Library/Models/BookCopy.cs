using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  /// <summary>  
  ///  BookCopy object class 
  /// </summary>  
  public class BookCopy
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public virtual Book Book { get; set; }
    public Boolean IsLoaned { get; set; } = false;
    /// <summary>
    /// Useful for adding the Book Copy objects directly to a ListBox.
    /// </summary>
    /// <returns>
    /// A string representation of the object
    /// </returns>
    public override string ToString()
    {
      return String.Format("{0}", this.Book.Title);
    }
  }
}
