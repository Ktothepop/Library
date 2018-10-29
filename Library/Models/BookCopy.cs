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
    [Required]
    public Book Book { get; set; }
  }
}
