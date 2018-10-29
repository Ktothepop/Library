using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  public class Member
  {
    [Key]
    public int Id { get; set; }
    public int SSN { get; set; } 
    public string Name { get; set; }
    //Ett till flera lån (lista med lån "ICollection<Loan> Loan { get; set; }" <- möjligtvis, så gör vi med Author
    // I agree.
    public ICollection<Loan> MemberLoan { get; set; }
    }
}
