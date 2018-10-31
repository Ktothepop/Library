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
            DateTime overdue = today.AddDays(15);
            return from l in loanRepository.All()
                   where l.TimeOfLoan > overdue
                   select l;
        }

        public IEnumerable<Loan> GetLoanByMember(Member member)
        {
            return from l in loanRepository.All()
                   where l.Member == member
                   select l;
        }

        public int CalculateFine(Loan loan)
        {
            if ((DateTime.Now - loan.TimeOfLoan).Days > 15)
            {
                return ((DateTime.Now - loan.TimeOfLoan).Days) * 10;
            }
            else return 0;
        }


        public void CreateNewLoan(DateTime timeOfLoan, DateTime dueDate, BookCopy bc, Member member)
        {

            Loan loan = new Loan()
            {
                TimeOfLoan = timeOfLoan,
                DueDate = dueDate,
                BookCopy = bc,
                Member = member
            };
            bc.IsLoaned = true;
            loanRepository.Add(loan);
        }
        //Returns loan at this actual time
        public void ReturnLoanCurrentTime(Loan loan)
        {
            loan.TimeOfReturn = DateTime.Now;
            loan.BookCopy.IsLoaned = false;
            loanRepository.Edit(loan);
        }
        public void ReturnLoanCustomTime(Loan loan, DateTime returnTime)
        {
            loan.TimeOfReturn = returnTime;
            loanRepository.Edit(loan);
        }


    }
}
