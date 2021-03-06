﻿using System;
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
    /// <summary>
    /// Dialog window for creating a Loan object
    /// </summary>
    public partial class MakeLoanDialog : Form
    {
        
        private IEnumerable<Member> membersList = new List<Member>();
        private IEnumerable<BookCopy> bookCopiesList = new List<BookCopy>();
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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inMember">
        /// List of Members
        /// </param>
        /// <param name="inBookCopy">
        /// List of BookCopies
        /// </param>
        public MakeLoanDialog(IEnumerable<Member> inMember, IEnumerable<BookCopy> inBookCopy)
        {
            this.membersList = inMember;
            this.bookCopiesList = inBookCopy;
            InitializeComponent();
            DateTime ToL = DateTime.Now;
            labelTimeOfLoan.Text = ToL.ToLongDateString();
            DateTime dt = DateTime.Now;
            labelDueDate.Text = dt.AddDays(15).ToLongDateString();
            _TimeOfLoan = ToL;
            _DueDate = dt.AddDays(15);

        }
        /// <summary>
        /// Gets Member & bookCopy values from Comboboxes
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void buttonCreateLoan_Click(object sender, EventArgs e)
        {
            _LoanMember = (Member)MembersBox.SelectedItem;
            _LoanBookCopy = (BookCopy)BookCopiesBox.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays Members and BookCopies in Comboboxes
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void MakeLoanDialog_Load(object sender, EventArgs e)
        {
            MembersBox.Items.Clear();
            foreach (Member m in this.membersList)
            {
                MembersBox.Items.Add(m);
            }
            BookCopiesBox.Items.Clear();
            foreach (BookCopy bc in this.bookCopiesList)
            {
                BookCopiesBox.Items.Add(bc);
            }
        }
    }
}
