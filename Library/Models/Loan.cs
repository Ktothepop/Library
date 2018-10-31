using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  public class Loan
  {
    [Key]
    public int Id { get; set; }
    public DateTime TimeOfLoan { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? TimeOfReturn { get; set; }
    public virtual BookCopy BookCopy { get; set; } //Koppling till en (1) specifik BookCopy
    public virtual Member Member { get; set; } //Koppling till en (1) specifik Member (låntagare)

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
