using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class MakeLoanDialog : Form
    {
        private DateTime TimeOfLoan;
        private DateTime DueDate;
        private Member LoanMember;
        private BookCopy LoanBookCopy;

        public DateTime _TimeOfLoan
        {
            get { return TimeOfLoan; }
            set { TimeOfLoan = value; }
        }
        public DateTime _DueDate
        {
            get { return DueDate; }
            set { DueDate = value; }
        }
        public Member _LoanMember
        {
            get { return LoanMember; }
            set { LoanMember = value; }
        }
        public BookCopy _LoanBookCopy
        {
            get { return LoanBookCopy; }
            set { LoanBookCopy = value; }
        }
        public MakeLoanDialog()
        {
            InitializeComponent();
            DateTime ToL = DateTime.Now;
            labelTimeOfLoan.Text = ToL.ToLongDateString();
            DateTime dt = DateTime.Now;
            labelDueDate.Text = dt.AddDays(15).ToLongDateString();
            _TimeOfLoan = ToL;
            _DueDate = dt.AddDays(15);

        }

        private void buttonCreateLoan_Click(object sender, EventArgs e)
        {
            //fixa members och bookcopies;
        }
    }
}
