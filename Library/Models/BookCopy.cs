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
    public virtual Book Book { get; set; }
        public override string ToString()
        {
            return String.Format("{0}", this.Book.Title);
        }
    }
}
