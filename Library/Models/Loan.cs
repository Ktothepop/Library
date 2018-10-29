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
        public DateTime TimeOfReturn { get; set; }
        public BookCopy LoanBookCopy { get; set; }
        //Koppling till en (1) specifik BookCopy
        //Koppling till en (1) specifik Member (låntagare)
        public BookCopy GetSpecificBookCopy(int id)
        {
            //Hämta in Gå över en lista av bookcopies och para ihop dem?
            return null;
        }
  }
}
