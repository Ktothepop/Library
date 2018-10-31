using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  /// <summary>  
  ///  Member object class 
  /// </summary>  
  public class Member
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public int SSN { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<Loan> Loans { get; set; }

    /// <summary>
    /// Useful for adding the Member objects directly to a ListBox.
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
