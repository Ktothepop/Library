using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  public class BookCopy
  {
    [Key]
    public int Id { get; set; }
    //Behöver koppling till bok!
    //"A book copy IS associated with a book" required eller?
    [Required]
    public Book Cbook { get; set; }
  }
}
