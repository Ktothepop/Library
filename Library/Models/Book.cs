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
        // vvarföör ska den vara virtual? undrar bara.
        public virtual Author Author { get; set; }
        //"A book could have zero or more book copies" jag antar att vi måste göra en lista av dom ? Fast ska det vara av typen bookcopy eller book?
        public ICollection<BookCopy> BookCopies = new List<BookCopy>();
        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}