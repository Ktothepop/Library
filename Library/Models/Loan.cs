using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  /// <summary>  
  ///  Loan object class 
  /// </summary>  
  public class Loan
  {
    [Key]
    public int Id { get; set; }
    public DateTime TimeOfLoan { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? TimeOfReturn { get; set; }
    public virtual BookCopy BookCopy { get; set; }
    public virtual Member Member { get; set; }

    /// <summary>
    /// Useful for adding the Loan objects directly to a ListBox.
    /// </summary>
    /// <returns>
    /// A string representation of the object
    /// </returns>
    public override string ToString()
    {
      string TimeOfReturnTemp = this.TimeOfReturn.HasValue ? this.TimeOfReturn.Value.ToString("yyyy'-'MM'-'dd") : "Not returned";

      return String.Format("{0}",
        "Loaned on: " +
        this.TimeOfLoan.ToString("yyyy'-'MM'-'dd") +
        " | Due Date: " +
        this.DueDate.ToString("yyyy'-'MM'-'dd") +
        " | Returned on: " +
        TimeOfReturnTemp +
        " | Member: " +
        this.Member.Name +
        " | Book: " +
        this.BookCopy.Book.Title);
    }
  }
}
