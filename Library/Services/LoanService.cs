using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  /// <summary>
  /// This class handles the logic for the Loans in the GUI classes, connected to the BookRepository
  /// Inherits the IService method to handle events in GUI in accordance with the Observable pattern
  /// </summary>
  class LoanService : IService
  {
    LoanRepository loanRepository;

    public event EventHandler Updated;

    /// <summary>
    /// Constructor launches when class is initiated
    /// </summary>
    /// <param name="rFactory">Connection to Loan repository, creates its own through Factory pattern</param>
    public LoanService(RepositoryFactory rFactory)
    {
      this.loanRepository = rFactory.CreateLoanRepository();
    }

    /// <summary>
    /// OnChanged event launched when changes is made 
    /// </summary>
    /// <param name="args">Event arguments, placeholder for future use</param>
    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }

    /// <summary>
    /// Gets all loans
    /// </summary>
    /// <returns>IEnumerable of all Loans</returns>
    public IEnumerable<Loan> All()
    {
      return loanRepository.All();
    }

    /// <summary>
    /// Gets all active loans
    /// </summary>
    /// <returns>IEnumerable of all active Loans</returns>
    public IEnumerable<Loan> GetActiveLoans()
    {
      return from l in loanRepository.All()
             where l.TimeOfReturn == null
             select l;
    }

    /// <summary>
    /// Gets all Loans that have been returned
    /// </summary>
    /// <returns>IEnumerable of all returned Loans</returns>
    public IEnumerable<Loan> GetReturnedLoans()
    {
      return from l in loanRepository.All()
             where l.TimeOfReturn != null
             select l;
    }

    /// <summary>
    /// Gets all loans that are overdue
    /// </summary>
    /// <returns>IEnumerable of all overdue loans</returns>
    public IEnumerable<Loan> GetOverdueLoans()
    {
      DateTime today = DateTime.Now;
      return from l in loanRepository.All()
             where today > l.DueDate && l.TimeOfReturn == null
             select l;
    }

    /// <summary>
    /// Gets all loans that are owed by specific member
    /// </summary>
    /// <param name="member">The member which holds the loans</param>
    /// <returns>IEnumerable of all loans that the member has</returns>
    public IEnumerable<Loan> GetLoanByMember(Member member)
    {
      if (member != null) {
        return from l in loanRepository.All()
               where l.Member == member
               select l;
      } else throw new ArgumentNullException();
    }

    /// <summary>
    /// Edits a method and make sure that the Loan object is saved to DB, and raises OnChanged() event
    /// </summary>
    /// <param name="loan">The edited loan</param>
    public void EditLoan(Loan loan)
    {
      if (loan != null) {
        loanRepository.Edit(loan);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();

    }

    /// <summary>
    /// Calculates the fine of a book
    /// </summary>
    /// <param name="loan">The loan to calculate a fine for</param>
    /// <returns>THe fine of the loan, returns 0 if there is no fine</returns>
    public int CalculateFine(Loan loan)
    {
      if ((DateTime.Now - loan.DueDate).Days > 0) {
        return ((DateTime.Now - loan.DueDate).Days) * 10;
      } else return 0;
    }

    /// <summary>
    /// Creates new loan and makes sure that the loan is added to DB. Raises the OnChanged() event.
    /// </summary>
    /// <param name="timeOfLoan">DateTime of when the loan happened</param>
    /// <param name="dueDate">DateTime of when the loan is due</param>
    /// <param name="bc">Book Copy that is loaned</param>
    /// <param name="member">The member that made the loan</param>
    public void CreateNewLoan(DateTime timeOfLoan, DateTime dueDate, BookCopy bc, Member member)
    {
      if (timeOfLoan != null && dueDate != null && bc != null && member != null) {
        Loan loan = new Loan() {
          TimeOfLoan = timeOfLoan,
          DueDate = dueDate,
          BookCopy = bc,
          Member = member
        };
        bc.IsLoaned = true;
        loanRepository.Add(loan);
        OnChanged(EventArgs.Empty);

      } else throw new ArgumentNullException();
    }
    
    /// <summary>
    /// Returns loan at the actual (system) time
    /// </summary>
    /// <param name="loan">The loan to be returned</param>
    /// <returns>Returns an integer of the fine for the loan, returns a 0 if there is no fine</returns>
    public int ReturnLoanCurrentTime(Loan loan)
    {
      if (loan != null) {
        int userFine = CalculateFine(loan);
        loan.TimeOfReturn = DateTime.Now;
        loan.BookCopy.IsLoaned = false;
        loanRepository.Edit(loan);
        OnChanged(EventArgs.Empty);
        return userFine;
      } else throw new ArgumentNullException();
    }

    /// <summary>
    /// Returns a loan at the designated time
    /// </summary>
    /// <param name="loan">The loan to be returned</param>
    /// <param name="returnTime">DateTime that the book is to be registered as returned on</param>
    public void ReturnLoanCustomTime(Loan loan, DateTime returnTime)
    {
      if (loan != null && returnTime != null) {
        loan.TimeOfReturn = returnTime;
        loanRepository.Edit(loan);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();
    }


  }
}
