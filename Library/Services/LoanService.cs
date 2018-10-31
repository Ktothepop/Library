using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class LoanService : IService
  {
    LoanRepository loanRepository;

    public event EventHandler Updated;

    public LoanService(RepositoryFactory rFactory)
    {
      this.loanRepository = rFactory.CreateLoanRepository();
    }

    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }

    public IEnumerable<Loan> All()
    {
      return loanRepository.All();
    }

    public IEnumerable<Loan> GetActiveLoans()
    {
      return from l in loanRepository.All()
             where l.TimeOfReturn == null
             select l;
    }

    public IEnumerable<Loan> GetReturnedLoans()
    {
      return from l in loanRepository.All()
             where l.TimeOfReturn != null
             select l;
    }

    public IEnumerable<Loan> GetOverdueLoans()
    {
      DateTime today = DateTime.Now;
      return from l in loanRepository.All()
             where today > l.DueDate && l.TimeOfReturn == null
             select l;
    }

    public IEnumerable<Loan> GetLoanByMember(Member member)
    {
      return from l in loanRepository.All()
             where l.Member == member
             select l;
    }
    public void EditLoan(Loan loan)
    {
      if (loan != null) {
        loanRepository.Edit(loan);
        OnChanged(EventArgs.Empty);
      }

    }
    public int CalculateFine(Loan loan)
    {
      if ((DateTime.Now - loan.DueDate).Days > 0) {
        return ((DateTime.Now - loan.DueDate).Days) * 10;
      } else return 0;
    }


    public void CreateNewLoan(DateTime timeOfLoan, DateTime dueDate, BookCopy bc, Member member)
    {

      Loan loan = new Loan() {
        TimeOfLoan = timeOfLoan,
        DueDate = dueDate,
        BookCopy = bc,
        Member = member
      };
      bc.IsLoaned = true;
      loanRepository.Add(loan);
      OnChanged(EventArgs.Empty);
    }

    //Returns loan at this actual time
    public int ReturnLoanCurrentTime(Loan loan)
    {
      int userFine = CalculateFine(loan);
      loan.TimeOfReturn = DateTime.Now;
      loan.BookCopy.IsLoaned = false;
      loanRepository.Edit(loan);
      OnChanged(EventArgs.Empty);
      return userFine;
    }
    public void ReturnLoanCustomTime(Loan loan, DateTime returnTime)
    {
      loan.TimeOfReturn = returnTime;
      loanRepository.Edit(loan);
      OnChanged(EventArgs.Empty);
    }


  }
}
