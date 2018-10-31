using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string Description { get; set; }
        [Required]
        public virtual Author Author { get; set; }
        public virtual ICollection<BookCopy> BookCopies { get; set; }
        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            int bookCopyCount = this.BookCopies == null ? 0 : this.BookCopies.Count();
            return String.Format("{0}", this.Title + " | " + bookCopyCount);
        }
    }
}