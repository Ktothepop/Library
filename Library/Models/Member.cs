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
    [Required]
    public int SSN { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }

    }
}
