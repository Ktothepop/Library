using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class LoanService
  {
    LoanRepository loanRepository;

    public LoanService(RepositoryFactory rFactory)
    {
      this.loanRepository = rFactory.CreateLoanRepository();
    }
  }
}
